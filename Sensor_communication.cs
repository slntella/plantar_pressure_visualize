using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Semester_Project_Plantar_Pressure
{
    public class Sensors
    {
        public static BluetoothDeviceInfo[] devices;
        public static BluetoothDeviceInfo device_in_use;
        public static BluetoothClient btClient = new BluetoothClient();
        public static List<string[]> bt_row_list = new List<string[]>();
        public static string error_message = "";
        private static uint UART_RX_IDX_MAX = 2047;
        static public bool connection_established = false;
        private float[] numbers = new float[Feet_Info.nb_sensors];
        private byte[] uart_rx_buf = new byte[UART_RX_IDX_MAX+1];
        private uint sbuf_write = 0; //pointeur d'écriture dans le buffer
        private uint sbuf_read = 0; //pointeur de lecture dans le buffer
        private uint Overflow = 0;
        private float[] deserialise_binary(byte[] incomming_stream)
        {
            float[] float_output = new float[(int)incomming_stream.Length / sizeof(float)];

            for (int i = 0; i < float_output.Length; i++)
            {
                float_output[i] = BitConverter.ToSingle(incomming_stream, sizeof(float) * i);
            }
            return float_output;
        }

        private Stream stream = null;
       
        public async Task<float[]> read_sensors()
        {
            if (btClient.Connected)
            {
                //Debug.Write("[bt_connection test : " + tmp_stopwatch.ElapsedMilliseconds + " ¦ ");
                //tmp_stopwatch.Restart();
                try
                {
                    //Debug.Write("try : " + tmp_stopwatch.ElapsedMilliseconds + " ¦ ");
                    //tmp_stopwatch.Restart();

                    stream.ReadTimeout = 1;
                    int readbytes = 0;
                    try
                    {
                        readbytes = stream.Read(uart_rx_buf, (int)(sbuf_write & UART_RX_IDX_MAX), (int)(UART_RX_IDX_MAX - (sbuf_write & UART_RX_IDX_MAX) + 1));
                        sbuf_write += (uint)readbytes;
                    }   catch (Exception e) { return numbers; }

                    if ((sbuf_write & UART_RX_IDX_MAX) == 0)
                    {   try
                        {
                            readbytes = stream.Read(uart_rx_buf, (int)(sbuf_write & UART_RX_IDX_MAX), (int)(UART_RX_IDX_MAX - (sbuf_write & UART_RX_IDX_MAX) + 1));
                            sbuf_write += (uint)readbytes;
                        }
                        catch (Exception e) { }
                    }
                    //synch first
                    int read = 0;
                    byte[] synch_bytes = new byte[sizeof(float)];
                    byte[] synch_byte = new byte[1];
                    byte[] byteReceived = new byte[sizeof(float) * numbers.Length];
                   

                    while ((sbuf_write - sbuf_read) >= (byteReceived.Length + 2 * sizeof(float)))
                    {
                        float test = 0.0f;
                        while ((test != 15615.0) && (sbuf_write - sbuf_read) > 0)
                        {
                            Byte tmp = uart_rx_buf[sbuf_read & UART_RX_IDX_MAX];
                            sbuf_read++;
                            for (int i = 0; i < 3; i++) synch_bytes[i] = synch_bytes[i + 1]; //we shift everything to the left;
                            synch_bytes[3] = tmp;
                            test = BitConverter.ToSingle(synch_bytes, 0);
                        }

                        if (test == 15615.0)
                        {

                            if ((sbuf_write - sbuf_read) >= byteReceived.Length + sizeof(float))
                            {
                                for (int i = 0; i < 4; i++) synch_bytes[i] = uart_rx_buf[(sbuf_read + byteReceived.Length + i) & UART_RX_IDX_MAX];
                                if (BitConverter.ToSingle(synch_bytes, 0) == 15700.0)
                                {
                                    //on a un message complet, il faut l'interpréter
                                    for (int i = 0; i < byteReceived.Length; i++) byteReceived[i] = uart_rx_buf[(sbuf_read + i) & UART_RX_IDX_MAX];
                                    numbers = deserialise_binary(byteReceived);
                                    sbuf_read = sbuf_read + (uint)byteReceived.Length + sizeof(float);
                                    read++;
                                }

                            }
                            else
                            {
                                sbuf_read -= sizeof(float);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    error_message = e.Message;
                }
            }
            else
            {
                numbers = Feet_Info.empty_feet().sensor_list;
            }

            return numbers;
        }
        public int set_valve(int valveId,bool state)
        {
            if (btClient.Connected)
            {
                try
                {
                    string tmp;
                    if (state)
                    {
                        tmp = $"S{valveId}\n";
                    } else
                    {
                        tmp = $"C{valveId}\n";
                    }
                    stream.Write(Encoding.ASCII.GetBytes(tmp), 0, tmp.Length);

                }
                catch (Exception e)
                {
                    error_message = e.Message;
                }
            }

            return 0;
        }
        public void connect_bt()
        {

            var serviceClass = BluetoothService.SerialPort;
            var ep = new BluetoothEndPoint(device_in_use.DeviceAddress, serviceClass);

            if (btClient != null)
            {
                btClient.Close();
            }
            btClient = new BluetoothClient();

            try
            {
                if (!device_in_use.Connected)
                {
                    btClient.Connect(ep);

                }
                stream = btClient.GetStream();
                connection_established = true;
            }
            catch (System.Net.Sockets.SocketException e)
            {
                MessageBox.Show(e.Message);
                btClient.Close();
                connection_established = false;
                return;
            }

        }
        public void bt_list_info()
        {
            String authenticated;
            String connected;
            String deviceAddress;
            String deviceName;
            List<string[]> row_list = new List<string[]>();

            foreach (BluetoothDeviceInfo device in devices)
            {
                authenticated = device.Authenticated.ToString();
                connected = device.Connected.ToString();
                deviceAddress = device.DeviceAddress.ToString();
                deviceName = device.DeviceName.ToString();
                string[] row = new string[] { deviceName, authenticated, connected, deviceAddress };
                row_list.Add(row);
            }
            bt_row_list = row_list;
        }

        public void scan()
        {
            BluetoothClient client = new BluetoothClient();
            devices = client.DiscoverDevices().ToArray();
        }



    }
}

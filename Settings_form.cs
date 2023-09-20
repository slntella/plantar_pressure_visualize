using InTheHand.Net.Sockets;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Semester_Project_Plantar_Pressure
{
    public partial class Settings_form : Form
    {
        public static Sensors bt_sensor = new Sensors();
        public static bool changes_made = false;
        private Graphics settings_graph;
        private Display settings_disp = new Display();
        public static float[] sensor_values = new float[Feet_Info.nb_sensors];
        private object lockObject = new object();

        public Settings_form()
        {
            InitializeComponent();
            try
            {
                TextReader tr = new StreamReader("area_preferences.txt");
                txtbx_foot_reg.Text = tr.ReadToEnd();
                tr.Close();

                tr = new StreamReader("pmi_preferences.txt");
                txtbx_MM.Text = tr.ReadLine();
                txtbx_MF.Text = tr.ReadLine();
                txtbx_LM.Text = tr.ReadLine();
                txtbx_LF.Text = tr.ReadLine();
                txtbx_Heel.Text = tr.ReadLine();
                tr.Close();
            }
            catch (Exception ex) { }
            settings_graph = pnl_settings_feet.CreateGraphics();
            Bluetooth_grid.Columns.Add("c1", "Device Name");
            Bluetooth_grid.Columns.Add("c2", "Authenticated");
            Bluetooth_grid.Columns.Add("c3", "Connected");
            Bluetooth_grid.Columns.Add("c4", "Device Address");
            draw_bt_list();
        }
        public static async Task<float[]> read_btAsync()
        {
            return await bt_sensor.read_sensors();
        }

        public void refresh_bluetooth()
        {
            wrk_scan_bluetooth.RunWorkerAsync();
        }
        private void btn_refresh_bt_Click(object sender, EventArgs e)
        {
            Bluetooth_grid.Rows.Clear();
            txt_searching.Text = "Searching, please wait";
            wrk_scan_bluetooth.RunWorkerAsync();
        }

        private void btn_bt_select_Click(object sender, EventArgs e)
        {
            txt_searching.Text = "Atempting to connect";
            BluetoothClient client = new BluetoothClient();
            try
            {
                int i = Bluetooth_grid.SelectedRows[0].Index;

                if (Sensors.devices.Length != 0 && i < Sensors.devices.Length)
                {
                    Sensors.device_in_use = Sensors.devices[i];
                    bt_sensor.connect_bt();
                    if (Sensors.connection_established)
                    {
                        txt_selected_device.Text = "Connected device : " + Sensors.device_in_use.DeviceName.ToString();
                    }
                    else
                    {
                        txt_selected_device.Text = "No connection";
                    }
                }
            }
            catch (Exception ex) { }
            txt_searching.Text = " ";
        }

        private void Settings_form_Load(object sender, EventArgs e)
        {

        }
        private void wrk_scan_bluetooth_DoWork(object sender, DoWorkEventArgs e)
        {
            bt_sensor.scan();
            bt_sensor.bt_list_info();
        }

        private void draw_bt_list()
        {
            foreach (string[] row in Sensors.bt_row_list)
            {
                Bluetooth_grid.Rows.Add(row);
            }
        }
        private void wrk_scan_bluetooth_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_apply_areas_Click(object sender, EventArgs e)
        {
            settings_graph.Clear(Color.White);
            Display.read_regions(txtbx_foot_reg.Text);
            string[] pmi_regions = { txtbx_MM.Text, txtbx_MF.Text, txtbx_LM.Text, txtbx_LF.Text, txtbx_Heel.Text };
            Display.read_pmi_regions(pmi_regions);

            lock (lockObject)
            {
                settings_disp.draw_settings(settings_graph);
            }
            try
            {
                TextWriter tw = new StreamWriter("area_preferences.txt");
                tw.Write(txtbx_foot_reg.Text);
                tw.Close();

                tw = new StreamWriter("PMI_preferences.txt");

                tw.WriteLine(txtbx_MM.Text);
                tw.WriteLine(txtbx_MF.Text);
                tw.WriteLine(txtbx_LM.Text);
                tw.WriteLine(txtbx_LF.Text);
                tw.WriteLine(txtbx_Heel.Text);
                tw.Close();
                changes_made = true;
                System.Diagnostics.Debug.WriteLine("changed status");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_regions_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset the values to default ?", "Confirm Reset",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                txtbx_foot_reg.Text = "Forefoot : 1,2,3,4,5,6,7,8,9,10 \r\nMiddlefoot: 11,12,13,14,15,16,17,18,19,20 \r\nRearfoot: 21,22,23,24,25,26,27,28,29,30";
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Semester_Project_Plantar_Pressure
{
    public struct Feet_data_struct
    {
        public float mean;
        public float std;
        public float peak_val;
        public float MM;
        public float MF;
        public float LM;
        public float LF;
        public float HEEL;
        public float pmi;
        public float power_ratio;
        public float min_val;

        public List<float> area_load;
        public List<float> area_min;
        public List<float> area_max;
        public List<float> area_std;
        public List<float> area_mean;
        public List<float> area_pr;
    };
    internal class Feet_Info
    {
        public static int nb_sensors = 31;

        public Feet_data_struct feet_data = new Feet_data_struct();
        public string id;
        public float[] sensor_list = new float[nb_sensors];
        public static string[] foot_areas_names =
        {
            "Forefoot", "Middlefoot", "Rearfoot"
        };

        public static int[][] pmi_areas;
        public static int[][] foot_areas;

        public Feet_Info(float[] a_sensor_list)
        {
            string s = "";
            for (int i = 0; i < nb_sensors; i++)
            {
                s += a_sensor_list[i].ToString();
            }
            id = s;
            sensor_list = a_sensor_list.ToArray();
        }

        private static float offset = (float)0.0;
        public static Feet_Info empty_feet()
        {
            float[] empty_array = new float[nb_sensors];

            for (float i = 0; i < nb_sensors; i++)
            {
                empty_array[(int)i] = i + offset;
            }

            offset = offset + (float)0.5;
            if (offset > 15) { offset = 0; }

            return new Feet_Info(empty_array);
        }
        private void calculate_power_ratio(int[] array_to_trasform, bool all_sensors)
        {
            double TP = 0;
            double LFP = 0;

            AForge.Math.Complex[] cmplx_sensors = new AForge.Math.Complex[array_to_trasform.Length];
            int count = 0;
            foreach (int i in array_to_trasform)
            {
                cmplx_sensors[count].Re = sensor_list[i - 1];
                cmplx_sensors[count].Im = 0;
                count++;
            }
            AForge.Math.FourierTransform.DFT(cmplx_sensors, AForge.Math.FourierTransform.Direction.Forward);

            for (int i = 0; i < array_to_trasform.Length; i++)
            {
                TP += cmplx_sensors[i].Magnitude * cmplx_sensors[i].Magnitude;
                if (i < array_to_trasform.Length / 4)
                {
                    LFP += cmplx_sensors[i].Magnitude * cmplx_sensors[i].Magnitude;
                }
            }

            TP -= cmplx_sensors[0].Magnitude * cmplx_sensors[0].Magnitude;
            LFP -= cmplx_sensors[0].Magnitude * cmplx_sensors[0].Magnitude;

            if (all_sensors)
            {
                feet_data.power_ratio = (float)(100 * (TP - LFP) / TP);
            }
            else
            {
                feet_data.area_pr.Add((float)(100 * (TP - LFP) / TP));
            }
        }
        public void calculate_var()
        {
            feet_data.area_load = new List<float>();
            feet_data.area_pr = new List<float>();
            feet_data.area_min = new List<float>();
            feet_data.area_max = new List<float>();
            feet_data.area_mean = new List<float>();
            feet_data.area_std = new List<float>();

            float total_sum = 0;
            float sum = 0;
            float max = 0;
            float min = sensor_list[0];

            int[] all_sensors = new int[nb_sensors];

            for (int i = 0; i < nb_sensors; i++)
            {

                if (sensor_list[i] < min) { min = sensor_list[i]; }
                if (sensor_list[i] > max) { max = sensor_list[i]; }
                total_sum = total_sum + sensor_list[i];
                all_sensors[i] = i + 1;
            }

            calculate_power_ratio(all_sensors, true);

            feet_data.mean = total_sum / nb_sensors;
            feet_data.min_val = min;
            feet_data.peak_val = max;

            for (int i = 0; i < nb_sensors; i++)
            {
                sum = sum + (sensor_list[i] - feet_data.mean) * (sensor_list[i] - feet_data.mean);
            }

            feet_data.std = (float)Math.Sqrt(sum / nb_sensors);

            sum = 0;

            foreach (var mm_sensors in pmi_areas[0])
            {
                sum = sum + sensor_list[mm_sensors - 1];

            }

            feet_data.MM = sum;
            sum = 0;

            foreach (var mf_sensors in pmi_areas[1])
            {
                sum = sum + sensor_list[mf_sensors - 1];
            }
            feet_data.MF = sum;
            sum = 0;

            foreach (var lm_sensors in pmi_areas[2])
            {
                sum = sum + sensor_list[lm_sensors - 1];
            }
            feet_data.LM = sum;
            sum = 0;

            foreach (var lf_sensors in pmi_areas[3])
            {
                sum = sum + sensor_list[lf_sensors - 1];
            }
            feet_data.LF = sum;
            feet_data.pmi = (feet_data.MM + feet_data.MF) / total_sum;

            sum = 0;

            foreach (var lf_sensors in pmi_areas[4])
            {
                sum = sum + sensor_list[lf_sensors - 1];
            }
            feet_data.HEEL = sum;

            foreach (var area_sensors in foot_areas)
            {
                max = 0;
                min = sensor_list[area_sensors[0] - 1];
                sum = 0;

                foreach (var s in area_sensors)
                {
                    if (sensor_list[s - 1] < min) { min = sensor_list[s - 1]; }
                    if (sensor_list[s - 1] > max) { max = sensor_list[s - 1]; }
                    sum = sum + sensor_list[s - 1];
                }

                calculate_power_ratio(area_sensors, false);
                feet_data.area_load.Add(sum);
                feet_data.area_min.Add(min);
                feet_data.area_max.Add(max);
                float mean = sum / area_sensors.Length;

                feet_data.area_mean.Add(sum / area_sensors.Length);

                sum = 0;
                foreach (var s in area_sensors)
                {
                    sum = sum + (sensor_list[s - 1] - mean) * (sensor_list[s - 1] - mean);
                }

                feet_data.area_std.Add((float)Math.Sqrt(sum / area_sensors.Length));
            }
        }
    }
}

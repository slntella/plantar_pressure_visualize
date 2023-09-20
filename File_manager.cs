using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


namespace Semester_Project_Plantar_Pressure
{
    internal class File_manager
    {
        private Display settings_display = new Display();
        public static List<Tuple<int, float[]>> deformat_feet_info(string file_string)
        {
            List<Tuple<int, float[]>> rec_val = new List<Tuple<int, float[]>>();
            List<List<float>> file_val = JsonSerializer.Deserialize<List<List<float>>>(file_string);

            foreach (var f in file_val)
            {
                int timestamp = (int)f[f.Count - 1];
                f.RemoveAt(f.Count - 1);

                rec_val.Add(new Tuple<int, float[]>(timestamp, f.ToArray()));

            }
            return rec_val;
        }
        public static string format_feet_info(List<Tuple<int, Feet_Info>> feet_list, int frame_nbr)
        {

            List<List<float>> file_val = new List<List<float>>();

            for (int i = 0; i < frame_nbr; i++)
            {
                List<float> tmp_list = feet_list[i].Item2.sensor_list.ToList();
                tmp_list.Add((float)feet_list[i].Item1);
                file_val.Add(tmp_list);
            }

            return JsonSerializer.Serialize(file_val);
        }
    }
}


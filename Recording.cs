using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Semester_Project_Plantar_Pressure
{
    internal class Recording
    {
        public List<Tuple<int, Feet_Info>> frame_list = new List<Tuple<int, Feet_Info>>();
        public int current_col = 0;
        public int total_columns = 0;
        public int rec_frequecy = 10;
        public Sensors sensor = new Sensors();

        public Recording()
        {
            frame_list.Add(new Tuple<int, Feet_Info>(0, Feet_Info.empty_feet()));
        }

        public Stopwatch tmp_stopwatch = new Stopwatch();
        public Tuple<int, Feet_Info> find_frame(int time_stamp)
        {
            int upper = frame_list.Count() - 1;
            int lower = 0;
            while (upper - lower > 1)
            {
                int middle = (upper - lower) / 2 + lower;

                if (frame_list[middle].Item1 < time_stamp)
                {
                    lower = middle;
                }
                else
                {
                    upper = middle;
                }
            }

            current_col = upper;
            return frame_list[upper];
        }
        public void reset_recording()
        {
            current_col = 0;
            total_columns = 0;
            frame_list = new List<Tuple<int, Feet_Info>>();
        }


    }

}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Semester_Project_Plantar_Pressure
{
    internal class Display
    {
        private SolidBrush[] brush_list =
        {
            new SolidBrush(Color.Black),
            new SolidBrush(Color.DarkBlue),
            new SolidBrush(Color.Blue),
            new SolidBrush(Color.Cyan),
            new SolidBrush(Color.Lime),
            new SolidBrush(Color.Yellow),
            new SolidBrush(Color.Orange),
            new SolidBrush(Color.Red),
            new SolidBrush(Color.DarkRed),
            new SolidBrush(Color.MediumVioletRed),
            new SolidBrush(Color.Violet),
        };

        private float[] thresholds = { 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };

        private Point[] sensor_map =
        {
            new Point(68, 50), //1
            new Point(105, 50), //2
            new Point(142, 50), //3
            new Point(179, 50), //4
            new Point(50, 100), //5
            new Point(87, 100), //6
            new Point(125, 100), //7
            new Point(162, 100), //8
            new Point(199, 100), //9
            new Point(50, 150), //10
            new Point(87, 150), //11
            new Point(125, 150), //12
            new Point(162, 150), //13
            new Point(199, 150), //14
            new Point(50, 200), //15
            new Point(87, 200), //16
            new Point(125, 200), //17
            new Point(162, 200), //18
            new Point(199, 200), //19
            new Point(68, 250), //20
            new Point(105, 250), //21
            new Point(142, 250), //22
            new Point(179, 250), //23
            new Point(87, 350), //24
            new Point(125, 350), //25
            new Point(162, 350), //26
            new Point(87, 400), //27
            new Point(125, 400), //28
            new Point(162, 400), //29
            new Point(105, 450), //30
            new Point(142, 450), //31
            new Point(163, 500), //32
            new Point(100, 600), //33
            new Point(150, 600), //34



        };
        private int get_color(float itensity)
        {
            int index = 0;
            while (index < thresholds.Count())
            {
                if (itensity < thresholds[index])
                {
                    return index;
                }
                index++;
            }
            return index;
        }
        public void draw_feet(Graphics g, float[] sensor_list)
        {
            for (int i = 0; i < sensor_list.Count(); i++)
            {
                SolidBrush brush = brush_list[get_color(sensor_list[i])];
                g.FillEllipse(brush, sensor_map[i].X - Feet_Info.nb_sensors / 2,
                    sensor_map[i].Y - Feet_Info.nb_sensors / 2, Feet_Info.nb_sensors, Feet_Info.nb_sensors);
                g.FillRectangle(new SolidBrush(Color.FloralWhite), (float)(sensor_map[i].X - Feet_Info.nb_sensors / 1.6)
                    , sensor_map[i].Y - Feet_Info.nb_sensors, (float)1.2 * Feet_Info.nb_sensors, Feet_Info.nb_sensors / 2);
                g.DrawString(sensor_list[i].ToString("n2"), new Font("Arial", 10), brush_list[0],
                    sensor_map[i].X - 15, sensor_map[i].Y - 30);
            }
        }
        public static void read_regions(string reg_text)
        {
            bool name_reg = true;
            bool next_line = false;
            bool sensor_reg = false;
            string number = "";
            string reg_name = "";
            List<int> reg_sensors = new List<int>();
            List<string> foot_areas_names = new List<string>();
            List<List<int>> foot_areas = new List<List<int>>();
            try
            {
                if (reg_text == "none")
                {
                    foot_areas_names.Add("All");
                    for (int i = 1; i < Feet_Info.nb_sensors; i++)
                    {
                        reg_sensors.Add(i);
                    }
                    foot_areas.Add(reg_sensors);
                }
                foreach (char c in reg_text)
                {
                    if (c == '\n')
                    {
                        if (number != "")
                        {
                            reg_sensors.Add(int.Parse(number));
                            number = "";
                            foot_areas.Add(reg_sensors);
                        }
                        name_reg = true;
                        next_line = false;
                        sensor_reg = false;
                        number = "";
                        reg_name = "";
                        reg_sensors = new List<int>();
                    }
                    if (c != ' ')
                    {
                        if (sensor_reg)
                        {
                            if (c == ',')
                            {
                                reg_sensors.Add(int.Parse(number));
                                number = "";
                            }
                            else
                            {
                                number += c.ToString();
                            }
                        }
                        else if (c == ':')
                        {
                            name_reg = false;
                            sensor_reg = true;
                            string cleaned = reg_name.Replace("\n", "").Replace("\r", "");
                            foot_areas_names.Add(cleaned);
                            reg_name = "";
                        }
                        else if (name_reg)
                        {
                            reg_name += c.ToString();
                        }
                    }
                }
                if (number != "")
                {
                    reg_sensors.Add(int.Parse(number));
                    number = "";
                    foot_areas.Add(reg_sensors);
                }
                Feet_Info.foot_areas_names = foot_areas_names.ToArray();
                Feet_Info.foot_areas = foot_areas.Select(a => a.ToArray()).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void read_pmi_regions(string[] reg_text)
        {
            string number = "";
            List<int> reg_sensors = new List<int>();
            List<List<int>> pmi_foot_areas = new List<List<int>>();
            try
            {
                foreach (string area_sensors in reg_text)
                {
                    foreach (char c in area_sensors)
                    {
                        if (c != ' ')
                        {
                            if (c == ',')
                            {
                                reg_sensors.Add(int.Parse(number));
                                number = "";
                            }
                            else
                            {
                                number += c.ToString();
                            }
                        }
                    }
                    if (number != "")
                    {
                        reg_sensors.Add(int.Parse(number));
                        number = "";
                        pmi_foot_areas.Add(reg_sensors);
                    }
                    number = "";
                    reg_sensors = new List<int>();
                }

                Feet_Info.pmi_areas = pmi_foot_areas.Select(a => a.ToArray()).ToArray();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void draw_settings(Graphics g)
        {
            for (int i = 0; i < Feet_Info.foot_areas.Count(); i++)
            {
                int b_nbr;

                if (i > brush_list.Count())
                {
                    b_nbr = 0;
                }
                else
                {
                    b_nbr = i;
                }
                for (int j = 0; j < Feet_Info.foot_areas[i].Count(); j++)
                {
                    g.FillEllipse(brush_list[b_nbr],
                        (int)sensor_map[Feet_Info.foot_areas[i][j] - 1].X / 2 - Feet_Info.nb_sensors / 2,
                        (int)sensor_map[Feet_Info.foot_areas[i][j] - 1].Y / 2 - Feet_Info.nb_sensors / 2,
                        Feet_Info.nb_sensors / 2, Feet_Info.nb_sensors / 2);

                    g.DrawString(Feet_Info.foot_areas[i][j].ToString(), new Font("Arial", 10), brush_list[0],
                        (int)sensor_map[Feet_Info.foot_areas[i][j] - 1].X / 2 - 15,
                        (int)sensor_map[Feet_Info.foot_areas[i][j] - 1].Y / 2 - 28);
                }
            }
        }
    }
    public class BoxDataCollection : List<BoxData>
    {
        public BoxDataCollection(Feet_data_struct feet_data, bool disp_all)
        {
            if (disp_all)
            {
                Add(new BoxData
                {
                    Region = "All sensors",
                    LowWhisker = feet_data.min_val,
                    UpWhisker = feet_data.peak_val,
                    LowWBox = feet_data.mean - Math.Abs(feet_data.std)
                    ,
                    UpBox = feet_data.mean + Math.Abs(feet_data.std),
                    Average = feet_data.mean
                });
            }

            for (int i = 0; i < Feet_Info.foot_areas_names.Length; i++)
            {

                Add(new BoxData
                {
                    Region = Feet_Info.foot_areas_names[i],
                    LowWhisker = feet_data.area_min[i],
                    UpWhisker = feet_data.area_max[i],
                    LowWBox = feet_data.area_mean[i] - Math.Abs(feet_data.area_std[i]),
                    UpBox = feet_data.area_mean[i] + Math.Abs(feet_data.area_std[i]),
                    Average = feet_data.area_mean[i]
                });
            }
        }
    }

    public class BoxData
    {
        public string Region { get; set; }
        public double LowWhisker { get; set; }
        public double UpWhisker { get; set; }
        public double LowWBox { get; set; }
        public double UpBox { get; set; }
        public double Average { get; set; }
    }

    public class HistogramDataCollection : List<HistogramData>
    {
        public HistogramDataCollection(List<float> area_values, float main_value, bool disp_all)
        {
            if (disp_all)
            {
                Add(new HistogramData
                {
                    Region = "All sensors",
                    box_height = main_value,
                });
            }

            for (int i = 0; i < Feet_Info.foot_areas_names.Length; i++)
            {
                Add(new HistogramData
                {
                    Region = Feet_Info.foot_areas_names[i],
                    box_height = area_values[i],
                });
            }
        }
    }

    public class HistogramData
    {
        public string Region { get; set; }
        public double box_height { get; set; }
    }
}

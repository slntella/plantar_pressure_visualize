﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project_Plantar_Pressure
{
    public partial class ValvesSate : Form
    {
        public ValvesSate()
        {
            InitializeComponent();
            /*
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            */
        }

        private void ValvesSate_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(1, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(2, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(3, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(4, checkBox4.Checked);
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(5, checkBox5.Checked);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(6, checkBox6.Checked);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(7, checkBox7.Checked);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(8, checkBox8.Checked);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(9, checkBox9.Checked);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(10, checkBox10.Checked);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(11, checkBox11.Checked);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(12, checkBox12.Checked);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(13, checkBox13.Checked);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(14, checkBox14.Checked);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(15, checkBox15.Checked);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(16, checkBox16.Checked);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(17, checkBox17.Checked);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(18, checkBox18.Checked);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(19, checkBox19.Checked);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(20, checkBox20.Checked);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(21, checkBox21.Checked);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(22, checkBox22.Checked);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(23, checkBox23.Checked);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(24, checkBox24.Checked);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(25, checkBox25.Checked);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(26, checkBox26.Checked);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(27, checkBox27.Checked);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(28, checkBox28.Checked);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(29, checkBox29.Checked);
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(30, checkBox30.Checked);
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            Settings_form.bt_sensor.set_valve(31, checkBox31.Checked);
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox32.Checked;
            checkBox2.Checked = checkBox32.Checked;
            checkBox3.Checked = checkBox32.Checked;
            checkBox4.Checked = checkBox32.Checked;
            checkBox5.Checked = checkBox32.Checked;
            checkBox6.Checked = checkBox32.Checked;
            checkBox7.Checked = checkBox32.Checked;
            checkBox8.Checked = checkBox32.Checked;
            checkBox9.Checked = checkBox32.Checked;
            checkBox10.Checked = checkBox32.Checked;
            checkBox11.Checked = checkBox32.Checked;
            checkBox12.Checked = checkBox32.Checked;
            checkBox13.Checked = checkBox32.Checked;
            checkBox14.Checked = checkBox32.Checked;
            checkBox15.Checked = checkBox32.Checked;
            checkBox16.Checked = checkBox32.Checked;
            checkBox17.Checked = checkBox32.Checked;
            checkBox18.Checked = checkBox32.Checked;
            checkBox19.Checked = checkBox32.Checked;
            checkBox20.Checked = checkBox32.Checked;
            checkBox21.Checked = checkBox32.Checked;
            checkBox22.Checked = checkBox32.Checked;
            checkBox23.Checked = checkBox32.Checked;
            checkBox24.Checked = checkBox32.Checked;
            checkBox25.Checked = checkBox32.Checked;
            checkBox26.Checked = checkBox32.Checked;
            checkBox27.Checked = checkBox32.Checked;
            checkBox28.Checked = checkBox32.Checked;
            checkBox29.Checked = checkBox32.Checked;
            checkBox30.Checked = checkBox32.Checked;
            checkBox31.Checked = checkBox32.Checked;
            Settings_form.bt_sensor.set_valve(0, checkBox32.Checked);
        }
    }
}

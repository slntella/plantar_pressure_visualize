﻿namespace Semester_Project_Plantar_Pressure
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_rec_len = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_rec_status = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_start_stop = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this.btn_cont_read = new System.Windows.Forms.ToolStripButton();
            this.txt_cont_read = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelBat = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_connection_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_load = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valvesSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.num_rec_fr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Apply_rec_fr = new System.Windows.Forms.Button();
            this.btn_load_frame = new System.Windows.Forms.Button();
            this.num_disp_time = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sld_rec_time = new System.Windows.Forms.TrackBar();
            this.txt_max_length = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cursor_val = new System.Windows.Forms.Label();
            this.data_table = new System.Windows.Forms.TableLayoutPanel();
            this.txt_pr = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_pmi = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_peak_p = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_var = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mean = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmr_refresh_text = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txt_frame_count = new System.Windows.Forms.Label();
            this.drawing_pannel = new System.Windows.Forms.Panel();
            this.txt_hf_rec_msg = new System.Windows.Forms.TextBox();
            this.bar_rec_data_calc = new System.Windows.Forms.ProgressBar();
            this.txt_calc_rec_data = new System.Windows.Forms.Label();
            this.wrk_rec_data_calc = new System.ComponentModel.BackgroundWorker();
            this.worker_read_bt = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BoxPlot = new System.Windows.Forms.TabPage();
            this.chrt_mean_var = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_hist = new System.Windows.Forms.TabPage();
            this.load_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pr_hist = new System.Windows.Forms.TabPage();
            this.pr_histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wrk_screen_update = new System.ComponentModel.BackgroundWorker();
            this.tmr_update_screen = new System.Windows.Forms.Timer(this.components);
            this.btn_calc_data = new System.Windows.Forms.Button();
            this.btn_clear_panel = new System.Windows.Forms.Button();
            this.btn_display_all = new System.Windows.Forms.CheckBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rec_fr)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_disp_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sld_rec_time)).BeginInit();
            this.data_table.SuspendLayout();
            this.drawing_pannel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BoxPlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_mean_var)).BeginInit();
            this.load_hist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_histogram)).BeginInit();
            this.pr_hist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pr_histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.lbl_rec_len,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lbl_rec_status,
            this.toolStripSeparator3,
            this.btn_start_stop,
            this.btn_reset,
            this.btn_cont_read,
            this.txt_cont_read,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1160, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(104, 36);
            this.toolStripLabel3.Text = "Recording length :";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // lbl_rec_len
            // 
            this.lbl_rec_len.Name = "lbl_rec_len";
            this.lbl_rec_len.Size = new System.Drawing.Size(55, 36);
            this.lbl_rec_len.Text = "00:00:000";
            this.lbl_rec_len.Click += new System.EventHandler(this.lbl_rec_len_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 36);
            this.toolStripLabel1.Text = "Recording status :";
            // 
            // lbl_rec_status
            // 
            this.lbl_rec_status.Name = "lbl_rec_status";
            this.lbl_rec_status.Size = new System.Drawing.Size(58, 36);
            this.lbl_rec_status.Text = "■ Paused";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_start_stop.Image")));
            this.btn_start_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(96, 36);
            this.btn_start_stop.Text = "Start/Stop";
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Control;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(71, 36);
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cont_read
            // 
            this.btn_cont_read.Image = ((System.Drawing.Image)(resources.GetObject("btn_cont_read.Image")));
            this.btn_cont_read.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cont_read.Name = "btn_cont_read";
            this.btn_cont_read.Size = new System.Drawing.Size(157, 36);
            this.btn_cont_read.Text = "Continuous Reading :";
            this.btn_cont_read.Click += new System.EventHandler(this.btn_cont_read_Click);
            // 
            // txt_cont_read
            // 
            this.txt_cont_read.ForeColor = System.Drawing.Color.Red;
            this.txt_cont_read.Name = "txt_cont_read";
            this.txt_cont_read.Size = new System.Drawing.Size(17, 36);
            this.txt_cont_read.Text = "■";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(91, 36);
            this.toolStripLabel2.Text = "Battery Charge :";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(0, 36);
            // 
            // toolStripLabelBat
            // 
            this.toolStripLabelBat.Name = "toolStripLabelBat";
            this.toolStripLabelBat.Size = new System.Drawing.Size(23, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_connection_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1160, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Connection status :";
            // 
            // lbl_connection_status
            // 
            this.lbl_connection_status.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_connection_status.Name = "lbl_connection_status";
            this.lbl_connection_status.Size = new System.Drawing.Size(86, 17);
            this.lbl_connection_status.Text = "Not connected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.valvesSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_load,
            this.MenuItem_save,
            this.MenuItem_saveas});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItem_load
            // 
            this.MenuItem_load.Name = "MenuItem_load";
            this.MenuItem_load.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_load.Text = "Load";
            this.MenuItem_load.Click += new System.EventHandler(this.MenuItem_load_Click);
            // 
            // MenuItem_save
            // 
            this.MenuItem_save.Name = "MenuItem_save";
            this.MenuItem_save.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_save.Text = "Save";
            this.MenuItem_save.Click += new System.EventHandler(this.MenuItem_save_Click);
            // 
            // MenuItem_saveas
            // 
            this.MenuItem_saveas.Name = "MenuItem_saveas";
            this.MenuItem_saveas.Size = new System.Drawing.Size(112, 22);
            this.MenuItem_saveas.Text = "Save as";
            this.MenuItem_saveas.Click += new System.EventHandler(this.MenuItem_saveas_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // valvesSettingsToolStripMenuItem
            // 
            this.valvesSettingsToolStripMenuItem.Name = "valvesSettingsToolStripMenuItem";
            this.valvesSettingsToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.valvesSettingsToolStripMenuItem.Text = "Valves Settings";
            this.valvesSettingsToolStripMenuItem.Click += new System.EventHandler(this.valvesSettingsToolStripMenuItem_Click);
            // 
            // num_rec_fr
            // 
            this.num_rec_fr.Location = new System.Drawing.Point(162, 26);
            this.num_rec_fr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_rec_fr.Name = "num_rec_fr";
            this.num_rec_fr.Size = new System.Drawing.Size(65, 20);
            this.num_rec_fr.TabIndex = 5;
            this.num_rec_fr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recording frequency (Hz)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Apply_rec_fr);
            this.groupBox1.Controls.Add(this.btn_load_frame);
            this.groupBox1.Controls.Add(this.num_disp_time);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_rec_fr);
            this.groupBox1.Location = new System.Drawing.Point(838, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording parameters";
            // 
            // Apply_rec_fr
            // 
            this.Apply_rec_fr.Location = new System.Drawing.Point(233, 24);
            this.Apply_rec_fr.Name = "Apply_rec_fr";
            this.Apply_rec_fr.Size = new System.Drawing.Size(77, 20);
            this.Apply_rec_fr.TabIndex = 10;
            this.Apply_rec_fr.Text = "Apply";
            this.Apply_rec_fr.UseVisualStyleBackColor = true;
            this.Apply_rec_fr.Click += new System.EventHandler(this.Apply_rec_fr_Click);
            // 
            // btn_load_frame
            // 
            this.btn_load_frame.Location = new System.Drawing.Point(233, 49);
            this.btn_load_frame.Name = "btn_load_frame";
            this.btn_load_frame.Size = new System.Drawing.Size(77, 20);
            this.btn_load_frame.TabIndex = 9;
            this.btn_load_frame.Text = "Load Frame";
            this.btn_load_frame.UseVisualStyleBackColor = true;
            this.btn_load_frame.Click += new System.EventHandler(this.btn_load_frame_Click);
            // 
            // num_disp_time
            // 
            this.num_disp_time.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_disp_time.Location = new System.Drawing.Point(162, 52);
            this.num_disp_time.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_disp_time.Name = "num_disp_time";
            this.num_disp_time.Size = new System.Drawing.Size(65, 20);
            this.num_disp_time.TabIndex = 8;
            this.num_disp_time.ValueChanged += new System.EventHandler(this.num_disp_time_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time frame (ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1135, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // sld_rec_time
            // 
            this.sld_rec_time.LargeChange = 10;
            this.sld_rec_time.Location = new System.Drawing.Point(505, 459);
            this.sld_rec_time.Maximum = 0;
            this.sld_rec_time.Name = "sld_rec_time";
            this.sld_rec_time.Size = new System.Drawing.Size(645, 45);
            this.sld_rec_time.TabIndex = 12;
            this.sld_rec_time.Scroll += new System.EventHandler(this.sld_rec_time_Scroll);
            // 
            // txt_max_length
            // 
            this.txt_max_length.AutoSize = true;
            this.txt_max_length.Location = new System.Drawing.Point(1092, 485);
            this.txt_max_length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_max_length.Name = "txt_max_length";
            this.txt_max_length.Size = new System.Drawing.Size(55, 13);
            this.txt_max_length.TabIndex = 13;
            this.txt_max_length.Text = "00:00:000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "00:00:000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cursor value : ";
            // 
            // txt_cursor_val
            // 
            this.txt_cursor_val.AutoSize = true;
            this.txt_cursor_val.Location = new System.Drawing.Point(586, 503);
            this.txt_cursor_val.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_cursor_val.Name = "txt_cursor_val";
            this.txt_cursor_val.Size = new System.Drawing.Size(55, 13);
            this.txt_cursor_val.TabIndex = 17;
            this.txt_cursor_val.Text = "00:00:000";
            // 
            // data_table
            // 
            this.data_table.AutoScroll = true;
            this.data_table.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.data_table.ColumnCount = 2;
            this.data_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.data_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.data_table.Controls.Add(this.txt_pr, 1, 4);
            this.data_table.Controls.Add(this.label25, 0, 4);
            this.data_table.Controls.Add(this.txt_pmi, 1, 3);
            this.data_table.Controls.Add(this.label23, 0, 3);
            this.data_table.Controls.Add(this.txt_peak_p, 1, 2);
            this.data_table.Controls.Add(this.label11, 0, 2);
            this.data_table.Controls.Add(this.txt_var, 1, 1);
            this.data_table.Controls.Add(this.label9, 0, 1);
            this.data_table.Controls.Add(this.txt_mean, 1, 0);
            this.data_table.Controls.Add(this.label7, 0, 0);
            this.data_table.Location = new System.Drawing.Point(838, 188);
            this.data_table.Margin = new System.Windows.Forms.Padding(2);
            this.data_table.Name = "data_table";
            this.data_table.RowCount = 5;
            this.data_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.data_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.data_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.data_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.data_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.data_table.Size = new System.Drawing.Size(234, 266);
            this.data_table.TabIndex = 18;
            // 
            // txt_pr
            // 
            this.txt_pr.AutoSize = true;
            this.txt_pr.Location = new System.Drawing.Point(119, 129);
            this.txt_pr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_pr.Name = "txt_pr";
            this.txt_pr.Size = new System.Drawing.Size(10, 13);
            this.txt_pr.TabIndex = 19;
            this.txt_pr.Text = " ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 129);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "Power Ratio";
            // 
            // txt_pmi
            // 
            this.txt_pmi.AutoSize = true;
            this.txt_pmi.Location = new System.Drawing.Point(119, 97);
            this.txt_pmi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_pmi.Name = "txt_pmi";
            this.txt_pmi.Size = new System.Drawing.Size(10, 13);
            this.txt_pmi.TabIndex = 17;
            this.txt_pmi.Text = " ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 97);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "PMI";
            // 
            // txt_peak_p
            // 
            this.txt_peak_p.AutoSize = true;
            this.txt_peak_p.Location = new System.Drawing.Point(119, 65);
            this.txt_peak_p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_peak_p.Name = "txt_peak_p";
            this.txt_peak_p.Size = new System.Drawing.Size(10, 13);
            this.txt_peak_p.TabIndex = 5;
            this.txt_peak_p.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Peak Preassure";
            // 
            // txt_var
            // 
            this.txt_var.AutoSize = true;
            this.txt_var.Location = new System.Drawing.Point(119, 33);
            this.txt_var.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_var.Name = "txt_var";
            this.txt_var.Size = new System.Drawing.Size(10, 13);
            this.txt_var.TabIndex = 3;
            this.txt_var.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Standard Deviation";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_mean
            // 
            this.txt_mean.AllowDrop = true;
            this.txt_mean.AutoSize = true;
            this.txt_mean.Location = new System.Drawing.Point(119, 1);
            this.txt_mean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_mean.Name = "txt_mean";
            this.txt_mean.Size = new System.Drawing.Size(10, 13);
            this.txt_mean.TabIndex = 1;
            this.txt_mean.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mean";
            // 
            // tmr_refresh_text
            // 
            this.tmr_refresh_text.Enabled = true;
            this.tmr_refresh_text.Tick += new System.EventHandler(this.tmr_refresh_text_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Frame :";
            // 
            // txt_frame_count
            // 
            this.txt_frame_count.AutoSize = true;
            this.txt_frame_count.Location = new System.Drawing.Point(586, 521);
            this.txt_frame_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_frame_count.Name = "txt_frame_count";
            this.txt_frame_count.Size = new System.Drawing.Size(24, 13);
            this.txt_frame_count.TabIndex = 20;
            this.txt_frame_count.Text = "0/0";
            // 
            // drawing_pannel
            // 
            this.drawing_pannel.BackColor = System.Drawing.SystemColors.Window;
            this.drawing_pannel.Controls.Add(this.txt_hf_rec_msg);
            this.drawing_pannel.Location = new System.Drawing.Point(0, 60);
            this.drawing_pannel.Margin = new System.Windows.Forms.Padding(2);
            this.drawing_pannel.Name = "drawing_pannel";
            this.drawing_pannel.Size = new System.Drawing.Size(500, 520);
            this.drawing_pannel.TabIndex = 21;
            this.drawing_pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_pannel_Paint);
            // 
            // txt_hf_rec_msg
            // 
            this.txt_hf_rec_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hf_rec_msg.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_hf_rec_msg.Location = new System.Drawing.Point(94, 182);
            this.txt_hf_rec_msg.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hf_rec_msg.Multiline = true;
            this.txt_hf_rec_msg.Name = "txt_hf_rec_msg";
            this.txt_hf_rec_msg.Size = new System.Drawing.Size(310, 43);
            this.txt_hf_rec_msg.TabIndex = 0;
            this.txt_hf_rec_msg.Text = "High Recording Frequency: \r\nDisplay disabled for better recording results. ";
            this.txt_hf_rec_msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hf_rec_msg.Visible = false;
            // 
            // bar_rec_data_calc
            // 
            this.bar_rec_data_calc.Location = new System.Drawing.Point(609, 540);
            this.bar_rec_data_calc.Margin = new System.Windows.Forms.Padding(2);
            this.bar_rec_data_calc.Name = "bar_rec_data_calc";
            this.bar_rec_data_calc.Size = new System.Drawing.Size(547, 21);
            this.bar_rec_data_calc.TabIndex = 23;
            this.bar_rec_data_calc.Visible = false;
            // 
            // txt_calc_rec_data
            // 
            this.txt_calc_rec_data.AutoSize = true;
            this.txt_calc_rec_data.BackColor = System.Drawing.Color.Transparent;
            this.txt_calc_rec_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calc_rec_data.Location = new System.Drawing.Point(752, 544);
            this.txt_calc_rec_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_calc_rec_data.Name = "txt_calc_rec_data";
            this.txt_calc_rec_data.Size = new System.Drawing.Size(156, 13);
            this.txt_calc_rec_data.TabIndex = 24;
            this.txt_calc_rec_data.Text = "Calculating recording data";
            this.txt_calc_rec_data.Visible = false;
            this.txt_calc_rec_data.Click += new System.EventHandler(this.txt_calc_rec_data_Click);
            // 
            // wrk_rec_data_calc
            // 
            this.wrk_rec_data_calc.WorkerReportsProgress = true;
            this.wrk_rec_data_calc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrk_rec_data_calc_DoWork);
            this.wrk_rec_data_calc.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.wrk_rec_data_calc_ProgressChanged);
            this.wrk_rec_data_calc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wrk_rec_data_calc_RunWorkerCompleted);
            // 
            // worker_read_bt
            // 
            this.worker_read_bt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_read_bt_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BoxPlot);
            this.tabControl1.Controls.Add(this.load_hist);
            this.tabControl1.Controls.Add(this.pr_hist);
            this.tabControl1.Location = new System.Drawing.Point(505, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 395);
            this.tabControl1.TabIndex = 25;
            // 
            // BoxPlot
            // 
            this.BoxPlot.Controls.Add(this.chrt_mean_var);
            this.BoxPlot.Location = new System.Drawing.Point(4, 22);
            this.BoxPlot.Margin = new System.Windows.Forms.Padding(2);
            this.BoxPlot.Name = "BoxPlot";
            this.BoxPlot.Padding = new System.Windows.Forms.Padding(2);
            this.BoxPlot.Size = new System.Drawing.Size(320, 369);
            this.BoxPlot.TabIndex = 0;
            this.BoxPlot.Text = "Box plot";
            this.BoxPlot.UseVisualStyleBackColor = true;
            // 
            // chrt_mean_var
            // 
            this.chrt_mean_var.BorderlineWidth = 3;
            this.chrt_mean_var.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chrt_mean_var.BorderSkin.BorderWidth = 3;
            chartArea10.Name = "ChartArea1";
            this.chrt_mean_var.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chrt_mean_var.Legends.Add(legend10);
            this.chrt_mean_var.Location = new System.Drawing.Point(0, 0);
            this.chrt_mean_var.Margin = new System.Windows.Forms.Padding(2);
            this.chrt_mean_var.Name = "chrt_mean_var";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series13.LabelBorderWidth = 3;
            series13.Legend = "Legend1";
            series13.MarkerBorderWidth = 3;
            series13.Name = "Mean and std";
            series13.YValuesPerPoint = 6;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series14.Legend = "Legend1";
            series14.Name = "values";
            this.chrt_mean_var.Series.Add(series13);
            this.chrt_mean_var.Series.Add(series14);
            this.chrt_mean_var.Size = new System.Drawing.Size(320, 370);
            this.chrt_mean_var.TabIndex = 0;
            this.chrt_mean_var.Text = "chart1";
            title13.Name = "Title1";
            title13.Text = "Region statistics";
            title14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title14.Name = "Title2";
            title14.Text = "peak_value : high wiskers, min_value : low wiskers, mean : middle bar, Standard D" +
    "eviation : Box limits";
            this.chrt_mean_var.Titles.Add(title13);
            this.chrt_mean_var.Titles.Add(title14);
            this.chrt_mean_var.Click += new System.EventHandler(this.chrt_mean_var_Click);
            // 
            // load_hist
            // 
            this.load_hist.Controls.Add(this.load_histogram);
            this.load_hist.Location = new System.Drawing.Point(4, 22);
            this.load_hist.Margin = new System.Windows.Forms.Padding(2);
            this.load_hist.Name = "load_hist";
            this.load_hist.Padding = new System.Windows.Forms.Padding(2);
            this.load_hist.Size = new System.Drawing.Size(320, 369);
            this.load_hist.TabIndex = 1;
            this.load_hist.Text = "Loads";
            this.load_hist.UseVisualStyleBackColor = true;
            // 
            // load_histogram
            // 
            chartArea11.Name = "ChartArea1";
            this.load_histogram.ChartAreas.Add(chartArea11);
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.load_histogram.Legends.Add(legend11);
            this.load_histogram.Location = new System.Drawing.Point(0, 0);
            this.load_histogram.Margin = new System.Windows.Forms.Padding(2);
            this.load_histogram.Name = "load_histogram";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.load_histogram.Series.Add(series15);
            this.load_histogram.Size = new System.Drawing.Size(320, 370);
            this.load_histogram.TabIndex = 0;
            this.load_histogram.Text = "chart2";
            title15.Name = "Title1";
            title15.Text = "Load per region";
            this.load_histogram.Titles.Add(title15);
            // 
            // pr_hist
            // 
            this.pr_hist.Controls.Add(this.pr_histogram);
            this.pr_hist.Location = new System.Drawing.Point(4, 22);
            this.pr_hist.Margin = new System.Windows.Forms.Padding(2);
            this.pr_hist.Name = "pr_hist";
            this.pr_hist.Padding = new System.Windows.Forms.Padding(2);
            this.pr_hist.Size = new System.Drawing.Size(320, 369);
            this.pr_hist.TabIndex = 2;
            this.pr_hist.Text = "power ratio";
            this.pr_hist.UseVisualStyleBackColor = true;
            // 
            // pr_histogram
            // 
            chartArea12.Name = "ChartArea1";
            this.pr_histogram.ChartAreas.Add(chartArea12);
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.pr_histogram.Legends.Add(legend12);
            this.pr_histogram.Location = new System.Drawing.Point(0, 0);
            this.pr_histogram.Margin = new System.Windows.Forms.Padding(2);
            this.pr_histogram.Name = "pr_histogram";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.pr_histogram.Series.Add(series16);
            this.pr_histogram.Size = new System.Drawing.Size(320, 370);
            this.pr_histogram.TabIndex = 0;
            this.pr_histogram.Text = "chart3";
            title16.Name = "Title1";
            title16.Text = "Power ratio per region";
            this.pr_histogram.Titles.Add(title16);
            // 
            // wrk_screen_update
            // 
            this.wrk_screen_update.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrk_screen_update_DoWork);
            this.wrk_screen_update.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wrk_screen_update_RunWorkerCompleted);
            // 
            // tmr_update_screen
            // 
            this.tmr_update_screen.Tick += new System.EventHandler(this.tmr_update_screen_Tick);
            // 
            // btn_calc_data
            // 
            this.btn_calc_data.Location = new System.Drawing.Point(1000, 503);
            this.btn_calc_data.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calc_data.Name = "btn_calc_data";
            this.btn_calc_data.Size = new System.Drawing.Size(65, 23);
            this.btn_calc_data.TabIndex = 26;
            this.btn_calc_data.Text = "Calculate data";
            this.btn_calc_data.UseVisualStyleBackColor = true;
            this.btn_calc_data.Click += new System.EventHandler(this.btn_calc_data_Click);
            // 
            // btn_clear_panel
            // 
            this.btn_clear_panel.Location = new System.Drawing.Point(504, 557);
            this.btn_clear_panel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear_panel.Name = "btn_clear_panel";
            this.btn_clear_panel.Size = new System.Drawing.Size(65, 23);
            this.btn_clear_panel.TabIndex = 27;
            this.btn_clear_panel.Text = "clear";
            this.btn_clear_panel.UseVisualStyleBackColor = true;
            this.btn_clear_panel.Click += new System.EventHandler(this.btn_clear_panel_Click);
            // 
            // btn_display_all
            // 
            this.btn_display_all.AutoSize = true;
            this.btn_display_all.Location = new System.Drawing.Point(720, 59);
            this.btn_display_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_display_all.Name = "btn_display_all";
            this.btn_display_all.Size = new System.Drawing.Size(112, 17);
            this.btn_display_all.TabIndex = 28;
            this.btn_display_all.Text = "Display all sensors";
            this.btn_display_all.UseVisualStyleBackColor = true;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 36);
            this.toolStripLabel5.Text = "100%";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 607);
            this.Controls.Add(this.btn_display_all);
            this.Controls.Add(this.btn_clear_panel);
            this.Controls.Add(this.btn_calc_data);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_calc_rec_data);
            this.Controls.Add(this.bar_rec_data_calc);
            this.Controls.Add(this.drawing_pannel);
            this.Controls.Add(this.txt_frame_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.txt_cursor_val);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_max_length);
            this.Controls.Add(this.sld_rec_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pressure Visualisation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rec_fr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_disp_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sld_rec_time)).EndInit();
            this.data_table.ResumeLayout(false);
            this.data_table.PerformLayout();
            this.drawing_pannel.ResumeLayout(false);
            this.drawing_pannel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.BoxPlot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_mean_var)).EndInit();
            this.load_hist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.load_histogram)).EndInit();
            this.pr_hist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pr_histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_start_stop;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_connection_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_load;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_saveas;
        private System.Windows.Forms.ToolStripLabel lbl_rec_status;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lbl_rec_len;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown num_rec_fr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btn_cont_read;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar sld_rec_time;
        private System.Windows.Forms.Button btn_load_frame;
        private System.Windows.Forms.NumericUpDown num_disp_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_max_length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_cursor_val;
        private System.Windows.Forms.TableLayoutPanel data_table;
        private System.Windows.Forms.Button Apply_rec_fr;
        private System.Windows.Forms.Timer tmr_refresh_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_frame_count;
        private System.Windows.Forms.Panel drawing_pannel;
        private System.Windows.Forms.ToolStripLabel txt_cont_read;
        private System.Windows.Forms.ProgressBar bar_rec_data_calc;
        private System.Windows.Forms.Label txt_calc_rec_data;
        private System.ComponentModel.BackgroundWorker wrk_rec_data_calc;
        private System.ComponentModel.BackgroundWorker worker_read_bt;
        private System.Windows.Forms.TextBox txt_hf_rec_msg;
        private System.Windows.Forms.Label txt_pr;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label txt_pmi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label txt_peak_p;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_var;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_mean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BoxPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_mean_var;
        private System.Windows.Forms.TabPage load_hist;
        private System.Windows.Forms.DataVisualization.Charting.Chart load_histogram;
        private System.Windows.Forms.TabPage pr_hist;
        private System.Windows.Forms.DataVisualization.Charting.Chart pr_histogram;
        private System.ComponentModel.BackgroundWorker wrk_screen_update;
        private System.Windows.Forms.Timer tmr_update_screen;
        private System.Windows.Forms.Button btn_calc_data;
        private System.Windows.Forms.Button btn_clear_panel;
        private System.Windows.Forms.CheckBox btn_display_all;
        private System.Windows.Forms.ToolStripMenuItem valvesSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}


namespace Semester_Project_Plantar_Pressure
{
    partial class Settings_form
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
            this.Bluetooth_grid = new System.Windows.Forms.DataGridView();
            this.btn_refresh_bt = new System.Windows.Forms.Button();
            this.btn_bt_select = new System.Windows.Forms.Button();
            this.txt_searching = new System.Windows.Forms.Label();
            this.txt_selected_device = new System.Windows.Forms.Label();
            this.wrk_scan_bluetooth = new System.ComponentModel.BackgroundWorker();
            this.pnl_settings_feet = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbx_Heel = new System.Windows.Forms.TextBox();
            this.txtbx_LF = new System.Windows.Forms.TextBox();
            this.txtbx_LM = new System.Windows.Forms.TextBox();
            this.txtbx_MF = new System.Windows.Forms.TextBox();
            this.txtbx_MM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reset_regions = new System.Windows.Forms.Button();
            this.btn_apply_areas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_foot_reg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bluetooth_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bluetooth_grid
            // 
            this.Bluetooth_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bluetooth_grid.Location = new System.Drawing.Point(16, 31);
            this.Bluetooth_grid.Margin = new System.Windows.Forms.Padding(4);
            this.Bluetooth_grid.MultiSelect = false;
            this.Bluetooth_grid.Name = "Bluetooth_grid";
            this.Bluetooth_grid.RowHeadersWidth = 82;
            this.Bluetooth_grid.RowTemplate.Height = 33;
            this.Bluetooth_grid.Size = new System.Drawing.Size(1444, 350);
            this.Bluetooth_grid.TabIndex = 0;
            // 
            // btn_refresh_bt
            // 
            this.btn_refresh_bt.Location = new System.Drawing.Point(26, 394);
            this.btn_refresh_bt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_bt.Name = "btn_refresh_bt";
            this.btn_refresh_bt.Size = new System.Drawing.Size(120, 52);
            this.btn_refresh_bt.TabIndex = 1;
            this.btn_refresh_bt.Text = "Refresh";
            this.btn_refresh_bt.UseVisualStyleBackColor = true;
            this.btn_refresh_bt.Click += new System.EventHandler(this.btn_refresh_bt_Click);
            // 
            // btn_bt_select
            // 
            this.btn_bt_select.Location = new System.Drawing.Point(164, 394);
            this.btn_bt_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bt_select.Name = "btn_bt_select";
            this.btn_bt_select.Size = new System.Drawing.Size(120, 52);
            this.btn_bt_select.TabIndex = 3;
            this.btn_bt_select.Text = "Select";
            this.btn_bt_select.UseVisualStyleBackColor = true;
            this.btn_bt_select.Click += new System.EventHandler(this.btn_bt_select_Click);
            // 
            // txt_searching
            // 
            this.txt_searching.AutoSize = true;
            this.txt_searching.Location = new System.Drawing.Point(20, 450);
            this.txt_searching.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_searching.Name = "txt_searching";
            this.txt_searching.Size = new System.Drawing.Size(18, 25);
            this.txt_searching.TabIndex = 4;
            this.txt_searching.Text = " ";
            // 
            // txt_selected_device
            // 
            this.txt_selected_device.AutoSize = true;
            this.txt_selected_device.Location = new System.Drawing.Point(292, 410);
            this.txt_selected_device.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_selected_device.Name = "txt_selected_device";
            this.txt_selected_device.Size = new System.Drawing.Size(150, 25);
            this.txt_selected_device.TabIndex = 5;
            this.txt_selected_device.Text = "No connection";
            // 
            // wrk_scan_bluetooth
            // 
            this.wrk_scan_bluetooth.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrk_scan_bluetooth_DoWork);
            this.wrk_scan_bluetooth.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wrk_scan_bluetooth_RunWorkerCompleted);
            // 
            // pnl_settings_feet
            // 
            this.pnl_settings_feet.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_settings_feet.Location = new System.Drawing.Point(16, 38);
            this.pnl_settings_feet.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_settings_feet.Name = "pnl_settings_feet";
            this.pnl_settings_feet.Size = new System.Drawing.Size(500, 500);
            this.pnl_settings_feet.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bluetooth_grid);
            this.groupBox1.Controls.Add(this.txt_searching);
            this.groupBox1.Controls.Add(this.txt_selected_device);
            this.groupBox1.Controls.Add(this.btn_refresh_bt);
            this.groupBox1.Controls.Add(this.btn_bt_select);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1488, 500);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bluetooth";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnl_settings_feet);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 517);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1488, 662);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_reset_regions);
            this.groupBox3.Controls.Add(this.btn_apply_areas);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtbx_foot_reg);
            this.groupBox3.Location = new System.Drawing.Point(540, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(922, 510);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foot regions";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbx_Heel);
            this.groupBox4.Controls.Add(this.txtbx_LF);
            this.groupBox4.Controls.Add(this.txtbx_LM);
            this.groupBox4.Controls.Add(this.txtbx_MF);
            this.groupBox4.Controls.Add(this.txtbx_MM);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(452, 46);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(448, 244);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PMI regions";
            // 
            // txtbx_Heel
            // 
            this.txtbx_Heel.Location = new System.Drawing.Point(208, 196);
            this.txtbx_Heel.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Heel.Name = "txtbx_Heel";
            this.txtbx_Heel.Size = new System.Drawing.Size(222, 31);
            this.txtbx_Heel.TabIndex = 23;
            this.txtbx_Heel.Text = "21,22,23";
            // 
            // txtbx_LF
            // 
            this.txtbx_LF.Location = new System.Drawing.Point(208, 160);
            this.txtbx_LF.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_LF.Name = "txtbx_LF";
            this.txtbx_LF.Size = new System.Drawing.Size(222, 31);
            this.txtbx_LF.TabIndex = 22;
            this.txtbx_LF.Text = "12,13,14,15";
            // 
            // txtbx_LM
            // 
            this.txtbx_LM.Location = new System.Drawing.Point(208, 121);
            this.txtbx_LM.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_LM.Name = "txtbx_LM";
            this.txtbx_LM.Size = new System.Drawing.Size(222, 31);
            this.txtbx_LM.TabIndex = 21;
            this.txtbx_LM.Text = "9,10,11";
            // 
            // txtbx_MF
            // 
            this.txtbx_MF.Location = new System.Drawing.Point(208, 85);
            this.txtbx_MF.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_MF.Name = "txtbx_MF";
            this.txtbx_MF.Size = new System.Drawing.Size(222, 31);
            this.txtbx_MF.TabIndex = 20;
            this.txtbx_MF.Text = "5,6,7,8";
            // 
            // txtbx_MM
            // 
            this.txtbx_MM.Location = new System.Drawing.Point(208, 46);
            this.txtbx_MM.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_MM.Name = "txtbx_MM";
            this.txtbx_MM.Size = new System.Drawing.Size(222, 31);
            this.txtbx_MM.TabIndex = 19;
            this.txtbx_MM.Text = "1,2,3,4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lateral Forefoot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lateral Midfoot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Heel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Medial Forefoot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Medial Midfoot";
            // 
            // btn_reset_regions
            // 
            this.btn_reset_regions.Location = new System.Drawing.Point(16, 442);
            this.btn_reset_regions.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset_regions.Name = "btn_reset_regions";
            this.btn_reset_regions.Size = new System.Drawing.Size(132, 48);
            this.btn_reset_regions.TabIndex = 11;
            this.btn_reset_regions.Text = "Reset";
            this.btn_reset_regions.UseMnemonic = false;
            this.btn_reset_regions.UseVisualStyleBackColor = true;
            this.btn_reset_regions.Click += new System.EventHandler(this.btn_reset_regions_Click);
            // 
            // btn_apply_areas
            // 
            this.btn_apply_areas.Location = new System.Drawing.Point(452, 312);
            this.btn_apply_areas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_apply_areas.Name = "btn_apply_areas";
            this.btn_apply_areas.Size = new System.Drawing.Size(448, 123);
            this.btn_apply_areas.TabIndex = 7;
            this.btn_apply_areas.Text = "Apply";
            this.btn_apply_areas.UseVisualStyleBackColor = true;
            this.btn_apply_areas.Click += new System.EventHandler(this.btn_apply_areas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type \"none\" for all sensors";
            // 
            // txtbx_foot_reg
            // 
            this.txtbx_foot_reg.AcceptsReturn = true;
            this.txtbx_foot_reg.Location = new System.Drawing.Point(16, 85);
            this.txtbx_foot_reg.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_foot_reg.Multiline = true;
            this.txtbx_foot_reg.Name = "txtbx_foot_reg";
            this.txtbx_foot_reg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbx_foot_reg.Size = new System.Drawing.Size(406, 352);
            this.txtbx_foot_reg.TabIndex = 8;
            this.txtbx_foot_reg.Text = "Forefoot:1,2,3,4,5,6,7,8,9,10 \r\nMiddlefoot:11,12,13,14,15,16,17,18,19,20\r\nRearfoo" +
    "t:21,22,23,24,25,26,27,28,29,30\r\n";
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 1067);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings_form";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bluetooth_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Bluetooth_grid;
        private System.Windows.Forms.Button btn_refresh_bt;
        private System.Windows.Forms.Button btn_bt_select;
        private System.Windows.Forms.Label txt_searching;
        private System.Windows.Forms.Label txt_selected_device;
        private System.ComponentModel.BackgroundWorker wrk_scan_bluetooth;
        private System.Windows.Forms.Panel pnl_settings_feet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_reset_regions;
        private System.Windows.Forms.Button btn_apply_areas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_foot_reg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_Heel;
        private System.Windows.Forms.TextBox txtbx_LF;
        private System.Windows.Forms.TextBox txtbx_LM;
        private System.Windows.Forms.TextBox txtbx_MF;
        private System.Windows.Forms.TextBox txtbx_MM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
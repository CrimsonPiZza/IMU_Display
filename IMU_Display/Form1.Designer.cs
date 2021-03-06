﻿namespace IMU_Display
{
    partial class MainForm
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
            this.MaterialListView = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.writeData_Btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.disconnect_Device4 = new System.Windows.Forms.Button();
            this.disconnect_Device3 = new System.Windows.Forms.Button();
            this.disconnect_Device2 = new System.Windows.Forms.Button();
            this.disconnect_Device1 = new System.Windows.Forms.Button();
            this.connect_Device4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.device_List4 = new System.Windows.Forms.ComboBox();
            this.connect_Device3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.connect_Device2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.device_List3 = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.device_List2 = new System.Windows.Forms.ComboBox();
            this.retrieve_Port = new MaterialSkin.Controls.MaterialFlatButton();
            this.connect_Device1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.device_List1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.measure_Rotation_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.device1_ShowGraph = new MaterialSkin.Controls.MaterialFlatButton();
            this.device1_RecieveData_ListView = new MaterialSkin.Controls.MaterialListView();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.device2_RecieveData_ListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.device3_RecieveData_ListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.device4_RecieveData_ListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Selector = new MaterialSkin.Controls.MaterialTabSelector();
            this.device1_DataSetter = new System.Windows.Forms.Timer(this.components);
            this.device2_DataSetter = new System.Windows.Forms.Timer(this.components);
            this.device3_DataSetter = new System.Windows.Forms.Timer(this.components);
            this.device4_DataSetter = new System.Windows.Forms.Timer(this.components);
            this.MaterialListView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialListView
            // 
            this.MaterialListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialListView.Controls.Add(this.tabPage1);
            this.MaterialListView.Controls.Add(this.tabPage2);
            this.MaterialListView.Controls.Add(this.tabPage3);
            this.MaterialListView.Controls.Add(this.tabPage4);
            this.MaterialListView.Controls.Add(this.tabPage5);
            this.MaterialListView.Depth = 0;
            this.MaterialListView.Location = new System.Drawing.Point(0, 106);
            this.MaterialListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialListView.Name = "MaterialListView";
            this.MaterialListView.SelectedIndex = 0;
            this.MaterialListView.Size = new System.Drawing.Size(583, 642);
            this.MaterialListView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.disconnect_Device4);
            this.tabPage1.Controls.Add(this.disconnect_Device3);
            this.tabPage1.Controls.Add(this.disconnect_Device2);
            this.tabPage1.Controls.Add(this.disconnect_Device1);
            this.tabPage1.Controls.Add(this.connect_Device4);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.device_List4);
            this.tabPage1.Controls.Add(this.connect_Device3);
            this.tabPage1.Controls.Add(this.connect_Device2);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.device_List3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.device_List2);
            this.tabPage1.Controls.Add(this.retrieve_Port);
            this.tabPage1.Controls.Add(this.connect_Device1);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.device_List1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.writeData_Btn);
            this.groupBox1.Location = new System.Drawing.Point(399, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Writing";
            // 
            // writeData_Btn
            // 
            this.writeData_Btn.AutoSize = true;
            this.writeData_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.writeData_Btn.Depth = 0;
            this.writeData_Btn.Icon = null;
            this.writeData_Btn.Location = new System.Drawing.Point(6, 19);
            this.writeData_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.writeData_Btn.Name = "writeData_Btn";
            this.writeData_Btn.Primary = true;
            this.writeData_Btn.Size = new System.Drawing.Size(160, 36);
            this.writeData_Btn.TabIndex = 0;
            this.writeData_Btn.Text = "Write Data To JSON";
            this.writeData_Btn.UseVisualStyleBackColor = true;
            this.writeData_Btn.Click += new System.EventHandler(this.writeData_Btn_Click);
            // 
            // disconnect_Device4
            // 
            this.disconnect_Device4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.disconnect_Device4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect_Device4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.disconnect_Device4.ForeColor = System.Drawing.Color.Snow;
            this.disconnect_Device4.Location = new System.Drawing.Point(357, 202);
            this.disconnect_Device4.Name = "disconnect_Device4";
            this.disconnect_Device4.Size = new System.Drawing.Size(171, 38);
            this.disconnect_Device4.TabIndex = 16;
            this.disconnect_Device4.Text = "DISCONNECTED DEVICE";
            this.disconnect_Device4.UseVisualStyleBackColor = false;
            this.disconnect_Device4.Visible = false;
            this.disconnect_Device4.Click += new System.EventHandler(this.disconnect_Device4_Click);
            // 
            // disconnect_Device3
            // 
            this.disconnect_Device3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.disconnect_Device3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect_Device3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.disconnect_Device3.ForeColor = System.Drawing.Color.Snow;
            this.disconnect_Device3.Location = new System.Drawing.Point(357, 159);
            this.disconnect_Device3.Name = "disconnect_Device3";
            this.disconnect_Device3.Size = new System.Drawing.Size(171, 38);
            this.disconnect_Device3.TabIndex = 15;
            this.disconnect_Device3.Text = "DISCONNECTED DEVICE";
            this.disconnect_Device3.UseVisualStyleBackColor = false;
            this.disconnect_Device3.Visible = false;
            this.disconnect_Device3.Click += new System.EventHandler(this.disconnect_Device3_Click);
            // 
            // disconnect_Device2
            // 
            this.disconnect_Device2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.disconnect_Device2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect_Device2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect_Device2.ForeColor = System.Drawing.Color.Snow;
            this.disconnect_Device2.Location = new System.Drawing.Point(357, 115);
            this.disconnect_Device2.Name = "disconnect_Device2";
            this.disconnect_Device2.Size = new System.Drawing.Size(171, 38);
            this.disconnect_Device2.TabIndex = 14;
            this.disconnect_Device2.Text = "DISCONNECTED DEVICE";
            this.disconnect_Device2.UseVisualStyleBackColor = false;
            this.disconnect_Device2.Visible = false;
            this.disconnect_Device2.Click += new System.EventHandler(this.disconnect_Device2_Click);
            // 
            // disconnect_Device1
            // 
            this.disconnect_Device1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.disconnect_Device1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnect_Device1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold);
            this.disconnect_Device1.ForeColor = System.Drawing.Color.Snow;
            this.disconnect_Device1.Location = new System.Drawing.Point(357, 72);
            this.disconnect_Device1.Name = "disconnect_Device1";
            this.disconnect_Device1.Size = new System.Drawing.Size(171, 38);
            this.disconnect_Device1.TabIndex = 13;
            this.disconnect_Device1.Text = "DISCONNECTED DEVICE";
            this.disconnect_Device1.UseVisualStyleBackColor = false;
            this.disconnect_Device1.Visible = false;
            this.disconnect_Device1.Click += new System.EventHandler(this.disconnect_Device1_Click);
            // 
            // connect_Device4
            // 
            this.connect_Device4.AutoSize = true;
            this.connect_Device4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect_Device4.Depth = 0;
            this.connect_Device4.Icon = null;
            this.connect_Device4.Location = new System.Drawing.Point(357, 202);
            this.connect_Device4.MouseState = MaterialSkin.MouseState.HOVER;
            this.connect_Device4.Name = "connect_Device4";
            this.connect_Device4.Primary = true;
            this.connect_Device4.Size = new System.Drawing.Size(134, 36);
            this.connect_Device4.TabIndex = 12;
            this.connect_Device4.Text = "Connect Device";
            this.connect_Device4.UseVisualStyleBackColor = true;
            this.connect_Device4.Click += new System.EventHandler(this.connect_Device4_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(88, 213);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(119, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Device #4 Port : ";
            // 
            // device_List4
            // 
            this.device_List4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_List4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.device_List4.FormattingEnabled = true;
            this.device_List4.Location = new System.Drawing.Point(213, 211);
            this.device_List4.Name = "device_List4";
            this.device_List4.Size = new System.Drawing.Size(138, 21);
            this.device_List4.TabIndex = 10;
            // 
            // connect_Device3
            // 
            this.connect_Device3.AutoSize = true;
            this.connect_Device3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect_Device3.Depth = 0;
            this.connect_Device3.Icon = null;
            this.connect_Device3.Location = new System.Drawing.Point(357, 160);
            this.connect_Device3.MouseState = MaterialSkin.MouseState.HOVER;
            this.connect_Device3.Name = "connect_Device3";
            this.connect_Device3.Primary = true;
            this.connect_Device3.Size = new System.Drawing.Size(134, 36);
            this.connect_Device3.TabIndex = 9;
            this.connect_Device3.Text = "Connect Device";
            this.connect_Device3.UseVisualStyleBackColor = true;
            this.connect_Device3.Click += new System.EventHandler(this.connect_Device3_Click);
            // 
            // connect_Device2
            // 
            this.connect_Device2.AutoSize = true;
            this.connect_Device2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect_Device2.Depth = 0;
            this.connect_Device2.Icon = null;
            this.connect_Device2.Location = new System.Drawing.Point(357, 116);
            this.connect_Device2.MouseState = MaterialSkin.MouseState.HOVER;
            this.connect_Device2.Name = "connect_Device2";
            this.connect_Device2.Primary = true;
            this.connect_Device2.Size = new System.Drawing.Size(134, 36);
            this.connect_Device2.TabIndex = 8;
            this.connect_Device2.Text = "Connect Device";
            this.connect_Device2.UseVisualStyleBackColor = true;
            this.connect_Device2.Click += new System.EventHandler(this.connect_Device2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(88, 171);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Device #3 Port : ";
            // 
            // device_List3
            // 
            this.device_List3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_List3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.device_List3.FormattingEnabled = true;
            this.device_List3.Location = new System.Drawing.Point(213, 169);
            this.device_List3.Name = "device_List3";
            this.device_List3.Size = new System.Drawing.Size(138, 21);
            this.device_List3.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(88, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Device #2 Port : ";
            // 
            // device_List2
            // 
            this.device_List2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_List2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.device_List2.FormattingEnabled = true;
            this.device_List2.Location = new System.Drawing.Point(213, 122);
            this.device_List2.Name = "device_List2";
            this.device_List2.Size = new System.Drawing.Size(138, 21);
            this.device_List2.TabIndex = 4;
            // 
            // retrieve_Port
            // 
            this.retrieve_Port.AutoSize = true;
            this.retrieve_Port.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.retrieve_Port.Depth = 0;
            this.retrieve_Port.ForeColor = System.Drawing.Color.DarkRed;
            this.retrieve_Port.Icon = null;
            this.retrieve_Port.Location = new System.Drawing.Point(172, 286);
            this.retrieve_Port.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.retrieve_Port.MouseState = MaterialSkin.MouseState.HOVER;
            this.retrieve_Port.Name = "retrieve_Port";
            this.retrieve_Port.Primary = false;
            this.retrieve_Port.Size = new System.Drawing.Size(204, 36);
            this.retrieve_Port.TabIndex = 3;
            this.retrieve_Port.Text = "Retrieve Connected Port";
            this.retrieve_Port.UseVisualStyleBackColor = true;
            this.retrieve_Port.Click += new System.EventHandler(this.retrieve_Port_Click);
            // 
            // connect_Device1
            // 
            this.connect_Device1.AutoSize = true;
            this.connect_Device1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connect_Device1.BackColor = System.Drawing.Color.Transparent;
            this.connect_Device1.Depth = 0;
            this.connect_Device1.Icon = null;
            this.connect_Device1.Location = new System.Drawing.Point(357, 72);
            this.connect_Device1.MouseState = MaterialSkin.MouseState.HOVER;
            this.connect_Device1.Name = "connect_Device1";
            this.connect_Device1.Primary = true;
            this.connect_Device1.Size = new System.Drawing.Size(134, 36);
            this.connect_Device1.TabIndex = 2;
            this.connect_Device1.Text = "Connect Device";
            this.connect_Device1.UseVisualStyleBackColor = false;
            this.connect_Device1.Click += new System.EventHandler(this.connect_Device1_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(88, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Device #1 Port : ";
            // 
            // device_List1
            // 
            this.device_List1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.device_List1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.device_List1.FormattingEnabled = true;
            this.device_List1.Location = new System.Drawing.Point(213, 78);
            this.device_List1.Name = "device_List1";
            this.device_List1.Size = new System.Drawing.Size(138, 21);
            this.device_List1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.measure_Rotation_btn);
            this.tabPage2.Controls.Add(this.device1_ShowGraph);
            this.tabPage2.Controls.Add(this.device1_RecieveData_ListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device #1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // measure_Rotation_btn
            // 
            this.measure_Rotation_btn.AutoSize = true;
            this.measure_Rotation_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.measure_Rotation_btn.Depth = 0;
            this.measure_Rotation_btn.Icon = null;
            this.measure_Rotation_btn.Location = new System.Drawing.Point(294, 574);
            this.measure_Rotation_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.measure_Rotation_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.measure_Rotation_btn.Name = "measure_Rotation_btn";
            this.measure_Rotation_btn.Primary = false;
            this.measure_Rotation_btn.Size = new System.Drawing.Size(154, 36);
            this.measure_Rotation_btn.TabIndex = 2;
            this.measure_Rotation_btn.Text = "Measure Rotation";
            this.measure_Rotation_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.measure_Rotation_btn.UseVisualStyleBackColor = true;
            this.measure_Rotation_btn.Click += new System.EventHandler(this.measure_Rotation_btn_Click);
            // 
            // device1_ShowGraph
            // 
            this.device1_ShowGraph.AutoSize = true;
            this.device1_ShowGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.device1_ShowGraph.Depth = 0;
            this.device1_ShowGraph.Icon = null;
            this.device1_ShowGraph.Location = new System.Drawing.Point(456, 574);
            this.device1_ShowGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.device1_ShowGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.device1_ShowGraph.Name = "device1_ShowGraph";
            this.device1_ShowGraph.Primary = false;
            this.device1_ShowGraph.Size = new System.Drawing.Size(110, 36);
            this.device1_ShowGraph.TabIndex = 1;
            this.device1_ShowGraph.Text = "Show Graph";
            this.device1_ShowGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.device1_ShowGraph.UseVisualStyleBackColor = true;
            this.device1_ShowGraph.Click += new System.EventHandler(this.device1_ShowGraph_Click);
            // 
            // device1_RecieveData_ListView
            // 
            this.device1_RecieveData_ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.device1_RecieveData_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.device1_RecieveData_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.device1_RecieveData_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.x,
            this.y,
            this.z});
            this.device1_RecieveData_ListView.Depth = 0;
            this.device1_RecieveData_ListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.device1_RecieveData_ListView.FullRowSelect = true;
            this.device1_RecieveData_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.device1_RecieveData_ListView.HideSelection = false;
            this.device1_RecieveData_ListView.HoverSelection = true;
            this.device1_RecieveData_ListView.Location = new System.Drawing.Point(8, 6);
            this.device1_RecieveData_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.device1_RecieveData_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.device1_RecieveData_ListView.Name = "device1_RecieveData_ListView";
            this.device1_RecieveData_ListView.OwnerDraw = true;
            this.device1_RecieveData_ListView.Size = new System.Drawing.Size(561, 559);
            this.device1_RecieveData_ListView.TabIndex = 0;
            this.device1_RecieveData_ListView.UseCompatibleStateImageBehavior = false;
            this.device1_RecieveData_ListView.View = System.Windows.Forms.View.Details;
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 185;
            // 
            // x
            // 
            this.x.Text = "x";
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x.Width = 127;
            // 
            // y
            // 
            this.y.Text = "y";
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y.Width = 127;
            // 
            // z
            // 
            this.z.Text = "z";
            this.z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.z.Width = 127;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialFlatButton2);
            this.tabPage3.Controls.Add(this.device2_RecieveData_ListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Device #2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(387, 574);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton2.TabIndex = 3;
            this.materialFlatButton2.Text = "materialFlatButton2";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // device2_RecieveData_ListView
            // 
            this.device2_RecieveData_ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.device2_RecieveData_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.device2_RecieveData_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.device2_RecieveData_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.device2_RecieveData_ListView.Depth = 0;
            this.device2_RecieveData_ListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.device2_RecieveData_ListView.FullRowSelect = true;
            this.device2_RecieveData_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.device2_RecieveData_ListView.HideSelection = false;
            this.device2_RecieveData_ListView.HoverSelection = true;
            this.device2_RecieveData_ListView.Location = new System.Drawing.Point(8, 6);
            this.device2_RecieveData_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.device2_RecieveData_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.device2_RecieveData_ListView.Name = "device2_RecieveData_ListView";
            this.device2_RecieveData_ListView.OwnerDraw = true;
            this.device2_RecieveData_ListView.Size = new System.Drawing.Size(561, 559);
            this.device2_RecieveData_ListView.TabIndex = 2;
            this.device2_RecieveData_ListView.UseCompatibleStateImageBehavior = false;
            this.device2_RecieveData_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item";
            this.columnHeader7.Width = 185;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "x";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "y";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 127;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "z";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 127;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialFlatButton3);
            this.tabPage4.Controls.Add(this.device3_RecieveData_ListView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(575, 616);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Device #3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(387, 574);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton3.TabIndex = 3;
            this.materialFlatButton3.Text = "materialFlatButton3";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // device3_RecieveData_ListView
            // 
            this.device3_RecieveData_ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.device3_RecieveData_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.device3_RecieveData_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.device3_RecieveData_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.device3_RecieveData_ListView.Depth = 0;
            this.device3_RecieveData_ListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.device3_RecieveData_ListView.FullRowSelect = true;
            this.device3_RecieveData_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.device3_RecieveData_ListView.HideSelection = false;
            this.device3_RecieveData_ListView.HoverSelection = true;
            this.device3_RecieveData_ListView.Location = new System.Drawing.Point(8, 6);
            this.device3_RecieveData_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.device3_RecieveData_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.device3_RecieveData_ListView.Name = "device3_RecieveData_ListView";
            this.device3_RecieveData_ListView.OwnerDraw = true;
            this.device3_RecieveData_ListView.Size = new System.Drawing.Size(561, 559);
            this.device3_RecieveData_ListView.TabIndex = 2;
            this.device3_RecieveData_ListView.UseCompatibleStateImageBehavior = false;
            this.device3_RecieveData_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Item";
            this.columnHeader14.Width = 185;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "x";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 127;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "y";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 127;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "z";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 127;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialFlatButton4);
            this.tabPage5.Controls.Add(this.device4_RecieveData_ListView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(575, 616);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Device #4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(387, 574);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(181, 36);
            this.materialFlatButton4.TabIndex = 3;
            this.materialFlatButton4.Text = "materialFlatButton4";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // device4_RecieveData_ListView
            // 
            this.device4_RecieveData_ListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.device4_RecieveData_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.device4_RecieveData_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.device4_RecieveData_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.device4_RecieveData_ListView.Depth = 0;
            this.device4_RecieveData_ListView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.device4_RecieveData_ListView.FullRowSelect = true;
            this.device4_RecieveData_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.device4_RecieveData_ListView.HideSelection = false;
            this.device4_RecieveData_ListView.HoverSelection = true;
            this.device4_RecieveData_ListView.Location = new System.Drawing.Point(8, 6);
            this.device4_RecieveData_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.device4_RecieveData_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.device4_RecieveData_ListView.Name = "device4_RecieveData_ListView";
            this.device4_RecieveData_ListView.OwnerDraw = true;
            this.device4_RecieveData_ListView.Size = new System.Drawing.Size(561, 559);
            this.device4_RecieveData_ListView.TabIndex = 2;
            this.device4_RecieveData_ListView.UseCompatibleStateImageBehavior = false;
            this.device4_RecieveData_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Item";
            this.columnHeader21.Width = 185;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "x";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 127;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "y";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 127;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "z";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 127;
            // 
            // tab_Selector
            // 
            this.tab_Selector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Selector.BaseTabControl = this.MaterialListView;
            this.tab_Selector.Depth = 0;
            this.tab_Selector.Location = new System.Drawing.Point(0, 60);
            this.tab_Selector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_Selector.Name = "tab_Selector";
            this.tab_Selector.Size = new System.Drawing.Size(583, 36);
            this.tab_Selector.TabIndex = 1;
            this.tab_Selector.Text = "materialTabSelector1";
            // 
            // device1_DataSetter
            // 
            this.device1_DataSetter.Enabled = true;
            this.device1_DataSetter.Interval = 1;
            this.device1_DataSetter.Tick += new System.EventHandler(this.device1_DataSetter_Tick);
            // 
            // device2_DataSetter
            // 
            this.device2_DataSetter.Enabled = true;
            this.device2_DataSetter.Tick += new System.EventHandler(this.device2_DataSetter_Tick);
            // 
            // device3_DataSetter
            // 
            this.device3_DataSetter.Enabled = true;
            this.device3_DataSetter.Tick += new System.EventHandler(this.device3_DataSetter_Tick);
            // 
            // device4_DataSetter
            // 
            this.device4_DataSetter.Enabled = true;
            this.device4_DataSetter.Tick += new System.EventHandler(this.device4_DataSetter_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 739);
            this.Controls.Add(this.tab_Selector);
            this.Controls.Add(this.MaterialListView);
            this.Name = "MainForm";
            this.Text = "IMU Display Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MaterialListView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MaterialListView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tab_Selector;
        private MaterialSkin.Controls.MaterialRaisedButton connect_Device1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox device_List1;
        private MaterialSkin.Controls.MaterialFlatButton retrieve_Port;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox device_List3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox device_List2;
        private MaterialSkin.Controls.MaterialRaisedButton connect_Device3;
        private MaterialSkin.Controls.MaterialRaisedButton connect_Device2;
        private System.Windows.Forms.Timer device1_DataSetter;
        private MaterialSkin.Controls.MaterialListView device1_RecieveData_ListView;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader y;
        private System.Windows.Forms.ColumnHeader z;
        private System.Windows.Forms.Timer device2_DataSetter;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialListView device2_RecieveData_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialListView device3_RecieveData_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialListView device4_RecieveData_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private MaterialSkin.Controls.MaterialRaisedButton connect_Device4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox device_List4;
        private System.Windows.Forms.Timer device3_DataSetter;
        private System.Windows.Forms.Timer device4_DataSetter;
        private System.Windows.Forms.Button disconnect_Device1;
        private System.Windows.Forms.Button disconnect_Device4;
        private System.Windows.Forms.Button disconnect_Device3;
        private System.Windows.Forms.Button disconnect_Device2;
        private MaterialSkin.Controls.MaterialFlatButton device1_ShowGraph;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton writeData_Btn;
        private MaterialSkin.Controls.MaterialFlatButton measure_Rotation_btn;
    }
}


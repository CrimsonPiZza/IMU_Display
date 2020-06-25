namespace IMU_Display
{
    partial class Rotation_Measuremnet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.av_Z = new System.Windows.Forms.TextBox();
            this.av_Y = new System.Windows.Forms.TextBox();
            this.av_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculated_Z = new System.Windows.Forms.TextBox();
            this.calculated_Y = new System.Windows.Forms.TextBox();
            this.calculated_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.save_Btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ac_Z = new System.Windows.Forms.TextBox();
            this.ac_Y = new System.Windows.Forms.TextBox();
            this.ac_X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.av_Z);
            this.groupBox1.Controls.Add(this.av_Y);
            this.groupBox1.Controls.Add(this.av_X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angular Velocity ( DPS )";
            // 
            // av_Z
            // 
            this.av_Z.Location = new System.Drawing.Point(24, 93);
            this.av_Z.Name = "av_Z";
            this.av_Z.Size = new System.Drawing.Size(102, 20);
            this.av_Z.TabIndex = 5;
            // 
            // av_Y
            // 
            this.av_Y.Location = new System.Drawing.Point(24, 62);
            this.av_Y.Name = "av_Y";
            this.av_Y.Size = new System.Drawing.Size(102, 20);
            this.av_Y.TabIndex = 4;
            // 
            // av_X
            // 
            this.av_X.Location = new System.Drawing.Point(24, 27);
            this.av_X.Name = "av_X";
            this.av_X.Size = new System.Drawing.Size(102, 20);
            this.av_X.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "z : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.calculated_Z);
            this.groupBox2.Controls.Add(this.calculated_Y);
            this.groupBox2.Controls.Add(this.calculated_X);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 130);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Angle";
            // 
            // calculated_Z
            // 
            this.calculated_Z.Location = new System.Drawing.Point(24, 93);
            this.calculated_Z.Name = "calculated_Z";
            this.calculated_Z.Size = new System.Drawing.Size(298, 20);
            this.calculated_Z.TabIndex = 5;
            // 
            // calculated_Y
            // 
            this.calculated_Y.Location = new System.Drawing.Point(24, 62);
            this.calculated_Y.Name = "calculated_Y";
            this.calculated_Y.Size = new System.Drawing.Size(298, 20);
            this.calculated_Y.TabIndex = 4;
            // 
            // calculated_X
            // 
            this.calculated_X.Location = new System.Drawing.Point(24, 27);
            this.calculated_X.Name = "calculated_X";
            this.calculated_X.Size = new System.Drawing.Size(298, 20);
            this.calculated_X.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "z : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "y :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x :";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(95, 230);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(182, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Reset Initial Rotation";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // save_Btn
            // 
            this.save_Btn.AutoSize = true;
            this.save_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_Btn.Depth = 0;
            this.save_Btn.Icon = null;
            this.save_Btn.Location = new System.Drawing.Point(132, 444);
            this.save_Btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save_Btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Primary = false;
            this.save_Btn.Size = new System.Drawing.Size(106, 36);
            this.save_Btn.TabIndex = 8;
            this.save_Btn.Text = "Save to CSV";
            this.save_Btn.UseVisualStyleBackColor = true;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ac_Z);
            this.groupBox3.Controls.Add(this.ac_Y);
            this.groupBox3.Controls.Add(this.ac_X);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(197, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acceleration ( m/s^2 )";
            // 
            // ac_Z
            // 
            this.ac_Z.Location = new System.Drawing.Point(24, 93);
            this.ac_Z.Name = "ac_Z";
            this.ac_Z.Size = new System.Drawing.Size(102, 20);
            this.ac_Z.TabIndex = 5;
            // 
            // ac_Y
            // 
            this.ac_Y.Location = new System.Drawing.Point(24, 62);
            this.ac_Y.Name = "ac_Y";
            this.ac_Y.Size = new System.Drawing.Size(102, 20);
            this.ac_Y.TabIndex = 4;
            // 
            // ac_X
            // 
            this.ac_X.Location = new System.Drawing.Point(24, 27);
            this.ac_X.Name = "ac_X";
            this.ac_X.Size = new System.Drawing.Size(102, 20);
            this.ac_X.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "z : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "y :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "x :";
            // 
            // Rotation_Measuremnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.save_Btn);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Rotation_Measuremnet";
            this.Text = "Rotation Measuremnet";
            this.Load += new System.EventHandler(this.Rotation_Measuremnet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox av_Z;
        private System.Windows.Forms.TextBox av_Y;
        private System.Windows.Forms.TextBox av_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox calculated_Z;
        private System.Windows.Forms.TextBox calculated_Y;
        private System.Windows.Forms.TextBox calculated_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Timer mainTimer;
        private MaterialSkin.Controls.MaterialFlatButton save_Btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ac_Z;
        private System.Windows.Forms.TextBox ac_Y;
        private System.Windows.Forms.TextBox ac_X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMU_Display
{
    public partial class Rotation_Measuremnet : MaterialForm
    {
        float x = 0;
        float y = 0;
        float z = 0;
        float dt = 0.001f;
        Boolean save_State = false;
        StringBuilder csv;
        DateTime startTime;

        public Rotation_Measuremnet()
        {
            InitializeComponent();
        }

        private void Rotation_Measuremnet_Load(object sender, EventArgs e)
        {
            // Initializing Color Scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);
            startTime = DateTime.Now;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {

            float ang_X = MainForm.imuData_Device1.gysx;
            float ang_Y = MainForm.imuData_Device1.gysy;
            float ang_Z = MainForm.imuData_Device1.gysz;

            float acc_X = MainForm.imuData_Device1.accx;
            float acc_Y = MainForm.imuData_Device1.accy;
            float acc_Z = MainForm.imuData_Device1.accz;

            av_X.Text = ang_X.ToString();
            av_Y.Text = ang_Y.ToString();
            av_Z.Text = ang_Z.ToString();

            ac_X.Text = acc_X.ToString();
            ac_Y.Text = acc_Y.ToString();
            ac_Z.Text = acc_Z.ToString();

            float dt = (float)(DateTime.Now - startTime).TotalSeconds;

            x += dt * ang_X;
            y += dt * ang_Y;
            z += dt * ang_Z;

            calculated_X.Text = x.ToString();
            calculated_Y.Text = y.ToString();
            calculated_Z.Text = z.ToString();

            startTime = DateTime.Now;

            if (save_State)
            {
                var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",dt,ang_X,ang_Y,ang_Z,acc_X,acc_Y,acc_Z,x,y,z);
                csv.AppendLine(newLine);
            }

        }

        public float abs_Interval(float a, float b)
        {
            return Math.Abs(a - b);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            z = 0;
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            save_State = !save_State;
            if (save_State)
            {
                save_Btn.Text = "Stop Saving";
                csv = new StringBuilder();
                var newLine = string.Format("DT,Velocity X,Velocity Y,Velocity Z,Acceleration X,Acceleration Y,Acceleration Z,Angle X,Angle Y,Angle Z");
                csv.AppendLine(newLine);
            }
            else
            {
                save_Btn.Text = "Save to CSV";
                File.WriteAllText("./data.csv", csv.ToString());
            }
        }
    }
}

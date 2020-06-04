using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace IMU_Display
{
    public partial class MainForm : MaterialForm
    {
        #region Declaration
        public static SensorsData sensorsData = new SensorsData();

        // Device Data
        public static IMUData imuData_Device1 = new IMUData();
        public static IMUData imuData_Device2 = new IMUData();
        public static IMUData imuData_Device3 = new IMUData();
        public static IMUData imuData_Device4 = new IMUData();

        public ZenClientHandle_t zenHandle = new ZenClientHandle_t();
        public static List<ZenSensorDesc> foundSensors = new List<ZenSensorDesc>();
        public static List<String> connectedDevice = new List<String>() {
            null,null,null,null
        };

        // Device1 - Sensor
        public ZenClientHandle_t device1_Handle;
        public ZenSensorHandle_t device1_Sensor;

        // Device1 - Sensor
        public ZenClientHandle_t device2_Handle;
        public ZenSensorHandle_t device2_Sensor;

        // Device1 - Sensor
        public ZenClientHandle_t device3_Handle;
        public ZenSensorHandle_t device3_Sensor;

        // Device1 - Sensor
        public ZenClientHandle_t device4_Handle;
        public ZenSensorHandle_t device4_Sensor;

        // Thread declaration
        public Thread device1_Thread;
        public Thread device2_Thread;
        public Thread device3_Thread;
        public Thread device4_Thread;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initializing Color Scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);

            // Seed List View
            seedListView();
        }

        private void retrieve_Port_Click(object sender, EventArgs e)
        {
            foundSensors.Clear();
            device_List1.Items.Clear();
            device_List2.Items.Clear();
            device_List3.Items.Clear();
            device_List4.Items.Clear();

            OpenZen.ZenInit(zenHandle);

            ZenEvent zenEvent = new ZenEvent();
            Boolean searchDone = false;

            // start sensor listing, new sensors will be reported as Events in our event thread
            OpenZen.ZenListSensorsAsync(zenHandle);

            // Searching for device
            while (searchDone == false)
            {
                if (OpenZen.ZenWaitForNextEvent(zenHandle, zenEvent) && zenEvent.component.handle == 0)
                {
                    // Handle Event
                    switch (zenEvent.eventType)
                    {
                        case (int)ZenSensorEvent.ZenSensorEvent_SensorFound:
                            //MessageBox.Show("Device : " + zenEvent.data.sensorFound.name);
                            ZenSensorDesc sensor = new ZenSensorDesc();
                            sensor.identifier = zenEvent.data.sensorFound.identifier;
                            sensor.baudRate = zenEvent.data.sensorFound.baudRate;
                            sensor.ioType = zenEvent.data.sensorFound.ioType;
                            sensor.name = zenEvent.data.sensorFound.name;
                            sensor.serialNumber = zenEvent.data.sensorFound.serialNumber;
                            foundSensors.Add(sensor);
                            break;
                        case (int)ZenSensorEvent.ZenSensorEvent_SensorListingProgress:
                            if (zenEvent.data.sensorListingProgress.progress == 1.0)
                            {
                                searchDone = true;
                            }
                            break;
                    }
                }
            }

            // Listing Connected Device
            if (foundSensors.Count > 0)
            {
                for (int i = 0; i < foundSensors.Count; i++)
                {
                    device_List1.Items.Add(foundSensors[i].name);
                    device_List2.Items.Add(foundSensors[i].name);
                    device_List3.Items.Add(foundSensors[i].name);
                    device_List4.Items.Add(foundSensors[i].name);
                }
                device_List1.SelectedIndex = 0;
                device_List2.SelectedIndex = 0;
                device_List3.SelectedIndex = 0;
                device_List4.SelectedIndex = 0;
            }
            else{
                MessageBox.Show("No Sensor Device is found");
            }

        }

        public class ExThread
        {
            ZenClientHandle_t device_Handle;
            ZenSensorHandle_t device_Sensor;

            public ZenSensorDesc mSensor;
            public int device_No;
            public uint count = 0;
            public ExThread(ZenSensorDesc sensor, int device_No, ZenClientHandle_t device_Handle, ZenSensorHandle_t device_Sensor)
            {
                this.mSensor = sensor;
                this.device_No = device_No;
                this.device_Handle = device_Handle;
                this.device_Sensor = device_Sensor;
            }

            // Non-static method 
            public void sensorEventThread()
            {
                try
                {
                    OpenZen.ZenInit(device_Handle);
                    ZenEvent zenEvent = new ZenEvent();
                    Boolean connected = false;

                    ZenSensorInitError sensorInitError = ZenSensorInitError.ZenSensorInitError_Max;
                    // try three connection attempts
                    for (int i = 0; i < 1; i++)
                    {

                        sensorInitError = OpenZen.ZenObtainSensor(device_Handle, mSensor, device_Sensor);

                        if (sensorInitError == ZenSensorInitError.ZenSensorInitError_None)
                        {
                            connected = true;
                            // Enable Disconnect Button
                            MainForm mainForm = FormProvider.getMain();
                            switch (device_No)
                            {
                                case 1:
                                    if (mainForm.InvokeRequired)
                                    {
                                        mainForm.BeginInvoke((Action) delegate () {
                                            mainForm.device_List1.Enabled = false;
                                            mainForm.disconnect_Device1.Visible = true;
                                            mainForm.connect_Device1.Enabled = false;
                                        });
                                    }
                                    else
                                    {
                                        mainForm.device_List1.Enabled = false;
                                        mainForm.disconnect_Device1.Visible = true;
                                        mainForm.connect_Device1.Enabled = false;
                                    }
                                    break;
                                case 2:
                                    if (mainForm.InvokeRequired)
                                    {
                                        mainForm.BeginInvoke((Action)delegate () {
                                            mainForm.device_List2.Enabled = false;
                                            mainForm.disconnect_Device2.Visible = true;
                                            mainForm.connect_Device2.Enabled = false;
                                        });
                                    }
                                    else
                                    {
                                        mainForm.device_List2.Enabled = false;
                                        mainForm.disconnect_Device2.Visible = true;
                                        mainForm.connect_Device2.Enabled = false;
                                    }
                                    break;
                                case 3:
                                    if (mainForm.InvokeRequired)
                                    {      
                                        mainForm.BeginInvoke((Action)delegate () {
                                            mainForm.device_List3.Enabled = false;
                                            mainForm.disconnect_Device3.Visible = true;
                                            mainForm.connect_Device3.Enabled = false;
                                        });
                                    }
                                    else
                                    {
                                        mainForm.device_List3.Enabled = false;
                                        mainForm.disconnect_Device3.Visible = true;
                                        mainForm.connect_Device3.Enabled = false;
                                    }
                                    break;
                                case 4:
                                    if (mainForm.InvokeRequired)
                                    {
                                        mainForm.BeginInvoke((Action)delegate () {
                                            mainForm.device_List4.Enabled = false;
                                            mainForm.disconnect_Device4.Visible = true;
                                            mainForm.connect_Device4.Enabled = false;
                                        });
                                    }
                                    else
                                    {
                                        mainForm.device_List4.Enabled = false;
                                        mainForm.disconnect_Device4.Visible = true;
                                        mainForm.connect_Device4.Enabled = false;
                                    }
                                    break;
                            }
                            MessageBox.Show("Succesfully connected to sensor for Device #"+device_No.ToString());
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }

                    while (connected)
                    {
                        //Console.WriteLine(mZenHandle);
                        if (OpenZen.ZenWaitForNextEvent(device_Handle, zenEvent))
                        {
                            if (zenEvent.component.handle != 0)
                            {
                                switch (zenEvent.eventType)
                                {
                                    case (int)ZenImuEvent.ZenImuEvent_Sample:
                                        count++;

                                        // read raw accelerometer
                                        OpenZenFloatArray raw_fa = OpenZenFloatArray.frompointer(zenEvent.data.imuData.aRaw);
                                        // read calibrated accelerometer
                                        OpenZenFloatArray fa = OpenZenFloatArray.frompointer(zenEvent.data.imuData.a);
                                        // read raw accelerometer
                                        OpenZenFloatArray raw_fg = OpenZenFloatArray.frompointer(zenEvent.data.imuData.gRaw);
                                        // read calibrated gyroscope
                                        OpenZenFloatArray fg = OpenZenFloatArray.frompointer(zenEvent.data.imuData.g);
                                        // read raw magnetometer
                                        OpenZenFloatArray raw_fb = OpenZenFloatArray.frompointer(zenEvent.data.imuData.bRaw);
                                        // read calibrated magnetometer
                                        OpenZenFloatArray fb = OpenZenFloatArray.frompointer(zenEvent.data.imuData.b);
                                        // read euler angle
                                        OpenZenFloatArray fr = OpenZenFloatArray.frompointer(zenEvent.data.imuData.r);
                                        // read quaternion
                                        OpenZenFloatArray fq = OpenZenFloatArray.frompointer(zenEvent.data.imuData.q);


                                        // Create new imuData object
                                        IMUData imuData = new IMUData(
                                            raw_fa.getitem(0), raw_fa.getitem(1), raw_fa.getitem(2),
                                            fa.getitem(0), fa.getitem(1), fa.getitem(2),
                                            raw_fg.getitem(0), raw_fg.getitem(1), raw_fg.getitem(2),
                                            fg.getitem(0), fg.getitem(1), fg.getitem(2),
                                            raw_fb.getitem(0), raw_fb.getitem(1), raw_fb.getitem(2),
                                            fb.getitem(0), fb.getitem(1), fb.getitem(2),
                                            fr.getitem(0), fr.getitem(1), fr.getitem(2),
                                            fq.getitem(0), fq.getitem(1), fq.getitem(2)
                                            ); // Push data in to the new imuData Object

                                        switch (device_No)
                                        {
                                            case (1):
                                                transferDevice1_Data(imuData);
                                                //Debug.WriteLine(count);
                                                break;
                                            case (2):
                                                transferDevice2_Data(imuData);
                                                break;
                                            case (3):
                                                transferDevice3_Data(imuData);
                                                break;
                                            case (4):
                                                transferDevice4_Data(imuData);
                                                Debug.WriteLine(count);
                                                break;
                                        }

                                        break;
                                }
                            }
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
            }
        }

        #region Device1
            private void connect_Device1_Click_1(object sender, EventArgs e)
            {
                device1_Handle = new ZenClientHandle_t();
                device1_Sensor = new ZenSensorHandle_t();

                connectedDevice[0] = foundSensors[device_List1.SelectedIndex].identifier;
                ExThread exThread = new ExThread(foundSensors[device_List1.SelectedIndex],1,device1_Handle,device1_Sensor); ;
                device1_Thread = new Thread(new ThreadStart(exThread.sensorEventThread));
                device1_Thread.Start();
            }

            public static void transferDevice1_Data(IMUData imuData)
            {
                MainForm.imuData_Device1.Copy(imuData);
            }

            private void device1_DataSetter_Tick(object sender, EventArgs e)
            {
               if (!imuData_Device1.isNotSet())
               {
                    // Accelerometer
                    device1_RecieveData_ListView.Items[0].SubItems[1].Text = imuData_Device1.accx.ToString();
                    device1_RecieveData_ListView.Items[0].SubItems[2].Text = imuData_Device1.accy.ToString();
                    device1_RecieveData_ListView.Items[0].SubItems[3].Text = imuData_Device1.accz.ToString();

                    // Raw Accelerometer
                    device1_RecieveData_ListView.Items[1].SubItems[1].Text = imuData_Device1.raw_accx.ToString();
                    device1_RecieveData_ListView.Items[1].SubItems[2].Text = imuData_Device1.raw_accy.ToString();
                    device1_RecieveData_ListView.Items[1].SubItems[3].Text = imuData_Device1.raw_accz.ToString();

                    // Gyroscope
                    device1_RecieveData_ListView.Items[2].SubItems[1].Text = imuData_Device1.gysx.ToString();
                    device1_RecieveData_ListView.Items[2].SubItems[2].Text = imuData_Device1.gysy.ToString();
                    device1_RecieveData_ListView.Items[2].SubItems[3].Text = imuData_Device1.gysz.ToString();

                    // Raw Gyroscope
                    device1_RecieveData_ListView.Items[3].SubItems[1].Text = imuData_Device1.raw_gysx.ToString();
                    device1_RecieveData_ListView.Items[3].SubItems[2].Text = imuData_Device1.raw_gysy.ToString();
                    device1_RecieveData_ListView.Items[3].SubItems[3].Text = imuData_Device1.raw_gysz.ToString();

                    // Magnetometer
                    device1_RecieveData_ListView.Items[4].SubItems[1].Text = imuData_Device1.mgtx.ToString();
                    device1_RecieveData_ListView.Items[4].SubItems[2].Text = imuData_Device1.mgty.ToString();
                    device1_RecieveData_ListView.Items[4].SubItems[3].Text = imuData_Device1.mgtz.ToString();

                    // Raw Gyroscope
                    device1_RecieveData_ListView.Items[5].SubItems[1].Text = imuData_Device1.raw_mgtx.ToString();
                    device1_RecieveData_ListView.Items[5].SubItems[2].Text = imuData_Device1.raw_mgty.ToString();
                    device1_RecieveData_ListView.Items[5].SubItems[3].Text = imuData_Device1.raw_mgtz.ToString();

                    // Read Margin Accelerometer
                    float[] mA = imuData_Device1.get_Margin_Accel();
                    device1_RecieveData_ListView.Items[7].SubItems[1].Text = mA[0].ToString();
                    device1_RecieveData_ListView.Items[7].SubItems[2].Text = mA[1].ToString();
                    device1_RecieveData_ListView.Items[7].SubItems[3].Text = mA[2].ToString();

                    // Read Margin Gyroscope
                    float[] mG = imuData_Device1.get_Margin_Gyro();
                    device1_RecieveData_ListView.Items[8].SubItems[1].Text = mG[0].ToString();
                    device1_RecieveData_ListView.Items[8].SubItems[2].Text = mG[1].ToString();
                    device1_RecieveData_ListView.Items[8].SubItems[3].Text = mG[2].ToString();

                    // Read Margin Magnetometer
                    float[] mM = imuData_Device1.get_Margin_Magneto();
                    device1_RecieveData_ListView.Items[9].SubItems[1].Text = mM[0].ToString();
                    device1_RecieveData_ListView.Items[9].SubItems[2].Text = mM[1].ToString();
                    device1_RecieveData_ListView.Items[9].SubItems[3].Text = mM[2].ToString();

                    // Euler Angle
                    device1_RecieveData_ListView.Items[10].SubItems[1].Text = imuData_Device1.eulerx.ToString();
                    device1_RecieveData_ListView.Items[10].SubItems[2].Text = imuData_Device1.eulery.ToString();
                    device1_RecieveData_ListView.Items[10].SubItems[3].Text = imuData_Device1.eulerz.ToString();

                    // Quaternion
                    device1_RecieveData_ListView.Items[11].SubItems[1].Text = imuData_Device1.quatx.ToString();
                    device1_RecieveData_ListView.Items[11].SubItems[2].Text = imuData_Device1.quaty.ToString();
                    device1_RecieveData_ListView.Items[11].SubItems[3].Text = imuData_Device1.quatz.ToString();
            }
            }

        #endregion

        #region Device2
            private void connect_Device2_Click(object sender, EventArgs e)
            {
                device2_Handle = new ZenClientHandle_t();
                device2_Sensor = new ZenSensorHandle_t();

                connectedDevice[1] = foundSensors[device_List2.SelectedIndex].identifier;
                ExThread exThread = new ExThread(foundSensors[device_List2.SelectedIndex],2,device2_Handle,device2_Sensor);
                device2_Thread = new Thread(new ThreadStart(exThread.sensorEventThread));
                device2_Thread.Start();
            }

            public static void transferDevice2_Data(IMUData imuData)
            {
                MainForm.imuData_Device2.Copy(imuData);
            }

            private void device2_DataSetter_Tick(object sender, EventArgs e)
        {
            if (!imuData_Device2.isNotSet())
            {
                // Accelerometer
                device2_RecieveData_ListView.Items[0].SubItems[1].Text = imuData_Device2.accx.ToString();
                device2_RecieveData_ListView.Items[0].SubItems[2].Text = imuData_Device2.accy.ToString();
                device2_RecieveData_ListView.Items[0].SubItems[3].Text = imuData_Device2.accz.ToString();

                // Raw Accelerometer
                device2_RecieveData_ListView.Items[1].SubItems[1].Text = imuData_Device2.raw_accx.ToString();
                device2_RecieveData_ListView.Items[1].SubItems[2].Text = imuData_Device2.raw_accy.ToString();
                device2_RecieveData_ListView.Items[1].SubItems[3].Text = imuData_Device2.raw_accz.ToString();

                // Gyroscope
                device2_RecieveData_ListView.Items[2].SubItems[1].Text = imuData_Device2.gysx.ToString();
                device2_RecieveData_ListView.Items[2].SubItems[2].Text = imuData_Device2.gysy.ToString();
                device2_RecieveData_ListView.Items[2].SubItems[3].Text = imuData_Device2.gysz.ToString();

                // Raw Gyroscope
                device2_RecieveData_ListView.Items[3].SubItems[1].Text = imuData_Device2.raw_gysx.ToString();
                device2_RecieveData_ListView.Items[3].SubItems[2].Text = imuData_Device2.raw_gysy.ToString();
                device2_RecieveData_ListView.Items[3].SubItems[3].Text = imuData_Device2.raw_gysz.ToString();

                // Magnetometer
                device2_RecieveData_ListView.Items[4].SubItems[1].Text = imuData_Device2.mgtx.ToString();
                device2_RecieveData_ListView.Items[4].SubItems[2].Text = imuData_Device2.mgty.ToString();
                device2_RecieveData_ListView.Items[4].SubItems[3].Text = imuData_Device2.mgtz.ToString();

                // Raw Gyroscope
                device2_RecieveData_ListView.Items[5].SubItems[1].Text = imuData_Device2.raw_mgtx.ToString();
                device2_RecieveData_ListView.Items[5].SubItems[2].Text = imuData_Device2.raw_mgty.ToString();
                device2_RecieveData_ListView.Items[5].SubItems[3].Text = imuData_Device2.raw_mgtz.ToString();

                // Read Margin Accelerometer
                float[] mA = imuData_Device2.get_Margin_Accel();
                device2_RecieveData_ListView.Items[7].SubItems[1].Text = mA[0].ToString();
                device2_RecieveData_ListView.Items[7].SubItems[2].Text = mA[1].ToString();
                device2_RecieveData_ListView.Items[7].SubItems[3].Text = mA[2].ToString();

                // Read Margin Gyroscope
                float[] mG = imuData_Device2.get_Margin_Gyro();
                device2_RecieveData_ListView.Items[8].SubItems[1].Text = mG[0].ToString();
                device2_RecieveData_ListView.Items[8].SubItems[2].Text = mG[1].ToString();
                device2_RecieveData_ListView.Items[8].SubItems[3].Text = mG[2].ToString();

                // Read Margin Magnetometer
                float[] mM = imuData_Device2.get_Margin_Magneto();
                device2_RecieveData_ListView.Items[9].SubItems[1].Text = mM[0].ToString();
                device2_RecieveData_ListView.Items[9].SubItems[2].Text = mM[1].ToString();
                device2_RecieveData_ListView.Items[9].SubItems[3].Text = mM[2].ToString();

                // Euler Angle
                device2_RecieveData_ListView.Items[10].SubItems[1].Text = imuData_Device2.eulerx.ToString();
                device2_RecieveData_ListView.Items[10].SubItems[2].Text = imuData_Device2.eulery.ToString();
                device2_RecieveData_ListView.Items[10].SubItems[3].Text = imuData_Device2.eulerz.ToString();

                // Quaternion
                device2_RecieveData_ListView.Items[11].SubItems[1].Text = imuData_Device2.quatx.ToString();
                device2_RecieveData_ListView.Items[11].SubItems[2].Text = imuData_Device2.quaty.ToString();
                device2_RecieveData_ListView.Items[11].SubItems[3].Text = imuData_Device2.quatz.ToString();
            }
        }

        #endregion

        #region Device3

            private void connect_Device3_Click(object sender, EventArgs e)
            {
                device3_Handle = new ZenClientHandle_t();
                device3_Sensor = new ZenSensorHandle_t();

                connectedDevice[2] = foundSensors[device_List3.SelectedIndex].identifier;
                ExThread exThread = new ExThread(foundSensors[device_List3.SelectedIndex], 3,device3_Handle, device3_Sensor);
                device3_Thread = new Thread(new ThreadStart(exThread.sensorEventThread));
                device3_Thread.Start();
            }

            public static void transferDevice3_Data(IMUData imuData)
            {
                MainForm.imuData_Device3.Copy(imuData);
            }

            private void device3_DataSetter_Tick(object sender, EventArgs e)
            {
                if (!imuData_Device3.isNotSet())
                {
                    // Accelerometer
                    device3_RecieveData_ListView.Items[0].SubItems[1].Text = imuData_Device3.accx.ToString();
                    device3_RecieveData_ListView.Items[0].SubItems[2].Text = imuData_Device3.accy.ToString();
                    device3_RecieveData_ListView.Items[0].SubItems[3].Text = imuData_Device3.accz.ToString();

                    // Raw Accelerometer
                    device3_RecieveData_ListView.Items[1].SubItems[1].Text = imuData_Device3.raw_accx.ToString();
                    device3_RecieveData_ListView.Items[1].SubItems[2].Text = imuData_Device3.raw_accy.ToString();
                    device3_RecieveData_ListView.Items[1].SubItems[3].Text = imuData_Device3.raw_accz.ToString();

                    // Gyroscope
                    device3_RecieveData_ListView.Items[2].SubItems[1].Text = imuData_Device3.gysx.ToString();
                    device3_RecieveData_ListView.Items[2].SubItems[2].Text = imuData_Device3.gysy.ToString();
                    device3_RecieveData_ListView.Items[2].SubItems[3].Text = imuData_Device3.gysz.ToString();

                    // Raw Gyroscope
                    device3_RecieveData_ListView.Items[3].SubItems[1].Text = imuData_Device3.raw_gysx.ToString();
                    device3_RecieveData_ListView.Items[3].SubItems[2].Text = imuData_Device3.raw_gysy.ToString();
                    device3_RecieveData_ListView.Items[3].SubItems[3].Text = imuData_Device3.raw_gysz.ToString();

                    // Magnetometer
                    device3_RecieveData_ListView.Items[4].SubItems[1].Text = imuData_Device3.mgtx.ToString();
                    device3_RecieveData_ListView.Items[4].SubItems[2].Text = imuData_Device3.mgty.ToString();
                    device3_RecieveData_ListView.Items[4].SubItems[3].Text = imuData_Device3.mgtz.ToString();

                    // Raw Gyroscope
                    device3_RecieveData_ListView.Items[5].SubItems[1].Text = imuData_Device3.raw_mgtx.ToString();
                    device3_RecieveData_ListView.Items[5].SubItems[2].Text = imuData_Device3.raw_mgty.ToString();
                    device3_RecieveData_ListView.Items[5].SubItems[3].Text = imuData_Device3.raw_mgtz.ToString();

                    // Read Margin Accelerometer
                    float[] mA = imuData_Device3.get_Margin_Accel();
                    device3_RecieveData_ListView.Items[7].SubItems[1].Text = mA[0].ToString();
                    device3_RecieveData_ListView.Items[7].SubItems[2].Text = mA[1].ToString();
                    device3_RecieveData_ListView.Items[7].SubItems[3].Text = mA[2].ToString();

                    // Read Margin Gyroscope
                    float[] mG = imuData_Device3.get_Margin_Gyro();
                    device3_RecieveData_ListView.Items[8].SubItems[1].Text = mG[0].ToString();
                    device3_RecieveData_ListView.Items[8].SubItems[2].Text = mG[1].ToString();
                    device3_RecieveData_ListView.Items[8].SubItems[3].Text = mG[2].ToString();

                    // Read Margin Magnetometer
                    float[] mM = imuData_Device3.get_Margin_Magneto();
                    device3_RecieveData_ListView.Items[9].SubItems[1].Text = mM[0].ToString();
                    device3_RecieveData_ListView.Items[9].SubItems[2].Text = mM[1].ToString();
                    device3_RecieveData_ListView.Items[9].SubItems[3].Text = mM[2].ToString();

                    // Euler Angle
                    device3_RecieveData_ListView.Items[10].SubItems[1].Text = imuData_Device3.eulerx.ToString();
                    device3_RecieveData_ListView.Items[10].SubItems[2].Text = imuData_Device3.eulery.ToString();
                    device3_RecieveData_ListView.Items[10].SubItems[3].Text = imuData_Device3.eulerz.ToString();

                    // Quaternion
                    device3_RecieveData_ListView.Items[11].SubItems[1].Text = imuData_Device3.quatx.ToString();
                    device3_RecieveData_ListView.Items[11].SubItems[2].Text = imuData_Device3.quaty.ToString();
                    device3_RecieveData_ListView.Items[11].SubItems[3].Text = imuData_Device3.quatz.ToString();
                }
            }

        #endregion

        #region Device4

            private void connect_Device4_Click(object sender, EventArgs e)
            {
                device4_Handle = new ZenClientHandle_t();
                device4_Sensor = new ZenSensorHandle_t();

                connectedDevice[3] = foundSensors[device_List4.SelectedIndex].identifier;
                ExThread exThread = new ExThread(foundSensors[device_List4.SelectedIndex], 4, device4_Handle, device4_Sensor);
                device4_Thread = new Thread(new ThreadStart(exThread.sensorEventThread));
                device4_Thread.Start();
            }

            public static void transferDevice4_Data(IMUData imuData)
            {
                MainForm.imuData_Device4.Copy(imuData);
            }

            private void device4_DataSetter_Tick(object sender, EventArgs e)
            {
                if (!imuData_Device4.isNotSet())
                {
                    // Accelerometer
                    device4_RecieveData_ListView.Items[0].SubItems[1].Text = imuData_Device4.accx.ToString();
                    device4_RecieveData_ListView.Items[0].SubItems[2].Text = imuData_Device4.accy.ToString();
                    device4_RecieveData_ListView.Items[0].SubItems[3].Text = imuData_Device4.accz.ToString();

                    // Raw Accelerometer
                    device4_RecieveData_ListView.Items[1].SubItems[1].Text = imuData_Device4.raw_accx.ToString();
                    device4_RecieveData_ListView.Items[1].SubItems[2].Text = imuData_Device4.raw_accy.ToString();
                    device4_RecieveData_ListView.Items[1].SubItems[3].Text = imuData_Device4.raw_accz.ToString();

                    // Gyroscope
                    device4_RecieveData_ListView.Items[2].SubItems[1].Text = imuData_Device4.gysx.ToString();
                    device4_RecieveData_ListView.Items[2].SubItems[2].Text = imuData_Device4.gysy.ToString();
                    device4_RecieveData_ListView.Items[2].SubItems[3].Text = imuData_Device4.gysz.ToString();

                    // Raw Gyroscope
                    device4_RecieveData_ListView.Items[3].SubItems[1].Text = imuData_Device4.raw_gysx.ToString();
                    device4_RecieveData_ListView.Items[3].SubItems[2].Text = imuData_Device4.raw_gysy.ToString();
                    device4_RecieveData_ListView.Items[3].SubItems[3].Text = imuData_Device4.raw_gysz.ToString();

                    // Magnetometer
                    device4_RecieveData_ListView.Items[4].SubItems[1].Text = imuData_Device4.mgtx.ToString();
                    device4_RecieveData_ListView.Items[4].SubItems[2].Text = imuData_Device4.mgty.ToString();
                    device4_RecieveData_ListView.Items[4].SubItems[3].Text = imuData_Device4.mgtz.ToString();

                    // Raw Gyroscope
                    device4_RecieveData_ListView.Items[5].SubItems[1].Text = imuData_Device4.raw_mgtx.ToString();
                    device4_RecieveData_ListView.Items[5].SubItems[2].Text = imuData_Device4.raw_mgty.ToString();
                    device4_RecieveData_ListView.Items[5].SubItems[3].Text = imuData_Device4.raw_mgtz.ToString();

                    // Read Margin Accelerometer
                    float[] mA = imuData_Device4.get_Margin_Accel();
                    device4_RecieveData_ListView.Items[7].SubItems[1].Text = mA[0].ToString();
                    device4_RecieveData_ListView.Items[7].SubItems[2].Text = mA[1].ToString();
                    device4_RecieveData_ListView.Items[7].SubItems[3].Text = mA[2].ToString();

                    // Read Margin Gyroscope
                    float[] mG = imuData_Device4.get_Margin_Gyro();
                    device4_RecieveData_ListView.Items[8].SubItems[1].Text = mG[0].ToString();
                    device4_RecieveData_ListView.Items[8].SubItems[2].Text = mG[1].ToString();
                    device4_RecieveData_ListView.Items[8].SubItems[3].Text = mG[2].ToString();

                    // Read Margin Magnetometer
                    float[] mM = imuData_Device4.get_Margin_Magneto();
                    device4_RecieveData_ListView.Items[9].SubItems[1].Text = mM[0].ToString();
                    device4_RecieveData_ListView.Items[9].SubItems[2].Text = mM[1].ToString();
                    device4_RecieveData_ListView.Items[9].SubItems[3].Text = mM[2].ToString();

                    // Euler Angle
                    device4_RecieveData_ListView.Items[10].SubItems[1].Text = imuData_Device4.eulerx.ToString();
                    device4_RecieveData_ListView.Items[10].SubItems[2].Text = imuData_Device4.eulery.ToString();
                    device4_RecieveData_ListView.Items[10].SubItems[3].Text = imuData_Device4.eulerz.ToString();

                    // Quaternion
                    device4_RecieveData_ListView.Items[11].SubItems[1].Text = imuData_Device4.quatx.ToString();
                    device4_RecieveData_ListView.Items[11].SubItems[2].Text = imuData_Device4.quaty.ToString();
                    device4_RecieveData_ListView.Items[11].SubItems[3].Text = imuData_Device4.quatz.ToString();
                }
            }

        #endregion

        private void seedListView()
        {
            // Define
            var data = new[]
            {
                new []{"Calibrated Accelerometer", "0", "0","0"},
                new []{"Raw Accelerometer", "0", "0","0"},
                new []{"Calibrated Gyroscope", "0", "0", "0"},
                new []{"Raw Gyroscope", "0", "0","0"},
                new []{"Calibrated Magnetometer", "0", "0", "0"},
                new []{"Raw Magnetometer", "0", "0","0"},
                new []{"", "", "",""},
                new []{"Margin Accelerometer", "0", "0","0"},
                new []{"Margin Gyroscope", "0", "0","0"},
                new []{"Margin Magnetometer", "0", "0","0"},
                new []{"Euler Angle", "0", "0","0"},
                new []{"Quaternion", "0", "0","0"},
            };

            // Add Recieve Data
            foreach (string[] version in data)
            {
                ListViewItem item1 = new ListViewItem(version), 
                    item2 = (ListViewItem) item1.Clone(), 
                    item3 = (ListViewItem) item1.Clone(), 
                    item4 = (ListViewItem) item1.Clone();
                device1_RecieveData_ListView.Items.Add(item1);
                device2_RecieveData_ListView.Items.Add(item2);
                device3_RecieveData_ListView.Items.Add(item3);
                device4_RecieveData_ListView.Items.Add(item4);
            }

        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Closing All Thread
            abort_Thread(1);
            abort_Thread(2);
            abort_Thread(3);
            abort_Thread(4);
        }

        #region ThreadClosing
        public void abort_Thread(int no)
        {
            if(connectedDevice[no-1] != null)
            {
                switch (no) {
                    case 1:
                        device1_Thread.Abort();
                        break;
                    case 2:
                        device2_Thread.Abort();
                        break;
                    case 3:
                        device3_Thread.Abort();
                        break;
                    case 4:
                        device4_Thread.Abort();
                        break;
                }
            }
            connectedDevice[no - 1] = null;
        }   

        private void disconnect_Device1_Click(object sender, EventArgs e)
        {
            try
            {
                abort_Thread(1);
                disconnect_Device1.Visible = false;
                connect_Device1.Enabled = true;
                device_List1.Enabled = true;

                OpenZen.ZenReleaseSensor(device1_Handle, device1_Sensor);
               
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        private void disconnect_Device2_Click(object sender, EventArgs e)
        {
            try
            {
                abort_Thread(2);
                disconnect_Device2.Visible = false;
                connect_Device2.Enabled = true;
                device_List2.Enabled = true;

                OpenZen.ZenReleaseSensor(device2_Handle, device2_Sensor);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        private void disconnect_Device3_Click(object sender, EventArgs e)
        {
            try
            {
                abort_Thread(3);
                disconnect_Device3.Visible = false;
                connect_Device3.Enabled = true;
                device_List3.Enabled = true;

                OpenZen.ZenReleaseSensor(device3_Handle, device3_Sensor);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        private void disconnect_Device4_Click(object sender, EventArgs e)
        {
            try
            {
                abort_Thread(4);
                disconnect_Device4.Visible = false;
                connect_Device4.Enabled = true;
                device_List4.Enabled = true;

                OpenZen.ZenReleaseSensor(device4_Handle, device4_Sensor);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        #endregion

        private void device1_ShowGraph_Click(object sender, EventArgs e)
        {
            new Graph_Plotting("Device #1 ").Show();
        }

        private void writeData_Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog();
            save.Filter = "JSON |*.json";
            save.FileName = "SampleIMUData";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String path = save.FileName;
                sensorsData.addAllData(imuData_Device1, imuData_Device2, imuData_Device3, imuData_Device4);
                string json = new JavaScriptSerializer().Serialize(sensorsData);

                File.WriteAllText(path, json);
            }
        }
    }
}

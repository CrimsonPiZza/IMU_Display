using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Display
{
    public class SensorsData
    {
        public SampleIMUData imu0;
        public SampleIMUData imu1;
        public SampleIMUData imu2;
        public SampleIMUData imu3;


        public void addAllData(IMUData imu0, IMUData imu1, IMUData imu2, IMUData imu3)
        {
            this.imu0 = new SampleIMUData(imu0);
            this.imu1 = new SampleIMUData(imu1);
            this.imu2 = new SampleIMUData(imu2);
            this.imu3 = new SampleIMUData(imu3);
        }

        public SensorsData(IMUData imu0, IMUData imu1, IMUData imu2, IMUData imu3)
        {
            this.imu0 = new SampleIMUData(imu0);
            this.imu1 = new SampleIMUData(imu1);
            this.imu2 = new SampleIMUData(imu2);
            this.imu3 = new SampleIMUData(imu3);
        }

        public SensorsData() { }
    }
}

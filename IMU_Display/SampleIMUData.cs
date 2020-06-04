using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Display
{
    public class SampleIMUData
    {
        public float accx;
        public float accy;
        public float accz;
        public float gysx;
        public float gysy;
        public float gysz;
        public float mgtx;
        public float mgty;
        public float mgtz;
        public float roll;
        public float pitch;
        public float yaw;

        public SampleIMUData(IMUData imudata)
        {
            this.accx = imudata.accx;
            this.accy = imudata.accy;
            this.accz = imudata.accz;


            this.gysx = imudata.gysx;
            this.gysy = imudata.gysy;
            this.gysz = imudata.gysz;

            this.mgtx = imudata.mgtx;
            this.mgty = imudata.mgty;
            this.mgtz = imudata.mgtz;

            this.roll = imudata.eulerx;
            this.pitch = imudata.eulery;
            this.yaw = imudata.eulerz;
        }
    }
}

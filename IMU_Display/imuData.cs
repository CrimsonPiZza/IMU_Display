using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Display
{
    public class IMUData
    {
        private Boolean isNull = true;
        public float accx;
        public float accy;
        public float accz;
        public float gysx;
        public float gysy;
        public float gysz;
        public float mgtx;
        public float mgty;
        public float mgtz;


        public IMUData()
        {

        }

        public IMUData(float accx, float accy, float accz, float gysx, float gysy, float gysz, float mgtx, float mgty, float mgtz)
        {
            this.accx = accx;
            this.accy = accy;
            this.accz = accz;
            this.gysx = gysx;
            this.gysy = gysy;
            this.gysz = gysz;
            this.mgtx = mgtx;
            this.mgty = mgty;
            this.mgtz = mgtz;
            this.isNull = false;
        }

        public float getRoll()
        {
            return 0;
        }

        public float getPitch()
        {
            return 0;
        }

        public float getYaw()
        {
            return 0;
        }

        public Boolean isNotSet()
        {
            return isNull;
        }

        public void Copy(IMUData c_imuData)
        {
            this.accx = c_imuData.accx;
            this.accy = c_imuData.accy;
            this.accz = c_imuData.accz;
            this.gysx = c_imuData.gysx;
            this.gysy = c_imuData.gysy;
            this.gysz = c_imuData.gysz;
            this.mgtx = c_imuData.mgtx;
            this.mgty = c_imuData.mgty;
            this.mgtz = c_imuData.mgtz;
            this.isNull = c_imuData.isNotSet();
        }
    }
}

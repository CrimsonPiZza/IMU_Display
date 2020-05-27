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

        public float raw_accx;
        public float raw_accy;
        public float raw_accz;

        public float accx;
        public float accy;
        public float accz;

        public float raw_gysx;
        public float raw_gysy;
        public float raw_gysz;

        public float gysx;
        public float gysy;
        public float gysz;

        public float raw_mgtx;
        public float raw_mgty;
        public float raw_mgtz;

        public float mgtx;
        public float mgty;
        public float mgtz;

        public float eulerx;
        public float eulery;
        public float eulerz;

        public float quatx;
        public float quaty;
        public float quatz;

        public IMUData()
        {

        }

        public IMUData(
            float raw_accx, float raw_accy, float raw_accz, 
            float accx, float accy, float accz, 
            float raw_gysx, float raw_gysy, float raw_gysz, 
            float gysx, float gysy, float gysz, 
            float raw_mgtx, float raw_mgty, float raw_mgtz, 
            float mgtx, float mgty, float mgtz, 
            float eulerx, float eulery, float eulerz, 
            float quatx, float quaty, float quatz)
        {
            this.raw_accx = raw_accx;
            this.raw_accy = raw_accy;
            this.raw_accz = raw_accz;

            this.accx = accx;
            this.accy = accy;
            this.accz = accz;

            this.raw_gysx = raw_gysx;
            this.raw_gysy = raw_gysy;
            this.raw_gysz = raw_gysz;

            this.gysx = gysx;
            this.gysy = gysy;
            this.gysz = gysz;

            this.raw_mgtx = raw_mgtx;
            this.raw_mgty = raw_mgty;
            this.raw_mgtz = raw_mgtz;

            this.mgtx = mgtx;
            this.mgty = mgty;
            this.mgtz = mgtz;

            this.eulerx = eulerx;
            this.eulery = eulery;
            this.eulerz = eulerz;

            this.quatx = quatx;
            this.quaty = quaty;
            this.quatz = quatz;

            this.isNull = false;
        }

        public Boolean isNotSet()
        {
            return isNull;
        }

        public void Copy(IMUData c_imuData)
        {
            this.raw_accx = c_imuData.raw_accx;
            this.raw_accy = c_imuData.raw_accy;
            this.raw_accz = c_imuData.raw_accz;

            this.accx = c_imuData.accx;
            this.accy = c_imuData.accy;
            this.accz = c_imuData.accz;

            this.raw_gysx = c_imuData.raw_gysx;
            this.raw_gysy = c_imuData.raw_gysy;
            this.raw_gysz = c_imuData.raw_gysz;

            this.gysx = c_imuData.gysx;
            this.gysy = c_imuData.gysy;
            this.gysz = c_imuData.gysz;

            this.raw_mgtx = c_imuData.raw_mgtx;
            this.raw_mgty = c_imuData.raw_mgty;
            this.raw_mgtz = c_imuData.raw_mgtz;

            this.mgtx = c_imuData.mgtx;
            this.mgty = c_imuData.mgty;
            this.mgtz = c_imuData.mgtz;

            this.eulerx = c_imuData.eulerx;
            this.eulery = c_imuData.eulery;
            this.eulerz = c_imuData.eulerz;

            this.quatx = c_imuData.quatx;
            this.quaty = c_imuData.quaty;
            this.quatz = c_imuData.quatz;

            this.isNull = c_imuData.isNotSet();
        }
    
        public float[] get_Margin_Accel()
        {
            float m_x;
            float m_y;
            float m_z;

            if (accx > raw_accx)
            {
                m_x = accx - raw_accx;
            }
            else
            {
                m_x = raw_accx - accx;
            }

            if (accy > raw_accy)
            {
                m_y = accy - raw_accy;
            }
            else
            {
                m_y = raw_accy - accy;
            }

            if (accz > raw_accz)
            {
                m_z = accz - raw_accz;
            }
            else
            {
                m_z = raw_accz - accz;
            }

            return new[] { m_x, m_y, m_z };
        }

        public float[] get_Margin_Gyro()
        {
            float m_x;
            float m_y;
            float m_z;

            if (gysx > raw_gysx)
            {
                m_x = gysx - raw_gysx;
            }
            else
            {
                m_x = raw_gysx - gysx;
            }

            if (gysy > raw_gysy)
            {
                m_y = gysy - raw_gysy;
            }
            else
            {
                m_y = raw_gysy - gysy;
            }

            if (gysz > raw_gysz)
            {
                m_z = gysz - raw_gysz;
            }
            else
            {
                m_z = raw_gysz - gysz;
            }

            return new[] { m_x, m_y, m_z };
        }

        public float[] get_Margin_Magneto()
        {
            float m_x;
            float m_y;
            float m_z;

            if (mgtx > raw_mgtx)
            {
                m_x = mgtx - raw_mgtx;
            }
            else
            {
                m_x = raw_mgtx - mgtx;
            }

            if (mgty > raw_mgty)
            {
                m_y = mgty - raw_mgty;
            }
            else
            {
                m_y = raw_mgty - mgty;
            }

            if (mgtz > raw_mgtz)
            {
                m_z = mgtz - raw_mgtz;
            }
            else
            {
                m_z = mgtz - mgtz;
            }

            return new[] { m_x, m_y, m_z };
        }

    }
}

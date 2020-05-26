using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Display
{
    class FormProvider
    {
        private static MainForm mainForm;

        public static MainForm getMain()
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm();
                return mainForm;
            }
            return mainForm;
        }
    }
}

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
        private static Graph_Plotting graphPlot;

        public static MainForm getMain()
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new MainForm();
                return mainForm;
            }
            return mainForm;
        }

        public static Graph_Plotting getGraphPlot(String title)
        {
            if (graphPlot == null || graphPlot.IsDisposed)
            {
                graphPlot = new Graph_Plotting(title);
                return graphPlot;
            }
            return graphPlot;
        }
    }
}

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using Winforms.Cartesian.ConstantChanges;
using LiveCharts.Configurations;
using System.Threading;
using LiveCharts;
using System.Diagnostics;

namespace IMU_Display
{

    public partial class Graph_Plotting : MaterialForm
    {

        public static ChartValues<MeasureModel> accxValues { get; set; }
        public static ChartValues<MeasureModel> accyValues { get; set; }
        public static ChartValues<MeasureModel> acczValues { get; set; }
        public static ChartValues<MeasureModel> raw_accxValues { get; set; }
        public static ChartValues<MeasureModel> raw_accyValues { get; set; }
        public static ChartValues<MeasureModel> raw_acczValues { get; set; }

        public Graph_Plotting(String title)
        {
            InitializeComponent();
            this.Text = title;

            setUpGraph();

            setAxisLimits(System.DateTime.Now);

        }

        public class GraphThread
        {
            public ChartValues<MeasureModel> chart;
            public String chartName;
            public int Hertz = 100;

            public GraphThread(String chartName)
            {
                this.chartName = chartName;
            }

            public void start() {
                var now = System.DateTime.Now;
                switch (chartName)
                {
                    case ("ACCX"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            accxValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.accx
                            });

                            //lets only use the last 100 values
                            if (accxValues.Count > 50)
                            {
                                accxValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                    case ("ACCY"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            accyValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.accy
                            });

                            //lets only use the last 100 values
                            if (accyValues.Count > 50)
                            {
                                accyValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                    case ("ACCZ"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            acczValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.accz
                            });

                            //lets only use the last 100 values
                            if (acczValues.Count > 50)
                            {
                                acczValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                    case ("RACCX"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            raw_accxValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.raw_accx
                            });

                            //lets only use the last 100 values
                            if (raw_accxValues.Count > 50)
                            {
                                raw_accxValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                    case ("RACCY"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            raw_accyValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.raw_accy
                            });

                            //lets only use the last 100 values
                            if (raw_accxValues.Count > 50)
                            {
                                raw_accyValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                    case ("RACCZ"):

                            //var now = System.DateTime.Now;
                            // Add Value
                            raw_acczValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = MainForm.imuData_Device1.raw_accx
                            });

                            //lets only use the last 100 values
                            if (raw_acczValues.Count > 50)
                            {
                                raw_acczValues.RemoveAt(0);
                            }
                            Thread.Sleep(Hertz);

                        break;
                }
            }
        }

        private void setAxisLimits(System.DateTime now)
        {
            cal_accx.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cal_accx.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds

            cal_accy.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cal_accy.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds

            cal_accz.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cal_accz.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds

            raw_accx.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            raw_accx.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds

            raw_accy.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            raw_accy.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds

            raw_accz.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            raw_accz.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void Graph_Plotting_Load(object sender, EventArgs e)
        {
            // Initializing Color Scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void setUpGraph()
        {
            var mapper = Mappers.Xy<MeasureModel>()
            .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
            .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            accxValues = new ChartValues<MeasureModel>();
            accyValues = new ChartValues<MeasureModel>();
            acczValues = new ChartValues<MeasureModel>();
            raw_accxValues = new ChartValues<MeasureModel>();
            raw_accyValues = new ChartValues<MeasureModel>();
            raw_acczValues = new ChartValues<MeasureModel>();

            // AccX Graph
            cal_accx.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = accxValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            cal_accx.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cal_accx.AnimationsSpeed = TimeSpan.FromMilliseconds(200);

            // AccY Graph
            cal_accy.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = accyValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            cal_accy.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cal_accy.AnimationsSpeed = TimeSpan.FromMilliseconds(200);

            // AccZ Graph
            cal_accz.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = acczValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            cal_accz.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            // Raw_AccX Graph
            raw_accx.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = raw_accxValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            raw_accx.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            // Raw_AccY Graph
            raw_accy.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = raw_accyValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            raw_accy.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            // Raw_AccZ Graph
            raw_accz.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = raw_acczValues,
                    PointGeometry = null,
                    StrokeThickness = 1
                }
            };
            raw_accz.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });


        }

        private void setAxisMINMAX_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(accxValues.Count);

            GraphThread accx = new GraphThread("ACCX");
            Thread thr_accx = new Thread(new ThreadStart(accx.start));
            thr_accx.SetApartmentState(ApartmentState.STA);
            thr_accx.Start();

            GraphThread accy = new GraphThread("ACCY");
            Thread thr_accy = new Thread(new ThreadStart(accy.start));
            thr_accy.SetApartmentState(ApartmentState.STA);
            thr_accy.Start();

            GraphThread accz = new GraphThread("ACCZ");
            Thread thr_accz = new Thread(new ThreadStart(accz.start));
            thr_accz.SetApartmentState(ApartmentState.STA);
            thr_accz.Start();

            GraphThread raw_accx = new GraphThread("RACCX");
            Thread thr_raccx = new Thread(new ThreadStart(raw_accx.start));
            thr_raccx.SetApartmentState(ApartmentState.STA);
            thr_raccx.Start();

            GraphThread raw_accy = new GraphThread("RACCY");
            Thread thr_raccy = new Thread(new ThreadStart(raw_accy.start));
            thr_raccy.SetApartmentState(ApartmentState.STA);
            thr_raccy.Start();

            GraphThread raw_accz = new GraphThread("RACCZ");
            Thread thr_raccz = new Thread(new ThreadStart(raw_accz.start));
            thr_raccz.SetApartmentState(ApartmentState.STA);
            thr_raccz.Start();

            setAxisLimits(System.DateTime.Now);
        }
    }
}

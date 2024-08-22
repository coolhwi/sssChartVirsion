using DevExpress.XtraEditors.TextEditController.Utils;
using DevExpress.XtraPrinting.Native.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sssChartVirsion
{
    public partial class Form1 : Form
    {
        static double _totalIntalArrTime = 0;
        static Random _random = new Random();
        static int _name = 2;
        static int _q = 0;

        static bool _m = false;
        static bool _prevM = false;

        static double _now = 0;
        static double _prevNow = 0;
        static double _curTime = 0;
        static EventCalender _eventCalender = new EventCalender();
        static double[] _interArrTimes = { 1.73, 1.35, 0.71, 0.62, 14.28, 0.70, 15.52, 3.15, 1.76, 1, 1, 1 };
        static double[] _serviceTimes = { 2.9, 1.76, 3.39, 4.52, 4.46, 4.36, 2.07, 3.36, 2.37, 5.38, 1, 1, 1 };

        static List<double> _recordInterArrTimes = new List<double>();
        static List<double> _recordServiceTimes = new List<double>();

        static List<double> _arrTimeQue = new List<double>();
        static int _waitEventNum = 2;

        static double _totalWaitTime = 0;
        static double _areaUnderQT = 0;
        static double _areaUnderBT = 0;
        static int i = 0;
        static int s = 0;

        static bool _timeFlag = false;
        static bool _allStepFlag = false;
        static bool _firstRun = true;
        static bool _endFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        void RunProgram()
        {
            Console.WriteLine("Hello, World!");

            Event selectEvent = _eventCalender.SelectEvent();

            _prevNow = _now;
            _now = selectEvent.time;


            if (selectEvent.type == EventType.End)
            {
                _prevNow = _curTime;
                _curTime = 20;
                CalKPI();
                RefreshView();
                ShowChart();
                MessageBox.Show("시뮬레이터가 종료되었습니다.");
                _endFlag = true;
                return;
            }


            if (_now <= selectEvent.time)
            {
                _prevNow = _curTime;
                _curTime = selectEvent.time;
                CalKPI();
                
                _timeFlag = false;
            }

            switch (selectEvent.type)
            {
                case EventType.Arr:
                    RunArrEvent(selectEvent);
                    break;
                case EventType.Load:
                    RunLoadEvent(selectEvent);
                    break;
                case EventType.Unload:
                    RunUnloadEvent(selectEvent);
                    break;
                default:
                    Console.WriteLine($"{selectEvent.type}는 잘못된 타입입니다.");
                    break;
            }
            _eventCalender.RefreshEvent();
            
        }

        void CalKPI()
        {
            CalAreaUnderBT();
            CalAreaUnderQT();
        }

        void RunArrEvent(Event selectEvent)
        {
            _q = _q + 1;
            if (!_m)
            {
                Event inputEvent = new Event(EventType.Load, selectEvent.name, _now);
                RunLoadEvent(inputEvent);
                _eventCalender.InputEvent(GenerateEvent());
                return;
            }

            // 뽑힌 노드가 대기큐로 들어가야함
            _arrTimeQue.Add(_now);

            _eventCalender.InputEvent(GenerateEvent());

            RefreshView();
            ShowChart();
        }

        void RunLoadEvent(Event selectEvent)
        {
            //double serviceTime = _random.NextDouble() * 5;
            //serviceTime = Math.Round(serviceTime, 2);

            double serviceTime = _serviceTimes[s];
            serviceTime = Math.Round(serviceTime, 2);
            s++;
            _q = _q - 1;

            _m = true;

            Event unloadEvent = new Event(EventType.Unload, selectEvent.name, _now + serviceTime);
            _eventCalender.InputEvent(unloadEvent);

            //waitTime 구하기
            _totalWaitTime += _now - selectEvent.time;
            RefreshView();
            ShowLoadChart();
        }
        void RunUnloadEvent(Event selectEvent)
        {
            _prevM = _m  ;

            _m = false;
            

            if (_q > 0)
            {
                // 대기큐에서 꺼내옴
                double arrEventTime = _arrTimeQue[0];
                _arrTimeQue.RemoveAt(0);
                Event loadEventt = new Event(EventType.Load, _waitEventNum.ToString(), arrEventTime);
                _waitEventNum++;
                RunLoadEvent(loadEventt);
                return;
            }

            ShowUnloadAndNotQueGraph();

        }

        Event GenerateEvent()
        {
            double interArrTime = _interArrTimes[i];
            i++;
            interArrTime = Math.Round(interArrTime, 2);

            //double interArrTime = _random.NextDouble() * 10;
            //interArrTime = Math.Round(interArrTime, 2);
            int name = _name++;

            return new Event(EventType.Arr, name.ToString(), _now + interArrTime);
        }

        void CalAreaUnderQT()
        {
            _areaUnderQT += (_curTime - _prevNow) * _q;
        }

        void CalAreaUnderBT()
        {
            if (_m)
            {
                _areaUnderBT += _curTime - _prevNow;
            }
        }

        static void Init()
        {
            Event curEvent = new Event(EventType.Arr, "1", 0);
            Event endEvent = new Event(EventType.End, "-", 20);
            _eventCalender.InputEvent(curEvent);
            _eventCalender.InputEvent(endEvent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // chart 배경 색
            chQtGrapch.ChartAreas[0].BackColor = Color.Black;
            chBtGrapch.ChartAreas[0].BackColor = Color.Black;

            // chart X축 Y축 설정
            chQtGrapch.ChartAreas[0].AxisX.Minimum = 0;
            chQtGrapch.ChartAreas[0].AxisX.Maximum = 20;
            chQtGrapch.ChartAreas[0].AxisY.Minimum = 0;
            chQtGrapch.ChartAreas[0].AxisY.Maximum = 5;
            chQtGrapch.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chQtGrapch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;


            chBtGrapch.ChartAreas[0].AxisX.Minimum = 0;
            chBtGrapch.ChartAreas[0].AxisX.Maximum = 20;
            chBtGrapch.ChartAreas[0].AxisY.Minimum = 0;
            chBtGrapch.ChartAreas[0].AxisY.Maximum = 2;
            chBtGrapch.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chBtGrapch.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // chart 색, 선두께 설정
            chQtGrapch.Series[0].Color = Color.LightGreen;
            chQtGrapch.Series[0].BorderWidth = 2;

            chBtGrapch.Series[0].Color = Color.LightGreen;
            chBtGrapch.Series[0].BorderWidth = 2;
        }

        private void RefreshView()
        {
            ShowBaseInfo();
            ShowKPI();
            ShowInterAndServiceTime();
            ShowEventCalender();

        }

        private void ShowEventCalender()
        {
            string eventCalenderEvent = "";

            foreach(Event e in _eventCalender.events)
            {
                string s = $"[{e.name}, {e.time}, {e.type}]";
                eventCalenderEvent += s + "\n";
            }

            lbEventCalendar.Text = eventCalenderEvent;
        }

        private void ShowUnloadAndNotQueGraph()
        {
            chQtGrapch.Series[0].Points.AddXY(_curTime, _q);
            chBtGrapch.Series[0].Points.AddXY(_curTime, 1);
        }

        private void ShowChart()
        {
            if (chQtGrapch.Series[0].Points.Count == 20 && chBtGrapch.Series[0].Points.Count == 20)
            {
                return;
            }

            if (chQtGrapch.IsHandleCreated && chBtGrapch.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate { GenerateNum(); });
            }

        }

        private void ShowLoadChart()
        {
            if (chQtGrapch.Series[0].Points.Count == 20 && chBtGrapch.Series[0].Points.Count == 20)
            {
                return;
            }

            if (chQtGrapch.IsHandleCreated && chBtGrapch.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate { GenerateLoadNum(); });
            }

        }

        private void GenerateLoadNum()
        {
            
            chQtGrapch.Series[0].Points.AddXY(_curTime, _q + 1);
            chQtGrapch.Series[0].Points.AddXY(_curTime, _q);


            if (!_prevM)
            {
                chBtGrapch.Series[0].Points.AddXY(_curTime, 0);
            }

            if (_m)
            {
                chBtGrapch.Series[0].Points.AddXY(_curTime, 1);
                return;
            }
            chBtGrapch.Series[0].Points.AddXY(_curTime, 0);
        }

        private void GenerateNum()
        {
            if (_endFlag)
            {
                chQtGrapch.Series[0].Points.AddXY(_curTime, _q);
                if (_m)
                {
                    chBtGrapch.Series[0].Points.AddXY(_curTime, 1);
                    return;
                }
                chBtGrapch.Series[0].Points.AddXY(_curTime, 0);

                return;
            }

            if (_q != 0)
            {
                chQtGrapch.Series[0].Points.AddXY(_curTime, _q-1);
            }
            else
            {
                chQtGrapch.Series[0].Points.AddXY(_curTime, 0);
            }
            chQtGrapch.Series[0].Points.AddXY(_curTime,_q);

            if (_m)
            {
                chBtGrapch.Series[0].Points.AddXY(_curTime,1);
                return;
            }
            chBtGrapch.Series[0].Points.AddXY(_curTime,0);
        }

        private void ShowBaseInfo()
        {
            if (_m)
            {
                lbBT.Text = "1";
            }
            else
            {
                lbBT.Text = "0";
            }

            lbQT.Text = _q.ToString();

            lbCurClock.Text = _curTime.ToString();
        }
        private void ShowKPI()
        {
            lbTotalWaitingTime.Text = _totalWaitTime.ToString();

            lbAreaUnderQT.Text = _areaUnderQT.ToString();
            lbAreaUnderBT.Text = _areaUnderBT.ToString();
        }



        private void ShowInterAndServiceTime()
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_firstRun)
            {
                Init();
                _firstRun = false;
                RefreshView();

            }
            while (_timeFlag && !_endFlag)
            {
                RunProgram();
            }
            _timeFlag = true;
        }
    }
}

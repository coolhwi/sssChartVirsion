namespace sssChartVirsion
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbServiceTimes = new System.Windows.Forms.Label();
            this.lbInterArrTimes = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chBtGrapch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chQtGrapch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbAreaUnderBT = new System.Windows.Forms.Label();
            this.lbAreaUnderQT = new System.Windows.Forms.Label();
            this.lbTotalWaitingTime = new System.Windows.Forms.Label();
            this.lbWokingNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbEventCalendar = new System.Windows.Forms.Label();
            this.lbArrTimeInQueue = new System.Windows.Forms.Label();
            this.lbQT = new System.Windows.Forms.Label();
            this.lbBT = new System.Windows.Forms.Label();
            this.lbCurClock = new System.Windows.Forms.Label();
            this.lbSystemState = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAllStep = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chBtGrapch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chQtGrapch)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.lbServiceTimes, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbInterArrTimes, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 475);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(981, 89);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // lbServiceTimes
            // 
            this.lbServiceTimes.AutoSize = true;
            this.lbServiceTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServiceTimes.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbServiceTimes.Location = new System.Drawing.Point(199, 44);
            this.lbServiceTimes.Name = "lbServiceTimes";
            this.lbServiceTimes.Size = new System.Drawing.Size(779, 45);
            this.lbServiceTimes.TabIndex = 6;
            this.lbServiceTimes.Text = "serviceTimes";
            this.lbServiceTimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInterArrTimes
            // 
            this.lbInterArrTimes.AutoSize = true;
            this.lbInterArrTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInterArrTimes.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbInterArrTimes.Location = new System.Drawing.Point(199, 0);
            this.lbInterArrTimes.Name = "lbInterArrTimes";
            this.lbInterArrTimes.Size = new System.Drawing.Size(779, 44);
            this.lbInterArrTimes.TabIndex = 5;
            this.lbInterArrTimes.Text = "interArrTimes";
            this.lbInterArrTimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 44);
            this.label17.TabIndex = 3;
            this.label17.Text = "Interarrival times";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(3, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 45);
            this.label18.TabIndex = 4;
            this.label18.Text = "Service times";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chBtGrapch, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.chQtGrapch, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(981, 258);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 154);
            this.label15.TabIndex = 1;
            this.label15.Text = "Q(t) graph";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(3, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 104);
            this.label16.TabIndex = 2;
            this.label16.Text = "B(t) graph";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chBtGrapch
            // 
            chartArea1.Name = "ChartArea1";
            this.chBtGrapch.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chBtGrapch.Legends.Add(legend1);
            this.chBtGrapch.Location = new System.Drawing.Point(199, 157);
            this.chBtGrapch.Name = "chBtGrapch";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chBtGrapch.Series.Add(series1);
            this.chBtGrapch.Size = new System.Drawing.Size(779, 98);
            this.chBtGrapch.TabIndex = 4;
            this.chBtGrapch.Text = "chart2";
            // 
            // chQtGrapch
            // 
            chartArea2.Name = "ChartArea1";
            this.chQtGrapch.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chQtGrapch.Legends.Add(legend2);
            this.chQtGrapch.Location = new System.Drawing.Point(199, 3);
            this.chQtGrapch.Name = "chQtGrapch";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chQtGrapch.Series.Add(series2);
            this.chQtGrapch.Size = new System.Drawing.Size(779, 148);
            this.chQtGrapch.TabIndex = 3;
            this.chQtGrapch.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(741, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "B(t)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(495, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Q(t)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(253, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "TotalWaitingTimeInQueue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "WorkingNum";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lbAreaUnderBT, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbAreaUnderQT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTotalWaitingTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbWokingNum, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 162);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(981, 43);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lbAreaUnderBT
            // 
            this.lbAreaUnderBT.AutoSize = true;
            this.lbAreaUnderBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAreaUnderBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAreaUnderBT.Location = new System.Drawing.Point(738, 0);
            this.lbAreaUnderBT.Name = "lbAreaUnderBT";
            this.lbAreaUnderBT.Size = new System.Drawing.Size(240, 43);
            this.lbAreaUnderBT.TabIndex = 4;
            this.lbAreaUnderBT.Text = "0";
            this.lbAreaUnderBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAreaUnderQT
            // 
            this.lbAreaUnderQT.AutoSize = true;
            this.lbAreaUnderQT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAreaUnderQT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAreaUnderQT.Location = new System.Drawing.Point(493, 0);
            this.lbAreaUnderQT.Name = "lbAreaUnderQT";
            this.lbAreaUnderQT.Size = new System.Drawing.Size(239, 43);
            this.lbAreaUnderQT.TabIndex = 3;
            this.lbAreaUnderQT.Text = "0";
            this.lbAreaUnderQT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalWaitingTime
            // 
            this.lbTotalWaitingTime.AutoSize = true;
            this.lbTotalWaitingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalWaitingTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTotalWaitingTime.Location = new System.Drawing.Point(248, 0);
            this.lbTotalWaitingTime.Name = "lbTotalWaitingTime";
            this.lbTotalWaitingTime.Size = new System.Drawing.Size(239, 43);
            this.lbTotalWaitingTime.TabIndex = 2;
            this.lbTotalWaitingTime.Text = "0";
            this.lbTotalWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWokingNum
            // 
            this.lbWokingNum.AutoSize = true;
            this.lbWokingNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWokingNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbWokingNum.Location = new System.Drawing.Point(3, 0);
            this.lbWokingNum.Name = "lbWokingNum";
            this.lbWokingNum.Size = new System.Drawing.Size(239, 43);
            this.lbWokingNum.TabIndex = 1;
            this.lbWokingNum.Text = "0";
            this.lbWokingNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(298, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "B(t)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(398, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Q(t)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(495, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arr Time in queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(737, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Event calendar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbEventCalendar, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbArrTimeInQueue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbQT, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBT, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCurClock, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSystemState, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbEventCalendar
            // 
            this.lbEventCalendar.AutoSize = true;
            this.lbEventCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEventCalendar.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbEventCalendar.Location = new System.Drawing.Point(738, 0);
            this.lbEventCalendar.Name = "lbEventCalendar";
            this.lbEventCalendar.Size = new System.Drawing.Size(240, 100);
            this.lbEventCalendar.TabIndex = 5;
            this.lbEventCalendar.Text = "[empty]";
            this.lbEventCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArrTimeInQueue
            // 
            this.lbArrTimeInQueue.AutoSize = true;
            this.lbArrTimeInQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbArrTimeInQueue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbArrTimeInQueue.Location = new System.Drawing.Point(493, 0);
            this.lbArrTimeInQueue.Name = "lbArrTimeInQueue";
            this.lbArrTimeInQueue.Size = new System.Drawing.Size(239, 100);
            this.lbArrTimeInQueue.TabIndex = 4;
            this.lbArrTimeInQueue.Text = "<empty>";
            this.lbArrTimeInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQT
            // 
            this.lbQT.AutoSize = true;
            this.lbQT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbQT.Location = new System.Drawing.Point(395, 0);
            this.lbQT.Name = "lbQT";
            this.lbQT.Size = new System.Drawing.Size(92, 100);
            this.lbQT.TabIndex = 3;
            this.lbQT.Text = "0";
            this.lbQT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBT
            // 
            this.lbBT.AutoSize = true;
            this.lbBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBT.Location = new System.Drawing.Point(297, 0);
            this.lbBT.Name = "lbBT";
            this.lbBT.Size = new System.Drawing.Size(92, 100);
            this.lbBT.TabIndex = 2;
            this.lbBT.Text = "0";
            this.lbBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurClock
            // 
            this.lbCurClock.AutoSize = true;
            this.lbCurClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurClock.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCurClock.Location = new System.Drawing.Point(199, 0);
            this.lbCurClock.Name = "lbCurClock";
            this.lbCurClock.Size = new System.Drawing.Size(92, 100);
            this.lbCurClock.TabIndex = 1;
            this.lbCurClock.Text = "0";
            this.lbCurClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSystemState
            // 
            this.lbSystemState.AutoSize = true;
            this.lbSystemState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSystemState.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSystemState.Location = new System.Drawing.Point(3, 0);
            this.lbSystemState.Name = "lbSystemState";
            this.lbSystemState.Size = new System.Drawing.Size(190, 100);
            this.lbSystemState.TabIndex = 0;
            this.lbSystemState.Text = "SystemState";
            this.lbSystemState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1034, 22);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAllStep
            // 
            this.btnAllStep.Location = new System.Drawing.Point(1035, 62);
            this.btnAllStep.Name = "btnAllStep";
            this.btnAllStep.Size = new System.Drawing.Size(75, 34);
            this.btnAllStep.TabIndex = 2;
            this.btnAllStep.Text = "AllStep";
            this.btnAllStep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 616);
            this.Controls.Add(this.btnAllStep);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chBtGrapch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chQtGrapch)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbArrTimeInQueue;
        private System.Windows.Forms.Label lbQT;
        private System.Windows.Forms.Label lbBT;
        private System.Windows.Forms.Label lbCurClock;
        private System.Windows.Forms.Label lbSystemState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbAreaUnderBT;
        private System.Windows.Forms.Label lbAreaUnderQT;
        private System.Windows.Forms.Label lbTotalWaitingTime;
        private System.Windows.Forms.Label lbWokingNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chBtGrapch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chQtGrapch;
        private System.Windows.Forms.Label lbServiceTimes;
        private System.Windows.Forms.Label lbInterArrTimes;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAllStep;
        private System.Windows.Forms.Label lbEventCalendar;
    }
}


namespace EventDataAnalyzer_HHP.UI
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dtp_TrainDepTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_StationKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_ReadFrom = new System.Windows.Forms.DateTimePicker();
            this.Dtp_ReadTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SheetName = new System.Windows.Forms.TextBox();
            this.Chk_IsPsi = new System.Windows.Forms.CheckBox();
            this.Chk_IsTheTimeSeperate = new System.Windows.Forms.CheckBox();
            this.Btn_ReadFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Filepath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_StartAddOnKms = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_ImportEvent = new System.Windows.Forms.DataGridView();
            this.COL_START = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COL_STOP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dgv_Col_StartStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Col_TStn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Col_MPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Col_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Col_CumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceTravelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerKW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPpressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCpressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsGFenabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReverserPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThrottlePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsHorn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsHLshorthoodBurning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsHLlonghoodBurning = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPCSenabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPenaltyBrakeApplied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsMomoryFreezed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EventCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STGBCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ImportEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1319, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Dtp_TrainDepTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_StationKm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dtp_ReadFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dtp_ReadTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_SheetName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Chk_IsPsi, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Chk_IsTheTimeSeperate, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ReadFile, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Filepath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txt_StartAddOnKms, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1313, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Dtp_TrainDepTime
            // 
            this.Dtp_TrainDepTime.CustomFormat = "dd-MM-yy HH:mm:00";
            this.Dtp_TrainDepTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_TrainDepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_TrainDepTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_TrainDepTime.Location = new System.Drawing.Point(190, 75);
            this.Dtp_TrainDepTime.Name = "Dtp_TrainDepTime";
            this.Dtp_TrainDepTime.Size = new System.Drawing.Size(217, 30);
            this.Dtp_TrainDepTime.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Train Dep Time";
            // 
            // Txt_StationKm
            // 
            this.Txt_StationKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_StationKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_StationKm.Location = new System.Drawing.Point(550, 39);
            this.Txt_StationKm.Name = "Txt_StationKm";
            this.Txt_StationKm.Size = new System.Drawing.Size(156, 28);
            this.Txt_StationKm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(413, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sheet Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Read From Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Read End Time";
            // 
            // Dtp_ReadFrom
            // 
            this.Dtp_ReadFrom.CustomFormat = "dd-MM-yy HH:mm:00";
            this.Dtp_ReadFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_ReadFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ReadFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_ReadFrom.Location = new System.Drawing.Point(190, 3);
            this.Dtp_ReadFrom.Name = "Dtp_ReadFrom";
            this.Dtp_ReadFrom.Size = new System.Drawing.Size(217, 30);
            this.Dtp_ReadFrom.TabIndex = 0;
            // 
            // Dtp_ReadTo
            // 
            this.Dtp_ReadTo.CustomFormat = "dd-MM-yy HH:mm:00";
            this.Dtp_ReadTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp_ReadTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_ReadTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_ReadTo.Location = new System.Drawing.Point(190, 39);
            this.Dtp_ReadTo.Name = "Dtp_ReadTo";
            this.Dtp_ReadTo.Size = new System.Drawing.Size(217, 30);
            this.Dtp_ReadTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(413, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Station Km";
            // 
            // Txt_SheetName
            // 
            this.Txt_SheetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SheetName.Location = new System.Drawing.Point(550, 3);
            this.Txt_SheetName.Name = "Txt_SheetName";
            this.Txt_SheetName.Size = new System.Drawing.Size(156, 28);
            this.Txt_SheetName.TabIndex = 6;
            // 
            // Chk_IsPsi
            // 
            this.Chk_IsPsi.AutoSize = true;
            this.Chk_IsPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_IsPsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Chk_IsPsi.Location = new System.Drawing.Point(712, 3);
            this.Chk_IsPsi.Name = "Chk_IsPsi";
            this.Chk_IsPsi.Size = new System.Drawing.Size(219, 26);
            this.Chk_IsPsi.TabIndex = 11;
            this.Chk_IsPsi.Text = "Is Pressures In PSI ?";
            this.Chk_IsPsi.UseVisualStyleBackColor = true;
            this.Chk_IsPsi.CheckStateChanged += new System.EventHandler(this.Chk_IsPsi_CheckStateChanged);
            // 
            // Chk_IsTheTimeSeperate
            // 
            this.Chk_IsTheTimeSeperate.AutoSize = true;
            this.Chk_IsTheTimeSeperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_IsTheTimeSeperate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Chk_IsTheTimeSeperate.Location = new System.Drawing.Point(712, 39);
            this.Chk_IsTheTimeSeperate.Name = "Chk_IsTheTimeSeperate";
            this.Chk_IsTheTimeSeperate.Size = new System.Drawing.Size(315, 26);
            this.Chk_IsTheTimeSeperate.TabIndex = 12;
            this.Chk_IsTheTimeSeperate.Text = "Is The Time Column Seperate ?";
            this.Chk_IsTheTimeSeperate.UseVisualStyleBackColor = true;
            // 
            // Btn_ReadFile
            // 
            this.Btn_ReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReadFile.ForeColor = System.Drawing.Color.Blue;
            this.Btn_ReadFile.Location = new System.Drawing.Point(1033, 111);
            this.Btn_ReadFile.Name = "Btn_ReadFile";
            this.Btn_ReadFile.Size = new System.Drawing.Size(217, 39);
            this.Btn_ReadFile.TabIndex = 4;
            this.Btn_ReadFile.Text = "Read Event File";
            this.Btn_ReadFile.UseVisualStyleBackColor = true;
            this.Btn_ReadFile.Click += new System.EventHandler(this.Btn_ReadFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Event File (xls/xlsx)";
            // 
            // Txt_Filepath
            // 
            this.Txt_Filepath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_Filepath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Txt_Filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.Txt_Filepath, 4);
            this.Txt_Filepath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Filepath.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Txt_Filepath.Location = new System.Drawing.Point(190, 111);
            this.Txt_Filepath.Name = "Txt_Filepath";
            this.Txt_Filepath.ReadOnly = true;
            this.Txt_Filepath.Size = new System.Drawing.Size(837, 28);
            this.Txt_Filepath.TabIndex = 19;
            this.Txt_Filepath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Filepath_MouseClick);
            this.Txt_Filepath.TextChanged += new System.EventHandler(this.Txt_Filepath_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(413, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Start Add Mts";
            // 
            // Txt_StartAddOnKms
            // 
            this.Txt_StartAddOnKms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_StartAddOnKms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Txt_StartAddOnKms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_StartAddOnKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_StartAddOnKms.Location = new System.Drawing.Point(550, 75);
            this.Txt_StartAddOnKms.Name = "Txt_StartAddOnKms";
            this.Txt_StartAddOnKms.Size = new System.Drawing.Size(156, 28);
            this.Txt_StartAddOnKms.TabIndex = 17;
            this.Txt_StartAddOnKms.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.Dgv_ImportEvent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1319, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Dgv_ImportEvent
            // 
            this.Dgv_ImportEvent.AllowUserToAddRows = false;
            this.Dgv_ImportEvent.AllowUserToDeleteRows = false;
            this.Dgv_ImportEvent.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ImportEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ImportEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ImportEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_START,
            this.COL_STOP,
            this.Dgv_Col_StartStation,
            this.Dgv_Col_TStn,
            this.Dgv_Col_MPS,
            this.Dgv_Col_CD,
            this.Dgv_Col_CumCol,
            this.EventDateTime,
            this.Speed,
            this.DistanceTravelled,
            this.TEBE,
            this.PowerKW,
            this.BPpressure,
            this.BCpressure,
            this.TL24,
            this.IsGFenabled,
            this.ReverserPosition,
            this.ThrottlePosition,
            this.IsHorn,
            this.IsHLshorthoodBurning,
            this.IsHLlonghoodBurning,
            this.IsPCSenabled,
            this.IsPenaltyBrakeApplied,
            this.IsMomoryFreezed,
            this.EventCode,
            this.STGBCL});
            this.Dgv_ImportEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_ImportEvent.EnableHeadersVisualStyles = false;
            this.Dgv_ImportEvent.GridColor = System.Drawing.Color.SeaGreen;
            this.Dgv_ImportEvent.Location = new System.Drawing.Point(3, 18);
            this.Dgv_ImportEvent.Name = "Dgv_ImportEvent";
            this.Dgv_ImportEvent.RowHeadersWidth = 51;
            this.Dgv_ImportEvent.RowTemplate.Height = 24;
            this.Dgv_ImportEvent.Size = new System.Drawing.Size(1313, 383);
            this.Dgv_ImportEvent.TabIndex = 0;
            // 
            // COL_START
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            this.COL_START.DefaultCellStyle = dataGridViewCellStyle2;
            this.COL_START.HeaderText = "START";
            this.COL_START.MinimumWidth = 6;
            this.COL_START.Name = "COL_START";
            this.COL_START.ToolTipText = "Train started here";
            this.COL_START.Width = 125;
            // 
            // COL_STOP
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            this.COL_STOP.DefaultCellStyle = dataGridViewCellStyle3;
            this.COL_STOP.HeaderText = "STOP";
            this.COL_STOP.MinimumWidth = 6;
            this.COL_STOP.Name = "COL_STOP";
            this.COL_STOP.ToolTipText = "Train Stopped Here";
            this.COL_STOP.Width = 125;
            // 
            // Dgv_Col_StartStation
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Dgv_Col_StartStation.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Col_StartStation.HeaderText = "FROM-STN";
            this.Dgv_Col_StartStation.MaxInputLength = 6;
            this.Dgv_Col_StartStation.MinimumWidth = 6;
            this.Dgv_Col_StartStation.Name = "Dgv_Col_StartStation";
            this.Dgv_Col_StartStation.Width = 125;
            // 
            // Dgv_Col_TStn
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Dgv_Col_TStn.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Col_TStn.HeaderText = "TO-STN";
            this.Dgv_Col_TStn.MaxInputLength = 6;
            this.Dgv_Col_TStn.MinimumWidth = 6;
            this.Dgv_Col_TStn.Name = "Dgv_Col_TStn";
            this.Dgv_Col_TStn.Width = 125;
            // 
            // Dgv_Col_MPS
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Dgv_Col_MPS.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Col_MPS.HeaderText = "MPS";
            this.Dgv_Col_MPS.MaxInputLength = 3;
            this.Dgv_Col_MPS.MinimumWidth = 6;
            this.Dgv_Col_MPS.Name = "Dgv_Col_MPS";
            this.Dgv_Col_MPS.Width = 125;
            // 
            // Dgv_Col_CD
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Dgv_Col_CD.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Col_CD.HeaderText = "CD";
            this.Dgv_Col_CD.MaxInputLength = 3;
            this.Dgv_Col_CD.MinimumWidth = 6;
            this.Dgv_Col_CD.Name = "Dgv_Col_CD";
            this.Dgv_Col_CD.Width = 125;
            // 
            // Dgv_Col_CumCol
            // 
            this.Dgv_Col_CumCol.HeaderText = "CUM DIST";
            this.Dgv_Col_CumCol.MinimumWidth = 6;
            this.Dgv_Col_CumCol.Name = "Dgv_Col_CumCol";
            this.Dgv_Col_CumCol.ReadOnly = true;
            this.Dgv_Col_CumCol.Width = 125;
            // 
            // EventDateTime
            // 
            this.EventDateTime.DataPropertyName = "EventDateTime";
            this.EventDateTime.HeaderText = "EVENT TIME";
            this.EventDateTime.MinimumWidth = 6;
            this.EventDateTime.Name = "EventDateTime";
            this.EventDateTime.ReadOnly = true;
            this.EventDateTime.Width = 125;
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            this.Speed.HeaderText = "SPEED";
            this.Speed.MinimumWidth = 6;
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.Width = 125;
            // 
            // DistanceTravelled
            // 
            this.DistanceTravelled.DataPropertyName = "DistanceTravelled";
            this.DistanceTravelled.HeaderText = "DISTANCE";
            this.DistanceTravelled.MinimumWidth = 6;
            this.DistanceTravelled.Name = "DistanceTravelled";
            this.DistanceTravelled.ReadOnly = true;
            this.DistanceTravelled.Width = 125;
            // 
            // TEBE
            // 
            this.TEBE.DataPropertyName = "TEBE";
            this.TEBE.HeaderText = "TEBE";
            this.TEBE.MinimumWidth = 6;
            this.TEBE.Name = "TEBE";
            this.TEBE.ReadOnly = true;
            this.TEBE.Width = 125;
            // 
            // PowerKW
            // 
            this.PowerKW.DataPropertyName = "PowerKW";
            this.PowerKW.HeaderText = "POWER";
            this.PowerKW.MinimumWidth = 6;
            this.PowerKW.Name = "PowerKW";
            this.PowerKW.ReadOnly = true;
            this.PowerKW.Width = 125;
            // 
            // BPpressure
            // 
            this.BPpressure.DataPropertyName = "BPpressure";
            this.BPpressure.HeaderText = "BPP";
            this.BPpressure.MinimumWidth = 6;
            this.BPpressure.Name = "BPpressure";
            this.BPpressure.ReadOnly = true;
            this.BPpressure.Width = 125;
            // 
            // BCpressure
            // 
            this.BCpressure.DataPropertyName = "BCpressure";
            this.BCpressure.HeaderText = "BCP";
            this.BCpressure.MinimumWidth = 6;
            this.BCpressure.Name = "BCpressure";
            this.BCpressure.ReadOnly = true;
            this.BCpressure.Width = 125;
            // 
            // TL24
            // 
            this.TL24.DataPropertyName = "TL24";
            this.TL24.HeaderText = "TL24";
            this.TL24.MinimumWidth = 6;
            this.TL24.Name = "TL24";
            this.TL24.ReadOnly = true;
            this.TL24.Width = 125;
            // 
            // IsGFenabled
            // 
            this.IsGFenabled.DataPropertyName = "IsGFenabled";
            this.IsGFenabled.HeaderText = "GF";
            this.IsGFenabled.MinimumWidth = 6;
            this.IsGFenabled.Name = "IsGFenabled";
            this.IsGFenabled.ReadOnly = true;
            this.IsGFenabled.Width = 125;
            // 
            // ReverserPosition
            // 
            this.ReverserPosition.DataPropertyName = "ReverserPosition";
            this.ReverserPosition.HeaderText = "REV";
            this.ReverserPosition.MinimumWidth = 6;
            this.ReverserPosition.Name = "ReverserPosition";
            this.ReverserPosition.ReadOnly = true;
            this.ReverserPosition.Width = 125;
            // 
            // ThrottlePosition
            // 
            this.ThrottlePosition.DataPropertyName = "ThrottlePosition";
            this.ThrottlePosition.HeaderText = "THR";
            this.ThrottlePosition.MinimumWidth = 6;
            this.ThrottlePosition.Name = "ThrottlePosition";
            this.ThrottlePosition.ReadOnly = true;
            this.ThrottlePosition.Width = 125;
            // 
            // IsHorn
            // 
            this.IsHorn.DataPropertyName = "IsHorn";
            this.IsHorn.HeaderText = "HORN";
            this.IsHorn.MinimumWidth = 6;
            this.IsHorn.Name = "IsHorn";
            this.IsHorn.ReadOnly = true;
            this.IsHorn.Width = 125;
            // 
            // IsHLshorthoodBurning
            // 
            this.IsHLshorthoodBurning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsHLshorthoodBurning.DataPropertyName = "IsHLshorthoodBurning";
            this.IsHLshorthoodBurning.HeaderText = "HL/S";
            this.IsHLshorthoodBurning.MinimumWidth = 6;
            this.IsHLshorthoodBurning.Name = "IsHLshorthoodBurning";
            this.IsHLshorthoodBurning.ReadOnly = true;
            this.IsHLshorthoodBurning.Width = 58;
            // 
            // IsHLlonghoodBurning
            // 
            this.IsHLlonghoodBurning.DataPropertyName = "IsHLlonghoodBurning";
            this.IsHLlonghoodBurning.HeaderText = "HL/L";
            this.IsHLlonghoodBurning.MinimumWidth = 6;
            this.IsHLlonghoodBurning.Name = "IsHLlonghoodBurning";
            this.IsHLlonghoodBurning.ReadOnly = true;
            this.IsHLlonghoodBurning.Width = 125;
            // 
            // IsPCSenabled
            // 
            this.IsPCSenabled.DataPropertyName = "IsPCSenabled";
            this.IsPCSenabled.HeaderText = "PCS";
            this.IsPCSenabled.MinimumWidth = 6;
            this.IsPCSenabled.Name = "IsPCSenabled";
            this.IsPCSenabled.ReadOnly = true;
            this.IsPCSenabled.Width = 125;
            // 
            // IsPenaltyBrakeApplied
            // 
            this.IsPenaltyBrakeApplied.DataPropertyName = "IsPenaltyBrakeApplied";
            this.IsPenaltyBrakeApplied.HeaderText = "PENALTY";
            this.IsPenaltyBrakeApplied.MinimumWidth = 6;
            this.IsPenaltyBrakeApplied.Name = "IsPenaltyBrakeApplied";
            this.IsPenaltyBrakeApplied.ReadOnly = true;
            this.IsPenaltyBrakeApplied.Width = 125;
            // 
            // IsMomoryFreezed
            // 
            this.IsMomoryFreezed.DataPropertyName = "IsMomoryFreezed";
            this.IsMomoryFreezed.HeaderText = "MFZ";
            this.IsMomoryFreezed.MinimumWidth = 6;
            this.IsMomoryFreezed.Name = "IsMomoryFreezed";
            this.IsMomoryFreezed.ReadOnly = true;
            this.IsMomoryFreezed.Width = 125;
            // 
            // EventCode
            // 
            this.EventCode.DataPropertyName = "EventCode";
            this.EventCode.HeaderText = "EVT";
            this.EventCode.MinimumWidth = 6;
            this.EventCode.Name = "EventCode";
            this.EventCode.ReadOnly = true;
            this.EventCode.Width = 125;
            // 
            // STGBCL
            // 
            this.STGBCL.DataPropertyName = "STGBCL";
            this.STGBCL.HeaderText = "STGBCL";
            this.STGBCL.MinimumWidth = 6;
            this.STGBCL.Name = "STGBCL";
            this.STGBCL.ReadOnly = true;
            this.STGBCL.Width = 125;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1329, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Event Data Analyser (HHP)";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ImportEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_ReadFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_ReadTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_ImportEvent;
        private System.Windows.Forms.Button Btn_ReadFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_StationKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SheetName;
        private System.Windows.Forms.CheckBox Chk_IsPsi;
        private System.Windows.Forms.CheckBox Chk_IsTheTimeSeperate;
        private System.Windows.Forms.DateTimePicker Dtp_TrainDepTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_StartAddOnKms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COL_START;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COL_STOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Col_StartStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Col_TStn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Col_MPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Col_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Col_CumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceTravelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerKW;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPpressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn BCpressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsGFenabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverserPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThrottlePosition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsHorn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsHLshorthoodBurning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsHLlonghoodBurning;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPCSenabled;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPenaltyBrakeApplied;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMomoryFreezed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn STGBCL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Filepath;
    }
}
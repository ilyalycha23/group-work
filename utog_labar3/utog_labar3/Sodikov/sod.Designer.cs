
namespace utog_labar3.Sodikov
{
    partial class sod
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.comboBoxFirstParam = new System.Windows.Forms.ComboBox();
            this.labelFirstParam = new System.Windows.Forms.Label();
            this.labelSecondParam = new System.Windows.Forms.Label();
            this.comboBoxSecondParam = new System.Windows.Forms.ComboBox();
            this.numericWindowSize = new System.Windows.Forms.NumericUpDown();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.runsDataGridView = new System.Windows.Forms.DataGridView();
            this.runningChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(126, 38);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Загрузить данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(144, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(126, 38);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Анализировать";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // comboBoxFirstParam
            // 
            this.comboBoxFirstParam.FormattingEnabled = true;
            this.comboBoxFirstParam.Items.AddRange(new object[] {
            "Дистанция (км)",
            "Длительность (мин)",
            "Макс. скорость (км/ч)",
            "Мин. скорость (км/ч)",
            "Ср. скорость (км/ч)",
            "Ср. пульс (уд/мин)"});
            this.comboBoxFirstParam.Location = new System.Drawing.Point(293, 29);
            this.comboBoxFirstParam.Name = "comboBoxFirstParam";
            this.comboBoxFirstParam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirstParam.TabIndex = 2;
            this.comboBoxFirstParam.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirstParam_SelectedIndexChanged);
            // 
            // labelFirstParam
            // 
            this.labelFirstParam.AutoSize = true;
            this.labelFirstParam.Location = new System.Drawing.Point(291, 9);
            this.labelFirstParam.Name = "labelFirstParam";
            this.labelFirstParam.Size = new System.Drawing.Size(70, 13);
            this.labelFirstParam.TabIndex = 3;
            this.labelFirstParam.Text = "Параметр 1:";
            // 
            // labelSecondParam
            // 
            this.labelSecondParam.AutoSize = true;
            this.labelSecondParam.Location = new System.Drawing.Point(440, 9);
            this.labelSecondParam.Name = "labelSecondParam";
            this.labelSecondParam.Size = new System.Drawing.Size(70, 13);
            this.labelSecondParam.TabIndex = 5;
            this.labelSecondParam.Text = "Параметр 2:";
            // 
            // comboBoxSecondParam
            // 
            this.comboBoxSecondParam.FormattingEnabled = true;
            this.comboBoxSecondParam.Items.AddRange(new object[] {
            "Дистанция (км)",
            "Длительность (мин)",
            "Макс. скорость (км/ч)",
            "Мин. скорость (км/ч)",
            "Ср. скорость (км/ч)",
            "Ср. пульс (уд/мин)"});
            this.comboBoxSecondParam.Location = new System.Drawing.Point(443, 29);
            this.comboBoxSecondParam.Name = "comboBoxSecondParam";
            this.comboBoxSecondParam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondParam.TabIndex = 4;
            this.comboBoxSecondParam.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondParam_SelectedIndexChanged);
            // 
            // numericWindowSize
            // 
            this.numericWindowSize.Location = new System.Drawing.Point(612, 30);
            this.numericWindowSize.Name = "numericWindowSize";
            this.numericWindowSize.Size = new System.Drawing.Size(32, 20);
            this.numericWindowSize.TabIndex = 6;
            this.numericWindowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Location = new System.Drawing.Point(570, 32);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(36, 13);
            this.labelWindowSize.TabIndex = 7;
            this.labelWindowSize.Text = "Окно:";
            // 
            // runsDataGridView
            // 
            this.runsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.runsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.runsDataGridView.Name = "runsDataGridView";
            this.runsDataGridView.Size = new System.Drawing.Size(884, 200);
            this.runsDataGridView.TabIndex = 8;
            // 
            // runningChart
            // 
            chartArea4.Name = "ChartArea1";
            this.runningChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.runningChart.Legends.Add(legend4);
            this.runningChart.Location = new System.Drawing.Point(12, 262);
            this.runningChart.Name = "runningChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.runningChart.Series.Add(series4);
            this.runningChart.Size = new System.Drawing.Size(884, 401);
            this.runningChart.TabIndex = 9;
            this.runningChart.Text = "chart1";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(12, 666);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(884, 50);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Загрузите данные для анализа";
            // 
            // sod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 723);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.runningChart);
            this.Controls.Add(this.runsDataGridView);
            this.Controls.Add(this.labelWindowSize);
            this.Controls.Add(this.numericWindowSize);
            this.Controls.Add(this.labelSecondParam);
            this.Controls.Add(this.comboBoxSecondParam);
            this.Controls.Add(this.labelFirstParam);
            this.Controls.Add(this.comboBoxFirstParam);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnLoadData);
            this.Name = "sod";
            this.Text = "Анализатор пробежок";
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runningChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ComboBox comboBoxFirstParam;
        private System.Windows.Forms.Label labelFirstParam;
        private System.Windows.Forms.Label labelSecondParam;
        private System.Windows.Forms.ComboBox comboBoxSecondParam;
        private System.Windows.Forms.NumericUpDown numericWindowSize;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.DataGridView runsDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart runningChart;
        private System.Windows.Forms.Label lblResults;
    }
}
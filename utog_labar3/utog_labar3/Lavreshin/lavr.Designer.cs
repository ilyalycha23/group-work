
namespace utog_labar3.Lavreshin
{
    partial class lavr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxApartment = new System.Windows.Forms.ComboBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chartPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridPrices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForecastYears = new System.Windows.Forms.TextBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип квартиры:";
            // 
            // comboBoxApartment
            // 
            this.comboBoxApartment.FormattingEnabled = true;
            this.comboBoxApartment.Items.AddRange(new object[] {
            "1-комн.",
            "2-комн.",
            "3-комн."});
            this.comboBoxApartment.Location = new System.Drawing.Point(150, 9);
            this.comboBoxApartment.Name = "comboBoxApartment";
            this.comboBoxApartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApartment.TabIndex = 1;
            this.comboBoxApartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxApartment_SelectedIndexChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(277, 9);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(123, 21);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Загрузить данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // chartPrices
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPrices.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPrices.Legends.Add(legend2);
            this.chartPrices.Location = new System.Drawing.Point(12, 192);
            this.chartPrices.Name = "chartPrices";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPrices.Series.Add(series2);
            this.chartPrices.Size = new System.Drawing.Size(388, 150);
            this.chartPrices.TabIndex = 3;
            this.chartPrices.Text = "chart1";
            // 
            // dataGridPrices
            // 
            this.dataGridPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrices.Location = new System.Drawing.Point(12, 36);
            this.dataGridPrices.Name = "dataGridPrices";
            this.dataGridPrices.Size = new System.Drawing.Size(388, 150);
            this.dataGridPrices.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите число лет (n):";
            // 
            // txtForecastYears
            // 
            this.txtForecastYears.Location = new System.Drawing.Point(137, 348);
            this.txtForecastYears.Name = "txtForecastYears";
            this.txtForecastYears.Size = new System.Drawing.Size(121, 20);
            this.txtForecastYears.TabIndex = 6;
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(264, 348);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(136, 21);
            this.btnForecast.TabIndex = 7;
            this.btnForecast.Text = "Рассчитать прогноз";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 375);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(82, 13);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "РЕЗУЛЬТАТЫ";
            // 
            // lavr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 443);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.txtForecastYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPrices);
            this.Controls.Add(this.chartPrices);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.comboBoxApartment);
            this.Controls.Add(this.label1);
            this.Name = "lavr";
            this.Text = "lavr";
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxApartment;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrices;
        private System.Windows.Forms.DataGridView dataGridPrices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForecastYears;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label lblResults;
    }
}
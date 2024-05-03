
namespace LAB_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fxchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FX_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.dNumeric = new System.Windows.Forms.NumericUpDown();
            this.mLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fxchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FX_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // fxchart
            // 
            chartArea1.Name = "ChartArea1";
            this.fxchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.fxchart.Legends.Add(legend1);
            this.fxchart.Location = new System.Drawing.Point(326, -2);
            this.fxchart.Name = "fxchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.fxchart.Series.Add(series1);
            this.fxchart.Size = new System.Drawing.Size(764, 322);
            this.fxchart.TabIndex = 0;
            this.fxchart.Text = "chart1";
            // 
            // FX_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.FX_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FX_chart.Legends.Add(legend2);
            this.FX_chart.Location = new System.Drawing.Point(326, 326);
            this.FX_chart.Name = "FX_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FX_chart.Series.Add(series2);
            this.FX_chart.Size = new System.Drawing.Size(764, 343);
            this.FX_chart.TabIndex = 1;
            this.FX_chart.Text = "chart2";
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(48, 195);
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(120, 20);
            this.mNumeric.TabIndex = 2;
            // 
            // dNumeric
            // 
            this.dNumeric.Location = new System.Drawing.Point(48, 252);
            this.dNumeric.Name = "dNumeric";
            this.dNumeric.Size = new System.Drawing.Size(120, 20);
            this.dNumeric.TabIndex = 3;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(48, 169);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(60, 13);
            this.mLabel.TabIndex = 4;
            this.mLabel.Text = "Введите m";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(48, 236);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(58, 13);
            this.dLabel.TabIndex = 5;
            this.dLabel.Text = "Введите d";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.dNumeric);
            this.Controls.Add(this.mNumeric);
            this.Controls.Add(this.FX_chart);
            this.Controls.Add(this.fxchart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fxchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FX_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart fxchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart FX_chart;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


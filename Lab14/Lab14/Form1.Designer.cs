
namespace Lab14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.NumericUpDown();
            this.Variance = new System.Windows.Forms.NumericUpDown();
            this.Sam_size = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.TextBox();
            this.Var = new System.Windows.Forms.TextBox();
            this.Ave_err = new System.Windows.Forms.TextBox();
            this.Var_err = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Variance";
            // 
            // Mean
            // 
            this.Mean.DecimalPlaces = 2;
            this.Mean.Location = new System.Drawing.Point(213, 13);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(120, 26);
            this.Mean.TabIndex = 6;
            this.Mean.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // Variance
            // 
            this.Variance.DecimalPlaces = 2;
            this.Variance.Location = new System.Drawing.Point(213, 52);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(120, 26);
            this.Variance.TabIndex = 7;
            this.Variance.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            // 
            // Sam_size
            // 
            this.Sam_size.Location = new System.Drawing.Point(213, 92);
            this.Sam_size.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Sam_size.Name = "Sam_size";
            this.Sam_size.Size = new System.Drawing.Size(120, 26);
            this.Sam_size.TabIndex = 8;
            this.Sam_size.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(23, 124);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.CornflowerBlue;
            series7.Legend = "Legend1";
            series7.Name = "freq";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.MarkerBorderWidth = 3;
            series8.MarkerColor = System.Drawing.Color.White;
            series8.Name = "distr";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(732, 447);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.SkyBlue;
            this.Start.Location = new System.Drawing.Point(433, 58);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 60);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(822, 16);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(100, 26);
            this.Average.TabIndex = 11;
            // 
            // Var
            // 
            this.Var.Location = new System.Drawing.Point(822, 52);
            this.Var.Name = "Var";
            this.Var.Size = new System.Drawing.Size(100, 26);
            this.Var.TabIndex = 12;
            // 
            // Ave_err
            // 
            this.Ave_err.Location = new System.Drawing.Point(951, 16);
            this.Ave_err.Name = "Ave_err";
            this.Ave_err.Size = new System.Drawing.Size(100, 26);
            this.Ave_err.TabIndex = 14;
            // 
            // Var_err
            // 
            this.Var_err.Location = new System.Drawing.Point(951, 51);
            this.Var_err.Name = "Var_err";
            this.Var_err.Size = new System.Drawing.Size(100, 26);
            this.Var_err.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1118, 570);
            this.Controls.Add(this.Var_err);
            this.Controls.Add(this.Ave_err);
            this.Controls.Add(this.Var);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Sam_size);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Mean;
        private System.Windows.Forms.NumericUpDown Variance;
        private System.Windows.Forms.NumericUpDown Sam_size;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox Var;
        private System.Windows.Forms.TextBox Ave_err;
        private System.Windows.Forms.TextBox Var_err;
    }
}


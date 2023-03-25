
namespace HastaneSistemi.Sekreter
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPoliklinik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoktor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoliklinik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPoliklinik
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPoliklinik.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPoliklinik.Legends.Add(legend3);
            this.chartPoliklinik.Location = new System.Drawing.Point(12, 161);
            this.chartPoliklinik.Name = "chartPoliklinik";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "poliklinik";
            this.chartPoliklinik.Series.Add(series3);
            this.chartPoliklinik.Size = new System.Drawing.Size(487, 373);
            this.chartPoliklinik.TabIndex = 0;
            this.chartPoliklinik.Text = "chart1";
            // 
            // chartDoktor
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDoktor.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDoktor.Legends.Add(legend4);
            this.chartDoktor.Location = new System.Drawing.Point(576, 161);
            this.chartDoktor.Name = "chartDoktor";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "doktor";
            this.chartDoktor.Series.Add(series4);
            this.chartDoktor.Size = new System.Drawing.Size(500, 373);
            this.chartDoktor.TabIndex = 1;
            this.chartDoktor.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Polikinlik Grafigi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(641, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor Grafigi";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDoktor);
            this.Controls.Add(this.chartPoliklinik);
            this.Name = "Grafikler";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPoliklinik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoliklinik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
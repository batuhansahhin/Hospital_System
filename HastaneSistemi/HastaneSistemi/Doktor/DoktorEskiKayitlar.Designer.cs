namespace HastaneSistemi.Doktor
{
    partial class DoktorEskiKayitlar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sorgula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "TcNo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(108, 114);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(135, 26);
            this.txt_tc.TabIndex = 77;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 86;
            this.button1.Text = "Anasayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(720, 335);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sorgula
            // 
            this.sorgula.Location = new System.Drawing.Point(33, 168);
            this.sorgula.Margin = new System.Windows.Forms.Padding(2);
            this.sorgula.Name = "sorgula";
            this.sorgula.Size = new System.Drawing.Size(95, 36);
            this.sorgula.TabIndex = 89;
            this.sorgula.Text = "Sorgula";
            this.sorgula.UseVisualStyleBackColor = true;
            this.sorgula.Click += new System.EventHandler(this.sorgula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 60);
            this.label1.TabIndex = 90;
            this.label1.Text = "Gelen hastaları görüyorsunuz. \r\nTc kimlik aramasıyla hastanızın \r\nkayıtlarını gör" +
    "ebilirsiniz.";
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(150, 168);
            this.yenile.Margin = new System.Windows.Forms.Padding(2);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(95, 36);
            this.yenile.TabIndex = 91;
            this.yenile.Text = "Sorguyu Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // DoktorEskiKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 585);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sorgula);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tc);
            this.Name = "DoktorEskiKayitlar";
            this.Text = "DoktorEskiKayitlar";
            this.Load += new System.EventHandler(this.DoktorEskiKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenile;
    }
}
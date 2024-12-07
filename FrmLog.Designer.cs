namespace DATA_BASED_PARTY_ELECTION_CHART_STATISTICS
{
    partial class FrmLog
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnExıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOCAL ELECTION 2024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOWN_NAME:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(401, 34);
            this.txtName.TabIndex = 2;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLog.Location = new System.Drawing.Point(223, 419);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(410, 63);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "LOG IN VOTE";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(223, 193);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(401, 34);
            this.txtA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "A PARTY:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(223, 233);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(401, 34);
            this.txtB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "B PARTY:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(223, 273);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(401, 34);
            this.txtC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "C PARTY:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(223, 313);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(401, 34);
            this.txtD.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "D PARTY:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(223, 353);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(401, 34);
            this.txtE.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "E PARTY:";
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnChart.Location = new System.Drawing.Point(431, 488);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(202, 63);
            this.btnChart.TabIndex = 14;
            this.btnChart.Text = "CHART";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnExıt
            // 
            this.btnExıt.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnExıt.Location = new System.Drawing.Point(223, 488);
            this.btnExıt.Name = "btnExıt";
            this.btnExıt.Size = new System.Drawing.Size(202, 63);
            this.btnExıt.TabIndex = 15;
            this.btnExıt.Text = "EXIT";
            this.btnExıt.UseVisualStyleBackColor = false;
            this.btnExıt.Click += new System.EventHandler(this.btnExıt_Click);
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(889, 611);
            this.Controls.Add(this.btnExıt);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnExıt;
    }
}


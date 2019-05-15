namespace WinForms_dz_15._05
{
    partial class Redactor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbFamilia = new System.Windows.Forms.TextBox();
            this.txbIma = new System.Windows.Forms.TextBox();
            this.txbOtchestvo = new System.Windows.Forms.TextBox();
            this.txbMestoRoschden = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Место рождения";
            // 
            // txbFamilia
            // 
            this.txbFamilia.Location = new System.Drawing.Point(152, 23);
            this.txbFamilia.Name = "txbFamilia";
            this.txbFamilia.Size = new System.Drawing.Size(200, 20);
            this.txbFamilia.TabIndex = 5;
            // 
            // txbIma
            // 
            this.txbIma.Location = new System.Drawing.Point(152, 69);
            this.txbIma.Name = "txbIma";
            this.txbIma.Size = new System.Drawing.Size(200, 20);
            this.txbIma.TabIndex = 6;
            // 
            // txbOtchestvo
            // 
            this.txbOtchestvo.Location = new System.Drawing.Point(152, 116);
            this.txbOtchestvo.Name = "txbOtchestvo";
            this.txbOtchestvo.Size = new System.Drawing.Size(200, 20);
            this.txbOtchestvo.TabIndex = 7;
            // 
            // txbMestoRoschden
            // 
            this.txbMestoRoschden.Location = new System.Drawing.Point(152, 213);
            this.txbMestoRoschden.Name = "txbMestoRoschden";
            this.txbMestoRoschden.Size = new System.Drawing.Size(200, 20);
            this.txbMestoRoschden.TabIndex = 8;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(152, 165);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(200, 20);
            this.txbData.TabIndex = 9;
            // 
            // Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbMestoRoschden);
            this.Controls.Add(this.txbOtchestvo);
            this.Controls.Add(this.txbIma);
            this.Controls.Add(this.txbFamilia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Redactor";
            this.Text = "Redactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbFamilia;
        public System.Windows.Forms.TextBox txbIma;
        public System.Windows.Forms.TextBox txbOtchestvo;
        public System.Windows.Forms.TextBox txbMestoRoschden;
        public System.Windows.Forms.TextBox txbData;
    }
}
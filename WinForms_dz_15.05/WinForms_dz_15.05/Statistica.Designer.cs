namespace WinForms_dz_15._05
{
    partial class Statistica
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
            this.txbMolodoj = new System.Windows.Forms.TextBox();
            this.txbStarij = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbZima = new System.Windows.Forms.RadioButton();
            this.rdbVesna = new System.Windows.Forms.RadioButton();
            this.rdbLeto = new System.Windows.Forms.RadioButton();
            this.rdbOsen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Самый молодой";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Самый старый";
            // 
            // txbMolodoj
            // 
            this.txbMolodoj.Location = new System.Drawing.Point(119, 10);
            this.txbMolodoj.Name = "txbMolodoj";
            this.txbMolodoj.ReadOnly = true;
            this.txbMolodoj.Size = new System.Drawing.Size(259, 20);
            this.txbMolodoj.TabIndex = 2;
            // 
            // txbStarij
            // 
            this.txbStarij.Location = new System.Drawing.Point(119, 56);
            this.txbStarij.Name = "txbStarij";
            this.txbStarij.ReadOnly = true;
            this.txbStarij.Size = new System.Drawing.Size(259, 20);
            this.txbStarij.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(107, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 212);
            this.listBox1.TabIndex = 4;
            // 
            // rdbZima
            // 
            this.rdbZima.AutoSize = true;
            this.rdbZima.Location = new System.Drawing.Point(16, 134);
            this.rdbZima.Name = "rdbZima";
            this.rdbZima.Size = new System.Drawing.Size(52, 17);
            this.rdbZima.TabIndex = 5;
            this.rdbZima.TabStop = true;
            this.rdbZima.Text = "Зима";
            this.rdbZima.UseVisualStyleBackColor = true;
            this.rdbZima.CheckedChanged += new System.EventHandler(this.rdbZima_CheckedChanged);
            // 
            // rdbVesna
            // 
            this.rdbVesna.AutoSize = true;
            this.rdbVesna.Location = new System.Drawing.Point(16, 171);
            this.rdbVesna.Name = "rdbVesna";
            this.rdbVesna.Size = new System.Drawing.Size(56, 17);
            this.rdbVesna.TabIndex = 6;
            this.rdbVesna.TabStop = true;
            this.rdbVesna.Text = "Весна";
            this.rdbVesna.UseVisualStyleBackColor = true;
            this.rdbVesna.CheckedChanged += new System.EventHandler(this.rdbVesna_CheckedChanged);
            // 
            // rdbLeto
            // 
            this.rdbLeto.AutoSize = true;
            this.rdbLeto.Location = new System.Drawing.Point(16, 206);
            this.rdbLeto.Name = "rdbLeto";
            this.rdbLeto.Size = new System.Drawing.Size(50, 17);
            this.rdbLeto.TabIndex = 7;
            this.rdbLeto.TabStop = true;
            this.rdbLeto.Text = "Лето";
            this.rdbLeto.UseVisualStyleBackColor = true;
            this.rdbLeto.CheckedChanged += new System.EventHandler(this.rdbLeto_CheckedChanged);
            // 
            // rdbOsen
            // 
            this.rdbOsen.AutoSize = true;
            this.rdbOsen.Location = new System.Drawing.Point(16, 245);
            this.rdbOsen.Name = "rdbOsen";
            this.rdbOsen.Size = new System.Drawing.Size(57, 17);
            this.rdbOsen.TabIndex = 8;
            this.rdbOsen.TabStop = true;
            this.rdbOsen.Text = "Осень";
            this.rdbOsen.UseVisualStyleBackColor = true;
            this.rdbOsen.CheckedChanged += new System.EventHandler(this.rdbOsen_CheckedChanged);
            // 
            // Statistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.rdbOsen);
            this.Controls.Add(this.rdbLeto);
            this.Controls.Add(this.rdbVesna);
            this.Controls.Add(this.rdbZima);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txbStarij);
            this.Controls.Add(this.txbMolodoj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistica";
            this.Text = "Statistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMolodoj;
        private System.Windows.Forms.TextBox txbStarij;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdbZima;
        private System.Windows.Forms.RadioButton rdbVesna;
        private System.Windows.Forms.RadioButton rdbLeto;
        private System.Windows.Forms.RadioButton rdbOsen;
    }
}
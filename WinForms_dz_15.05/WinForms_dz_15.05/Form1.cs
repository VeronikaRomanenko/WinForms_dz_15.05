using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz_15._05
{
    public partial class Form1 : Form
    {
        private List<string> workers;
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            workers = new List<string>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Redactor form = new Redactor(dialog.FileName);
                    form.MdiParent = this;
                    form.Show();
                    workers.Remove(form.FileName);
                    workers.Add(form.FileName);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redactor form = new Redactor();
            form.MdiParent = this;
            form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Redactor form = this.ActiveMdiChild as Redactor;
                string[] tmp = new string[5];
                tmp[0] = form.txbFamilia.Text;
                tmp[1] = form.txbIma.Text;
                tmp[2] = form.txbOtchestvo.Text;
                tmp[3] = form.dateTimePicker1.Text;
                tmp[4] = form.txbMestoRoschden.Text;
                if (form.FileName == null)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        form.FileName = dialog.FileName;
                        workers.Add(form.FileName);
                    }
                }
                File.WriteAllLines(form.FileName, tmp);
            }
            catch (Exception ex)
            {

            }
        }

        private void pokazatSpisokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisok form = new Spisok(workers);
            form.MdiParent = this;
            form.Show();
        }

        private void statisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistica form = new Statistica(workers);
            form.MdiParent = this;
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete((this.ActiveMdiChild as Redactor).FileName);
                this.ActiveMdiChild.Close();
                workers.Remove((this.ActiveMdiChild as Redactor).FileName);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
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
    public partial class Redactor : Form
    {
        public string FileName { set; get; }
        public Redactor()
        {
            InitializeComponent();
        }

        public Redactor(string fileName)
        {
            try
            {
                InitializeComponent();
                FileName = fileName;
                string[] tmp = File.ReadAllLines(FileName);
                txbFamilia.Text = tmp[0];
                txbIma.Text = tmp[1];
                txbOtchestvo.Text = tmp[2];
                dateTimePicker1.Text = tmp[3];
                txbMestoRoschden.Text = tmp[4];
                txbDataSozdania.Text = DateTime.Now.ToLongDateString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            txbFamilia.AllowDrop = true;
            txbIma.AllowDrop = true;
            txbOtchestvo.AllowDrop = true;
            txbMestoRoschden.AllowDrop = true;
        }

        private void txbFamilia_MouseDown(object sender, MouseEventArgs e)
        {
            txbFamilia.DoDragDrop(txbFamilia.Text, DragDropEffects.Copy);
        }

        private void txbIma_MouseDown(object sender, MouseEventArgs e)
        {
            txbIma.DoDragDrop(txbIma.Text, DragDropEffects.Copy);
        }

        private void txbOtchestvo_MouseDown(object sender, MouseEventArgs e)
        {
            txbOtchestvo.DoDragDrop(txbOtchestvo.Text, DragDropEffects.Copy);
        }

        private void txbMestoRoschden_MouseDown(object sender, MouseEventArgs e)
        {
            txbMestoRoschden.DoDragDrop(txbMestoRoschden.Text, DragDropEffects.Copy);
        }

        private void txbFamilia_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txbIma_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txbOtchestvo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txbMestoRoschden_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txbFamilia_DragDrop(object sender, DragEventArgs e)
        {
            txbFamilia.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        }

        private void txbIma_DragDrop(object sender, DragEventArgs e)
        {
            txbIma.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        }

        private void txbOtchestvo_DragDrop(object sender, DragEventArgs e)
        {
            txbOtchestvo.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        }

        private void txbMestoRoschden_DragDrop(object sender, DragEventArgs e)
        {
            txbMestoRoschden.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        }
    }
}
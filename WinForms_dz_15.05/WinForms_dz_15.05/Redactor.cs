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
                txbData.Text = tmp[3];
                txbMestoRoschden.Text = tmp[4];
            }
            catch (Exception ex)
            {

            }
        }
    }
}
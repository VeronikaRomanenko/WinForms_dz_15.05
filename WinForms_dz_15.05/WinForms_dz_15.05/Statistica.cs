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
    public partial class Statistica : Form
    {
        List<DateTime> dates;
        List<string> workers_FIO;
        public Statistica(List<string> workers)
        {
            try
            {
                InitializeComponent();
                dates = new List<DateTime>();
                workers_FIO = new List<string>();
                string[] tmp;
                for (int i = 0; i < workers.Count; i++)
                {
                    tmp = File.ReadAllLines(workers[i]);
                    workers_FIO.Add(tmp[0] + " " + tmp[1] + " " + tmp[2]);
                    dates.Add(DateTime.Parse(tmp[3]));
                }
                int i_molodoj = 0;
                int i_starij = 0;
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i] > dates[i_molodoj])
                    {
                        i_molodoj = i;
                    }
                    if (dates[i] < dates[i_starij])
                    {
                        i_starij = i;
                    }
                }
                txbMolodoj.Text = workers_FIO[i_molodoj];
                txbStarij.Text = workers_FIO[i_starij];
            }
            catch (Exception ex)
            {

            }
        }

        private void rdbZima_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbZima.Checked == true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i].Month == 1 || dates[i].Month == 2 || dates[i].Month == 12)
                    {
                        listBox1.Items.Add(workers_FIO[i]);
                    }
                }
            }
        }

        private void rdbVesna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVesna.Checked == true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i].Month == 3 || dates[i].Month == 4 || dates[i].Month == 5)
                    {
                        listBox1.Items.Add(workers_FIO[i]);
                    }
                }
            }
        }

        private void rdbLeto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLeto.Checked == true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i].Month == 6 || dates[i].Month == 7 || dates[i].Month == 8)
                    {
                        listBox1.Items.Add(workers_FIO[i]);
                    }
                }
            }
        }

        private void rdbOsen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOsen.Checked == true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dates.Count; i++)
                {
                    if (dates[i].Month == 9 || dates[i].Month == 10 || dates[i].Month == 11)
                    {
                        listBox1.Items.Add(workers_FIO[i]);
                    }
                }
            }
        }
    }
}
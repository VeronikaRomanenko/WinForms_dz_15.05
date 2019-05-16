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
    public partial class Spisok : Form
    {
        public Spisok()
        {
            InitializeComponent();
            listBox1.Size = this.ClientSize;
        }

        public Spisok(List<string> listWorkers)
        {
            InitializeComponent();
            try
            {
                foreach (string item in listWorkers)
                {
                    string[] tmp = File.ReadAllLines(item);
                    listBox1.Items.Add(tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4]);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Spisok_ClientSizeChanged(object sender, EventArgs e)
        {
            listBox1.Size = this.ClientSize;
        }
    }
}

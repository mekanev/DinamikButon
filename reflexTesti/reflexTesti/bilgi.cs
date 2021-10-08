using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reflexTesti
{
    public partial class bilgi : Form
    {
        public bilgi()
        {
            InitializeComponent();
        }
        oyunEkrani oyun = new oyunEkrani();
        private void button1_Click(object sender, EventArgs e)
        {
            oyun.Show();
            this.Close();
        }
    }
}

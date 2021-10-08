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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        oyunEkrani oyun = new oyunEkrani();
       public Label lblPuan = new Label();
        public Label lblZaman = new Label();
        private void Form1_Click(object sender, EventArgs e)
        {
            oyun.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPuan.Visible = true;
            if (lblPuan.Text == "")
            {
                lblPuan.Visible = false;
            }
            lblPuan.Location = new Point(265, 110);
            this.Controls.Add(lblPuan);
            lblZaman.Visible = true;
            
            if (lblZaman.Text == "")
            {
                lblZaman.Visible = false;
            }
            lblZaman.Location = new Point(265, 140);
            this.Controls.Add(lblZaman);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgi info = new bilgi();
            info.Show();
            this.Hide();
        }
    }
}

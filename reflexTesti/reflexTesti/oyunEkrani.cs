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
    public partial class oyunEkrani : Form
    {
        public oyunEkrani()
        {
            InitializeComponent();
        }
        int puan = 0;
        Button btn = new Button();
        int sayac = 0;
        int hak = 5;
       
        private void oyunEkrani_Load(object sender, EventArgs e)
        {
            btn.Text = "";
            btn.Enabled = true;
            btn.Location = new Point(610, 300);
            btn.Width = 30;
            btn.Height = 25;
            this.Controls.Add(btn);
            btn.Click += btn_Click;
          
        }
        public void btn_Click (object sender,EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            int y = rnd.Next(0, 100);
            btn.Location = new Point(x, y);
            btn.Width = 30;
            btn.Height = 25;
            this.Controls.Add(btn);
            puan++;
            label1.Text = puan.ToString();
            timer1.Start();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void oyunEkrani_Click(object sender, EventArgs e)
        {
            hak--;
            label4.Text = hak.ToString();
            if (hak==0)
            {
                timer1.Stop();
                Form1 ana = new Form1();
                ana.lblPuan.Text = label1.Text;
                ana.lblSkor.Visible = true;
                ana.lblSure.Visible = true;
                ana.lblZaman.Text = label2.Text;
                ana.label1.Text = "Oyun Bitti,Tekrar Denemek İçin Tıkla";
                ana.Show();
                this.Hide();
            }
        }
    }
}

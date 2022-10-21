using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.Models;

namespace AracKiralama
{
    public partial class Form1 : Form
    {
        AracSQLEntities db = new AracSQLEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitBilgileri Durum = db.KayitBilgileri.FirstOrDefault(x => x.kullaniciadi == textBox1.Text && x.sifre == textBox2.Text);
            if (Durum != null)
            {
                girisonay gb = new girisonay();
                gb.ShowDialog();
            }
            else
            {
                girisbasarisiz gb = new girisbasarisiz();
                gb.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifredegistirme sd = new sifredegistirme();
            sd.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayit k = new kayit();
            k.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




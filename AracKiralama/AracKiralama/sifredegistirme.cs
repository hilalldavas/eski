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
    public partial class sifredegistirme : Form
    {
        AracSQLEntities db = new AracSQLEntities();
        
        public sifredegistirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        MailGonderme mg = new MailGonderme();
        private void button2_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox1.Text);
            MessageBox.Show("Bilgiler eşleşirse şifreniz yenilenecek.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void sifredegistirme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void sifredegistirme_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void sifredegistirme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void sifredegistirme_Load(object sender, EventArgs e)
        {

        }
    }
}


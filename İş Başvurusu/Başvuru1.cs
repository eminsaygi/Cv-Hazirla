using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İş_Başvurusu
{
    public partial class Başvuru1 : Form
    {
        public Başvuru1()
        {
            InitializeComponent();
        }

        private void iTalk_Label1_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_TextBox_Small1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void iTalk_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iTalk_ComboBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                combo1.Items.Add(i);
            }
        }

        private void iTalk_ComboBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                combo2.Items.Add(i);
            }
        }

        private void iTalk_ComboBox3_Click(object sender, EventArgs e)
        {
            for (int i = 1950; i < 2017; i++)
            {
                combo3.Items.Add(i);
            }
        }

        private void iTalk_ComboBox4_Click(object sender, EventArgs e)
        {
            combo4.Items.Add("Bay");
            combo4.Items.Add("Bayan");
        }

        private void iTalk_ComboBox5_Click(object sender, EventArgs e)
        {
            combo5.Items.Add("Türkiye");
            combo5.Items.Add("Diğer");
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" && combo1.Text == "" && combo2.Text == "" && combo3.Text == "" && combo4.Text == "" && combo5.Text == "")
            {
                MessageBox.Show("Zorunlu Kısımları Doldurunuz.");

            }
            else
            {

                MessageBox.Show("En Kısa Zamanda İletişime Geçicez.Bizi Tercih Ettiğiniz İçin Teşekkürler");
                Application.Exit();
                this.Hide();
            }

        }

        private void iTalk_ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

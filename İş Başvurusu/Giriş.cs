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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        Başvuru1 f2 = new Başvuru1();
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }
    }
}

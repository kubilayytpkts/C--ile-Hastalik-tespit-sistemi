using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Hastalık_Semptomları_tespit : Form
    {
        public Hastalık_Semptomları_tespit()
        {
            InitializeComponent();
            semptomekleme();
        }

        private void Hastalık_Semptomları_tespit_Load(object sender, EventArgs e)
        {

        }
        private void semptomekleme()
        {
            foreach (var item in KullanıcıSanaldatabase.BelirtilerDB)
            {
                chekboxsemptomlar.Items.Add(item);
            }
        }

        public void chekboxsemptomlar_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        






        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         

        }
    }
}

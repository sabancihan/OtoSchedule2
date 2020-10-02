using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleLibrary;

namespace ScheduleForm
{
    public partial class donemSec : Form
    {
        public donemSec()
        {
            InitializeComponent();
        }

        private void dersSecLabel_Click(object sender, EventArgs e)
        {

        }

        private void donemKoduTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void donemSec_Load(object sender, EventArgs e)
        {

        }

        private async void kontrolButton_Click(object sender, EventArgs e)
        {
            string donemKodu = donemKoduTextBox.Text;

            bool kontrol = await BilgiAlmaLogic.donemKontrol(donemKodu);

            if(kontrol)
            {
                this.Hide();
                var program = new ProgramOlustur(donemKodu);
                program.Closed += (s, args) => this.Close();
                program.Show();
            }   
            else
                MessageBox.Show("Bu Donem Gecerli degil veya daha yüklenmemis");




        }
    }
}

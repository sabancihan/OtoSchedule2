

using ScheduleForm.Interfaces;
using ScheduleLibrary.models;
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
    public partial class DersOlustur : Form
    {
        ProgramModel dersProgrami;
        IFormBaglayici callerForm;
        private string donemKodu;

        public DersOlustur(ProgramModel model, IFormBaglayici caller,string donem)
        {
            InitializeComponent();

            dersProgrami = model;

            callerForm = caller;

            donemKodu = donem;

            suankiDerslerListBox.DisplayMember = "TamDersAdi";



            ListeleriYenile();
        }
        public void ListeleriYenile()
        {

            suankiDerslerListBox.DataSource = null;
            suankiDerslerListBox.DataSource = dersProgrami.dersler;

            suankiDerslerListBox.DisplayMember = null;
            suankiDerslerListBox.DisplayMember = nameof(DersModeli.TamDersAdi);



        }



        private async void dersEkleButton_Click(object sender, EventArgs e)
        {

            string mesaj = await BilgiAlmaLogic.DersEkle(dersProgrami, dersAdıTextBox.Text.ToUpper(), dersKoduTextBox.Text.ToUpper(),donemKodu);
            if (mesaj != "")
            {
                MessageBox.Show(mesaj);
                return;
            }
            ListeleriYenile();
            callerForm.dersEkleComplete();
            callerForm.DersBirlestir(dersProgrami.dersler);

        }

        private void DersOlustur_Load(object sender, EventArgs e)
        {

        }

        private void suankiDerslerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

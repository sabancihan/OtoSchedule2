
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ScheduleForm.Interfaces;
using ScheduleLibrary.models;
using ScheduleLibrary;

namespace ScheduleForm
{
    public partial class ProgramOlustur : Form, IFormBaglayici
    {
        private List<List<ZamanModel>> butunZamanlar = new List<List<ZamanModel>>();
        private ProgramModel program;
        private BindingList<SecilmemisDersModel> secilmemisDersler;
        private List<SecilmemisDersModel> sabitders = new List<SecilmemisDersModel>();
        private bool kontrol = true;
        private string donemKodu = "";

        int programCounter;


        List<SectionModel> secilenSectionlar = new List<SectionModel>();
        List<SecilmemisDersModel> NotSelected = new List<SecilmemisDersModel>();
        List<SecilmemisDersModel> Selected = new List<SecilmemisDersModel>();
        List<List<ZamanModel>> AllTime = new List<List<ZamanModel>>();
        List<SectionModel> eskideneme = new List<SectionModel>();
        List<Label> labellar = new List<Label>();






        public ProgramOlustur(string donem)
        {
            InitializeComponent();
            program = new ProgramModel();
            programCounter = 0;
            devamButton.Hide();
            secilmemisDersler = new BindingList<SecilmemisDersModel>();

            donemKodu = donem;
            ListeleriYenile();





        }

            
        private void ListeleriYenile()
        {
            DersSecYenile();
            SectionSecYenile();



        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dersEkleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DersOlustur frm = new DersOlustur(program, this,donemKodu);
            frm.Show();
        }
        public void dersEkleComplete()
        {
            ListeleriYenile();
        }

        private void DersSecDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DersSecDropDown.SelectedItem != null)
            {
                SectionSecYenile();

            }
        }

        private void DersSecYenile()
        {


            BindingList<SecilmemisDersModel> secilmemis = new BindingList<SecilmemisDersModel>(secilmemisDersler.Where(x => x.dersDurumu).ToList());




            secilmemisDerslerListBox.DataSource = secilmemis;
            secilmemisDerslerListBox.DisplayMember = nameof(SecilmemisDersModel.TamDersAdi);





            List<SecilmemisDersModel> imkanlılar = secilmemisDersler.Where(x => x.dersDurumu && x.imkanli).ToList();



            if (!imkanlılar.Equals(new BindingList<SecilmemisDersModel>(imkanlılar)))
            {
                BindingList<SecilmemisDersModel> imkanlı = new BindingList<SecilmemisDersModel>(imkanlılar);
                DersSecDropDown.DataSource = imkanlı;
                DersSecDropDown.DisplayMember = nameof(SecilmemisDersModel.TamDersAdi);

            }




            if (imkanlılar.Count < 1)
            {
                DersSecDropDown.Text = "";

            }






        }
        private void SectionSecYenile()
        {
            List<SectionModel> sectionlar = new List<SectionModel>();

            if (DersSecDropDown.SelectedItem != null)
            {
                sectionlar = ((SecilmemisDersModel)DersSecDropDown.SelectedItem).dersBilgisi.Sectionlar.Where(x => x.imkanli).ToList();
            }

            sectionSecDropDown.DataSource = new BindingList<SectionModel>(sectionlar);
            sectionSecDropDown.DisplayMember = nameof(SectionModel.SectionAdı);




            if (sectionlar.Count < 1)
            {
                sectionSecDropDown.Text = "";
            }


        }

        public void DersBirlestir(List<DersModeli> model)
        {
            foreach (DersModeli ders in model)
            {
                if (!secilmemisDersler.Any(x => x.dersBilgisi.TamDersAdi == ders.TamDersAdi))
                {
                    SecilmemisDersModel secilmemis = new SecilmemisDersModel();
                    secilmemis.dersBilgisi = ders;
                    secilmemisDersler.Add(secilmemis);
                }
            }
            ListeleriYenile();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {

            SecilmemisDersModel secilenDers = (SecilmemisDersModel)DersSecDropDown.SelectedItem;
            SectionModel secilenSection = (SectionModel)sectionSecDropDown.SelectedItem;


            Ekle(secilenDers, secilenSection);



            ListeleriYenile();

        }



        private void Ekle(SecilmemisDersModel secilenDers, SectionModel secilenSection)
        {
            if (secilenDers != null)
            {
                secilenDers.dersDurumu = false;

                tableLayoutPanel1.SuspendLayout();

                List<ZamanModel> zamanlar = new List<ZamanModel>();

                foreach (ZamanModel saat in secilenSection.SectionSaatleri)
                {
                    zamanlar.Add(saat);

                    for (int i = 0; i < saat.süre; i++)
                    {
                        tableLayoutPanel1.Controls.Add(new Label { Text = $"{secilenSection.SectionAdı}", Font = new Font("Microsoft Sans Serif", 12), Size = tableLayoutPanel1.Size, TextAlign = ContentAlignment.MiddleCenter }, saat.gün, saat.baslangicsaati + i);


                    }
                }

                butunZamanlar.Add(zamanlar);
                sabitders.Add(secilenDers);

                if (secilmemisDersler.Where(x => x.dersDurumu && x.imkanli).ToList().Count < 1)
                {
                    kaldır();
                }




                tableLayoutPanel1.ResumeLayout();




                BilgiAlmaLogic.TamKontrol(secilmemisDersler.Where(x => x.dersDurumu == true).ToList(), butunZamanlar.SelectMany(x => x).ToList());

            }
        }


        private void ders1Label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void olusturButton_Click(object sender, EventArgs e)
        {

            if (secilenSectionlar.Count < 1 && secilmemisDersler.Count < 1)
            {
                MessageBox.Show("Lütfen Ders ekleyiniz!");
                return;
            }


            foreach (List<ZamanModel> zamanlar in butunZamanlar)
            {
                AllTime.Add(zamanlar);
            }



            if (BilgiAlmaLogic.ProgramYapma(secilmemisDersler, ref secilenSectionlar, ref NotSelected, ref Selected, ref AllTime))
            {
                programCounter = 1;
                programCountLabel.Text = $"Program : {programCounter}";



                tableEkle();

                kaldır();

                kontrol = false;


                foreach (SecilmemisDersModel ders in secilmemisDersler)
                {

                    if(!sabitders.Any(x => x == ders))
                    {
                        ders.dersDurumu = false;

                    }


                }


                olusturButton.Hide();
                devamButton.Show();
                ListeleriYenile();
            }

            else
            {
                MessageBox.Show("Imkansiz");
                secilenSectionlar = new List<SectionModel>();

            }








        }

        private void tableEkle()
        {
            tableEkle(Color.Black, secilenSectionlar, false);
        }

        private void tableEkle(Color color, List<SectionModel> secilenSectionlar, bool kaydet)
        {
            tableLayoutPanel1.SuspendLayout();
            foreach (SectionModel Section in secilenSectionlar)
            {
                foreach (ZamanModel saat in Section.SectionSaatleri)
                {
                    for (int a = 0; a < saat.süre; a++)
                    {
                        Label label = new Label
                        {
                            Text = $"{Section.SectionAdı}",
                            Font = new Font("Microsoft Sans Serif", 12)
                            ,
                            ForeColor = color,
                            Size = tableLayoutPanel1.Size,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        if (kaydet)
                        {
                            labellar.Add(label);
                        }


                        tableLayoutPanel1.Controls.Add(label, saat.gün, saat.baslangicsaati + a);


                    }


                }
            }
            tableLayoutPanel1.ResumeLayout();
        }




        private void temizleButton_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void temizle()
        {
            temizleTable();
            temizleDiger();

        }

        private void temizleDiger()
        {
            if (secilenSectionlar != null)
            {

                secilenSectionlar.Clear();
                AllTime.Clear();

                foreach (SecilmemisDersModel ders in secilmemisDersler)
                {

                    if(!sabitders.Any(x => x == ders))
                    {   
                        ders.order = 0;
                        ders.imkanli = true;
                        foreach (SectionModel section in ders.dersBilgisi.Sectionlar)
                        {
                            section.imkanli = true;
                        }
                    }

                }

                Selected.Clear();

                NotSelected.Clear();

                devamButton.Hide();
                olusturButton.Show();


                programCounter = 0;

                kontrol = true;

                foreach (SecilmemisDersModel ders in secilmemisDersler)
                {
                    if (!sabitders.Any(x => x == ders))
                    {
                        ders.dersDurumu = true;
                    }
                }


                programCountLabel.Text = $"Program : {programCounter}";


                ListeleriYenile();

            }
        }

        private void temizleTable()
        {
            kaldır();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.Visible = false;

            int count = tableLayoutPanel1.Controls.Count;
            int zamancount = 0;

            foreach (ZamanModel zaman in butunZamanlar.SelectMany(x => x).ToList())
            {
                zamancount += zaman.süre;
            }


            while (count > 16 + zamancount)
            {
                tableLayoutPanel1.Controls.RemoveAt(count - 1);
                count -= 1;
            }
            tableLayoutPanel1.ResumeLayout();
            tableLayoutPanel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SecilmemisDersModel ders = (SecilmemisDersModel)secilmemisDerslerListBox.SelectedItem;
            if (ders != null)
            {

                if (ders.dersBilgisi.connected.Count > 0)
                {
                    foreach (DersModeli ders1 in ders.dersBilgisi.connected)
                    {
                        secilmemisDersler.Remove(secilmemisDersler.Where(x => x.dersBilgisi.connected.Contains(ders.dersBilgisi)).First());
                        program.dersler.Remove(ders1);
                    }
                }

            }
            else
            {
                MessageBox.Show("Olmayan dersi silmeye calisiyorsunuz");
                return;

            }



            SecilmemisDersModel secilmis = (SecilmemisDersModel)secilmemisDerslerListBox.SelectedItem;
            int index;

            foreach (DersModeli birlesikDers in secilmis.dersBilgisi.connected)
            {
                foreach (SecilmemisDersModel sabit in sabitders)
                {
                    if (sabit.dersBilgisi == birlesikDers)
                    {
                        index = sabitders.IndexOf(sabit);
                        sabitders.Remove(sabit);
                        butunZamanlar.RemoveAt(index);
                        break;
                    }
                }
            }

            if (sabitders.Any(x => x == secilmis))
            {
                index = sabitders.IndexOf(secilmis);
                sabitders.Remove(secilmis);
                butunZamanlar.RemoveAt(index);
            }





            temizle();

            secilmemisDersler.Remove(ders);
            program.dersler.Remove(ders.dersBilgisi);



            ListeleriYenile();
        }

        private void geriAlButton_Click(object sender, EventArgs e)
        {


            if (sabitders.Count < 1)
            {
                MessageBox.Show("Daha fazla geriye gidemezsiniz");
                return;
            }
            sabitders.Last().dersDurumu = true;

            sabitders.RemoveAt(butunZamanlar.Count - 1);
            butunZamanlar.RemoveAt(butunZamanlar.Count - 1);
            temizle();

            BilgiAlmaLogic.TamKontrol(secilmemisDersler.Where(x => x.dersDurumu == true).ToList(), butunZamanlar.SelectMany(x => x).ToList());



            ListeleriYenile();


        }

        private void devamButton_Click(object sender, EventArgs e)
        {


            temizleTable();

            secilenSectionlar.RemoveAt(secilenSectionlar.Count - 1);


            if (BilgiAlmaLogic.ProgramYapma(secilmemisDersler, ref secilenSectionlar, ref NotSelected, ref Selected, ref AllTime))
            {
                programCounter += 1;
                tableEkle();
            }
            else
            {
                MessageBox.Show("Baska imkanlı program yoktur");
                temizle();
                return;
            }
            programCountLabel.Text = $"Program : {programCounter}";


        }

        private void sectionSecDropDown_SelectedValueChanged(object sender, EventArgs e)
        {

            if (kontrol)
            {


                if (sectionSecDropDown.SelectedItem != null)
                {
                    List<SectionModel> deneme = new List<SectionModel>();
                    deneme.Add((SectionModel)sectionSecDropDown.SelectedItem);

                    if (deneme == null)
                    {
                        return;
                    }


                    if (eskideneme.Count > 0)
                    {
                        if (!eskideneme.First().SectionAdı.Equals(deneme.First().SectionAdı) && !(eskideneme.Count < 1))
                        {
                            {
                                kaldır();

                                tableEkle(Color.Green, deneme, true);

                            }
                        }
                    }
                    eskideneme = deneme;

                }



            }
        }

        private void kaldır()
        {
            foreach (Label label in labellar)
            {
                tableLayoutPanel1.Controls.Remove(label);
            }   
            labellar = new List<Label>();
        }
    }
}








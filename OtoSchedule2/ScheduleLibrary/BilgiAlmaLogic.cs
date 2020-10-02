using ScheduleLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.ComponentModel;

namespace ScheduleLibrary
{
    public static class BilgiAlmaLogic
    {
        private static readonly HtmlWeb web = new HtmlAgilityPack.HtmlWeb();

        private static readonly string baseString = "/html/body/div[3]/table[1]";

        private static int counterTime;
         
        private static HtmlDocument icerik;
        public static async Task<string> DersEkle(ProgramModel model, string dersAdi, string dersKodu,string donemKodu)
        {
                

            string mesaj = "";
            List<DersModeli> kontrolDersler = await dersKontrol(dersAdi, dersKodu,donemKodu);


            if (model.dersler == null)
            {
                model.dersler = new List<DersModeli>();
            }
            if (kontrolDersler.Count > 0)
            {
                foreach (DersModeli kontrolDers in kontrolDersler)
                {
                    if (model.dersler.Any(x => x.TamDersAdi == kontrolDers.TamDersAdi))
                    {
                        mesaj = "Aynı Dersi eklemeye calisiyorsunuz!";
                        return mesaj;
                    }
                    kontrolDers.Sectionlar = new BindingList<SectionModel>();
                    kontrolDers.connected = new List<DersModeli>();
                    if (kontrolDersler.Count > 1)
                    {

                        kontrolDers.connected = kontrolDersler.Where(x => x != kontrolDers).ToList();

                    }

                    else
                    {
                        kontrolDers.connected = new List<DersModeli>();
                    }

                }
                
                
                sectionEkle(kontrolDersler);




                foreach (DersModeli kontrolDers in kontrolDersler)
                {
                    model.dersler.Add(kontrolDers);
                }
            }


            else
            {
                mesaj = "Eklemeye calistiginiz dersi bulamadık, Yanlis yazmıs olabilir misiniz?";
            }



            
            return mesaj;
        }

        private static void sectionEkle(List<DersModeli> kontrolluDersler)
        {

            int begincounter = 2;
            int counter = 2;


            foreach (DersModeli kontrolluDers in kontrolluDersler)
            {
        







                while (true)
                {
                    
                    

                    var sectionAdi = icerik.DocumentNode.SelectNodes(baseString + $"/tr[{counter - 1}]/th/a");


                    if (sectionAdi == null)
                    {
                        break;
                    }

                    SectionModel yeniSection = new SectionModel();

                    string sectionAdiNormal = sectionAdi.First().InnerText;

                    string sectionAdiString = Regex.Match(sectionAdiNormal, $"- {kontrolluDers.TamDersAdi}.*").Value;

                    string OzelAd = Regex.Match(sectionAdiString, $"{kontrolluDers.TamDersAdi}\\s").Value;

                    if(OzelAd.Length < 1)
                    {
                        
                        break;
                    }


                    yeniSection.SectionAdı = sectionAdiString;

                    kontrolluDers.Sectionlar.Add(yeniSection);
                    counter += 2;
                }





                ZamanEkle(kontrolluDers, icerik,begincounter);

                begincounter = counter;
                kontrolluDers.Sectionlar = new BindingList<SectionModel>(kontrolluDers.Sectionlar.GroupBy(x => grupla(x.SectionSaatleri)).Select(y => y.First()).ToList());


            }

        }
        private static string grupla(List<ZamanModel> zamanlar)
        {
            string grupPattern = "";

            foreach (ZamanModel zaman in zamanlar)
            {
                grupPattern += $"{zaman.gün},{zaman.baslangicsaati},{zaman.süre},";
            }
            return grupPattern;


        }

        private static void ZamanEkle(DersModeli kontrolluDersler, HtmlDocument icerik,int sectionCounter)
        {

            foreach (SectionModel section in kontrolluDersler.Sectionlar)
            {
                string sectionExtensionString = $"/tr[{sectionCounter}]/td[1]/table";

                int saatCounter = 2;

                section.SectionSaatleri = new List<ZamanModel>();

                while (true)
                {
                    string saatExtensionString = $"/tr[{saatCounter}]";

                    StringBuilder body = new StringBuilder();
                    body.Append(baseString);
                    body.Append(sectionExtensionString);
                    body.Append(saatExtensionString);

                    string fullString = body.ToString();

                    var saat = icerik.DocumentNode.SelectNodes($"{fullString}/td[2]");
                    var gun = icerik.DocumentNode.SelectNodes($"{fullString}/td[3]");

                    if (gun == null || saat == null)
                    {
                        break;
                    }

                    string gunString = gun.First().InnerText;
                    string saatString = saat.First().InnerText;

                    stringiZamanModelYap(gunString, saatString, section);

                    saatCounter += 1;
                }
                sectionCounter += 2;

            }
        }

        private static void stringiZamanModelYap(string gunString, string saatString, SectionModel secilmisSection)
        {
            ZamanModel zaman = new ZamanModel();

            int gunInt;

            switch (gunString)
            {
                case "M":
                    gunInt = 1;
                    break;
                case "T":
                    gunInt = 2;
                    break;
                case "W":
                    gunInt = 3;
                    break;
                case "R":
                    gunInt = 4;
                    break;
                case "F":
                    gunInt = 5;
                    break;

                default:
                    gunInt = 0;
                    break;

            }

            if (gunInt == 0)
            {
                return;
            }

            zaman.gün = gunInt;

            var match = Regex.Match(saatString, "(\\d*):........(\\d*):");

            if (match.Groups.Count == 3)
            {
                zaman.baslangicsaati = int.Parse(match.Groups[1].Value) - 7;
                if (zaman.baslangicsaati < 0)
                {
                    zaman.baslangicsaati += 12;
                }
                zaman.süre = int.Parse(match.Groups[2].Value) - (zaman.baslangicsaati + 7);
                if (zaman.süre < 0)
                {
                    zaman.süre += 12;
                }
            }

            secilmisSection.SectionSaatleri.Add(zaman);



        }


        public static async Task<bool> donemKontrol(string donemKodu)
        {


            List<DersModeli> dogruDersler = new List<DersModeli>();

            string url = $"https://suis.sabanciuniv.edu/prod/bwckgens.p_proc_term_date?p_calling_proc=bwckschd.p_disp_dyn_sched&p_term={donemKodu}";

            icerik = await web.LoadFromWebAsync(url);

            var dersler = icerik.DocumentNode.SelectNodes("/html/body/div[3]/form/table[1]/tr/td[2]/select/option[1]");

            return dersler != null;

        }



        public static async Task<List<DersModeli>> dersKontrol(string dersAdi, string dersKodu,string donemKodu)
        {




            string pattern = $"{dersAdi} {dersKodu}\\S*";

            Regex regex = new Regex(pattern);

            int counter = 1;

            List<DersModeli> dogruDersler = new List<DersModeli>();




            string url = $"https://suis.sabanciuniv.edu/prod/bwckschd.p_get_crse_unsec?term_in={donemKodu}&sel_subj=dummy&sel_day=dummy&sel_schd=dummy&sel_insm=dummy&sel_camp=dummy&sel_levl=dummy&sel_sess=dummy&sel_instr=dummy&sel_ptrm=dummy&sel_attr=dummy&sel_subj={dersAdi}&sel_crse={dersKodu}&sel_title=&sel_from_cred=&sel_to_cred=&begin_hh=0&begin_mi=0&begin_ap=a&end_hh=0&end_mi=0&end_ap=a";

            icerik = await web.LoadFromWebAsync(url);


            counterTime += 1;


            while (true)
            {
                string TamDersAdi = "";

                DersModeli yeniders = new DersModeli();

                var section = icerik.DocumentNode.SelectNodes(baseString + $"/tr[{counter}]/th/a");
                if (section == null)
                {
                    break;
                }
                string sectionString = section.First().InnerText;
                var eslesme = Regex.Match(sectionString, pattern);
                if (eslesme == null)
                {
                    continue;
                }

                TamDersAdi = eslesme.Value;

                if (!dogruDersler.Any(x => x.TamDersAdi == TamDersAdi))
                {
                    yeniders.TamDersAdi = TamDersAdi;
                    dogruDersler.Add(yeniders);
                }


                counter += 2;

            }





            return dogruDersler;








        }

        public static void TamKontrol(List<SecilmemisDersModel> secilmemisDersler, List<ZamanModel> zamanlar)
        {
            foreach (SecilmemisDersModel ders in secilmemisDersler)
            {
                ders.imkanli = true;
                SectionKontrol(ders.dersBilgisi.Sectionlar, zamanlar);
                if (ders.dersBilgisi.Sectionlar.All(x => !x.imkanli))
                {
                    ders.imkanli = false;
                }
            }
        }

        public static void SectionKontrol(BindingList<SectionModel> sectionlar, List<ZamanModel> zamanlar)
        {
            foreach (SectionModel section in sectionlar)
            {
                foreach (ZamanModel zaman in section.SectionSaatleri)
                {
                    section.imkanli = true;
                    if (zamanlar.Any(x => !ZamanKarsilastir(x, zaman)))
                    {
                        section.imkanli = false;
                        break;
                    }

                }
            }
        }

        public static bool ZamanKarsilastir(ZamanModel zaman1, ZamanModel zaman2)
        {
            if (zaman1.gün != zaman2.gün)
            {
                return true;
            }
            else
            {
                if (zaman1.baslangicsaati < zaman2.baslangicsaati + zaman2.süre && zaman2.baslangicsaati < zaman1.baslangicsaati + zaman1.süre)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool YarımKarsilastir(List<ZamanModel> butunZamanlar, List<SecilmemisDersModel> dersler)
        {
            if (butunZamanlar.Count == 0)
            {
                return true;
            }

            if (dersler.Any(x => !sectListKarsilastir(x.dersBilgisi, butunZamanlar)))
            {
                return false;
            }

            return true;


        }

        private static bool sectListKarsilastir(DersModeli dersBilgisi, List<ZamanModel> butunZamanlar)
        {
            foreach (SectionModel section in dersBilgisi.Sectionlar)
            {
                sectKarsilastir(section, butunZamanlar);
            }

            if (dersBilgisi.Sectionlar.All(x => !sectKarsilastir(x, butunZamanlar)))
            {
                return false;
            }
            return true;
        }

        private static bool sectKarsilastir(SectionModel section, List<ZamanModel> butunZamanlar)
        {
            foreach (ZamanModel zaman in section.SectionSaatleri)
            {


                if (butunZamanlar.Any(x => !ZamanKarsilastir(x, zaman)))
                {
                    section.imkanli = false;

                    return false;
                }

            }
            return true;
        }

        public static bool ProgramYapma(BindingList<SecilmemisDersModel> secilmemisDersler, ref List<SectionModel> secilenSectionlar, ref List<SecilmemisDersModel> NotSelected, ref List<SecilmemisDersModel> Selected, ref List<List<ZamanModel>> AllTime)
        {
            if (NotSelected.Count < 1)
            {
                NotSelected = secilmemisDersler.Where(x => x.dersDurumu).OrderByDescending(x => x.dersBilgisi.SectionSayisi).ToList();

            }


            while (NotSelected.Count > 0)
            {


                SecilmemisDersModel SecilenDers = NotSelected.Last();

                List<SectionModel> possibleList = SecilenDers.dersBilgisi.Sectionlar.Where(x => x.imkanli).ToList();



                while (SecilenDers.order > possibleList.Count - 1)
                {



                    if (secilenSectionlar.Count == 0)
                    {
                        return false;
                    }

                    else
                    {
                        AllTime.RemoveAt(AllTime.Count - 1);
                        secilenSectionlar.RemoveAt(secilenSectionlar.Count - 1);
                        foreach (SecilmemisDersModel ders in NotSelected)
                        {
                            foreach (SectionModel section in ders.dersBilgisi.Sectionlar)
                            {
                                section.imkanli = true;
                            }
                        }
                        NotSelected.Add(Selected[Selected.Count - 1]);

                        Selected.Remove(Selected[Selected.Count - 1]);



                    }

                    SecilenDers.order = 0;

                    SecilenDers = NotSelected.Last();

                    possibleList = SecilenDers.dersBilgisi.Sectionlar.Where(x => x.imkanli).ToList();




                }



                while (SecilenDers.order < possibleList.Count)
                {
                    List<ZamanModel> zamanlar = new List<ZamanModel>();
                    SectionModel secilenSection = possibleList[SecilenDers.order];

                    foreach (ZamanModel saat in secilenSection.SectionSaatleri)
                    {
                        zamanlar.Add(saat);
                    }

                    AllTime.Add(zamanlar);

                    NotSelected.Remove(SecilenDers);

                    SecilenDers.order += 1;




                    if (!BilgiAlmaLogic.YarımKarsilastir(AllTime.SelectMany(x => x).ToList(), NotSelected))
                    {
                        AllTime.Remove(zamanlar);
                        NotSelected.Add(SecilenDers);


                        BilgiAlmaLogic.YarımKarsilastir(AllTime.SelectMany(x => x).ToList(), NotSelected);
                    }
                    else
                    {
                        secilenSectionlar.Add(secilenSection);
                        Selected.Add(SecilenDers);


                        if (NotSelected.Count < 1)
                        {

                            AllTime.Remove(zamanlar);
                            NotSelected.Add(SecilenDers);
                            Selected.Remove(SecilenDers);

                            return true;
                        }

                        break;
                    }
                }

            }
            return true;
        }

    }
}
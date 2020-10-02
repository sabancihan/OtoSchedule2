using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.models
{
    public class DersModeli
    {

        public string dersKodu
        {
            get
            {
                return TamDersAdi.Split(' ').Last();

            }
        }

        public string TamDersAdi { get; set; }

        public string DersAdi
        {
            get
            {
                return TamDersAdi.Split(' ').First();
            }
        }



        public int SectionSayisi
        {
            get
            {
                return Sectionlar.Count;
            }
        }
        public BindingList<SectionModel> Sectionlar { get; set; }
        public List<DersModeli> connected { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.models
{
    public class SecilmemisDersModel
    {
        public DersModeli dersBilgisi { get; set; }
        public bool dersDurumu { get; set; } = true;
        public bool imkanli { get; set; } = true;
        public int order { get; set; } = 0;


        public string TamDersAdi
        {
            get
            {
                return dersBilgisi.TamDersAdi;
            }
        }

    }
}

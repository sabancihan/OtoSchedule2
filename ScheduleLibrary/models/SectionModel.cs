using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.models
{
    public class SectionModel
    {
        public string SectionAdı { get; set; }
        public List<ZamanModel> SectionSaatleri { get; set; }
        public bool imkanli { get; set; } = true;


    }
}

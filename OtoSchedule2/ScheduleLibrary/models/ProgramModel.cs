using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleLibrary.models
{
    public class ProgramModel
    {
        public List<DersModeli> dersler { get; set; }
        public int dersSayisi
        {
            get
            {
                return dersler.Count;
            }
        }

    }
}

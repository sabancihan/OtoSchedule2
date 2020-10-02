using ScheduleLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleForm.Interfaces
{
    public interface IFormBaglayici
    {
        void dersEkleComplete();
        void DersBirlestir(List<DersModeli> model);
    }
}

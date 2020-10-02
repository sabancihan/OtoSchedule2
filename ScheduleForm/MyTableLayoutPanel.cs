using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleForm
{
    public class MyTableLayoutPanel : TableLayoutPanel
    {
        public MyTableLayoutPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}

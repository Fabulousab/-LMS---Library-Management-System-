using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group4_Lab3.DTL
{
    class Return
    {
        public static Form LoadForm()
        {
            group4_Lab3.Return rn = new group4_Lab3.Return();
            rn.TopLevel = false;
            rn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rn.Visible = true;
            rn.Dock = System.Windows.Forms.DockStyle.Fill;
            return rn;
        }
    }
}

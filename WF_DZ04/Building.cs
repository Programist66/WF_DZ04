using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ04
{
    public class Building : AdreesElement
    {
        public Building(string name) : base(name)
        {
        }

        public override void FillComboBoxWithChildren(ComboBox comboBox)
        {
            return;
        }
    }
}

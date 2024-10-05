using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ04
{
    public abstract class AdreesElement
    {       

        public string Name {  get;}
        protected AdreesElement(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public abstract void FillComboBoxWithChildren(ComboBox comboBox);
    }
}

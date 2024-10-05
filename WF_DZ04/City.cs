using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ04
{
    public class City : AdreesElement
    {
        public IReadOnlyList<Street> streets { get;}
        public City(string name, IReadOnlyList<Street> streets) : base(name)
        {
            this.streets = streets;
        }
        public override void FillComboBoxWithChildren(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (Street street in streets)
            {
                comboBox.Items.Add(street);
            }
        }
    }
}

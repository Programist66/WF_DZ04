using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ04
{
    public class Street : AdreesElement
    {
        public IReadOnlyList<Building> Buildings { get; }

        public Street(string name, IReadOnlyList<Building> buildings) : base(name) 
        {
            Buildings = buildings;
        }        

        public override void FillComboBoxWithChildren(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (Building building in Buildings)
            {
                comboBox.Items.Add(building);
            }
        }
    }
}

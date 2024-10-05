using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_DZ04
{
    public class Country : AdreesElement
    {
        public IReadOnlyList<City> Cities { get; }

        public Country(string name, IReadOnlyList<City> cities) : base(name)
        {
            Cities = cities;            
        }         

        public override void FillComboBoxWithChildren(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (City city in Cities)
            {
                comboBox.Items.Add(city);
            }
        }
    }
}

namespace WF_DZ04
{
    public partial class Form1 : Form
    {
        IReadOnlyList<Country> countries;

        public Form1()
        {
            InitializeComponent();
            countries = new List<Country>()
            {
               new Country("Россия", new List<City>()
               {
                   new City("Москва", new List<Street>()
                   {
                       new Street("Попова", new List<Building>()
                       {
                           new Building("6"),
                           new Building("12"),
                           new Building("18")
                       }),
                       new Street("Лужникова", new List<Building>()
                       {
                           new Building("5"),
                           new Building("10"),
                           new Building("15")
                       }),
                       new Street("Байкальская", new List<Building>()
                       {
                           new Building("7"),
                           new Building("14"),
                           new Building("21")
                       })
                   }),
                   new City("Санкт-Петербург", new List<Street>()
                   {
                       new Street("Невский проспект", new List<Building>()
                       {
                           new Building("1"),
                           new Building("2"),
                           new Building("3")
                       }),
                       new Street("Проспект Кима", new List<Building>()
                       {
                           new Building("2"),
                           new Building("4"),
                           new Building("6")
                       }),
                       new Street("Итальянская", new List<Building>()
                       {
                           new Building("3"),
                           new Building("6"),
                           new Building("9")
                       })
                   }),
                   new City("Йошкар-Ола", new List<Street>()
                   {
                       new Street("Петрова", new List<Building>()
                       {
                           new Building("8"),
                           new Building("13"),
                           new Building("24")
                       }),
                       new Street("Бульвар Чавайна", new List<Building>()
                       {
                           new Building("9"),
                           new Building("18"),
                           new Building("27")
                       }),
                       new Street("Эшкинино", new List<Building>()
                       {
                           new Building("10"),
                           new Building("20"),
                           new Building("30")
                       })
                   }),
               }),
               new Country("США", new List<City>()
               {
                   new City("Калифорния", new List<Street>()
                   {
                       new Street("Американская", new List<Building>()
                       {
                           new Building("5"),
                           new Building("12"),
                           new Building("15")
                       }),
                       new Street("Франзузская", new List<Building>()
                       {
                           new Building("9"),
                           new Building("12"),
                           new Building("15")
                       }),
                       new Street("Майкла-Джексона", new List<Building>()
                       {
                           new Building("5"),
                           new Building("12"),
                           new Building("15")
                       })
                   }),
                   new City("Лас-Вегас", new List<Street>()
                   {
                       new Street("Кинская", new List<Building>()
                       {
                           new Building("5"),
                           new Building("12"),
                           new Building("80")
                       }),
                       new Street("Платформенная", new List<Building>()
                       {
                           new Building("46"),
                           new Building("122"),
                           new Building("195")
                       }),
                       new Street("Патриотов", new List<Building>()
                       {
                           new Building("66"),
                           new Building("111"),
                           new Building("555")
                       })
                   }),
                   new City("Голивуд", new List<Street>()
                   {
                       new Street("Красная", new List<Building>()
                       {
                           new Building("1"),
                           new Building("22"),
                           new Building("33")
                       }),
                       new Street("Гроу", new List<Building>()
                       {
                           new Building("33"),
                           new Building("66"),
                           new Building("99")
                       }),
                       new Street("фильмовская", new List<Building>()
                       {
                           new Building("13"),
                           new Building("52"),
                           new Building("69")
                       })
                   }),
               }),
               new Country("Англия", new List<City>()
               {
                   new City("Лондон", new List<Street>()
                   {
                       new Street("Кингс-роу", new List<Building>()
                       {
                           new Building("3/4"),
                           new Building("5/8"),
                           new Building("9/10")
                       }),
                       new Street("Королевская", new List<Building>()
                       {
                           new Building("13"),
                           new Building("15"),
                           new Building("87")
                       }),
                       new Street("Лютиков", new List<Building>()
                       {
                           new Building("21"),
                           new Building("79"),
                           new Building("102")
                       })
                   }),
                   new City("Оксфорд", new List<Street>()
                   {
                       new Street("Университетская", new List<Building>()
                       {
                           new Building("7"),
                           new Building("11"),
                           new Building("34")
                       }),
                       new Street("Школьная", new List<Building>()
                       {
                           new Building("23"),
                           new Building("49"),
                           new Building("84")
                       }),
                       new Street("Садиская", new List<Building>()
                       {
                           new Building("89"),
                           new Building("666"),
                           new Building("777")
                       })
                   }),
                   new City("Бристоль", new List<Street>()
                   {
                       new Street("Пивная", new List<Building>()
                       {
                           new Building("55"),
                           new Building("74"),
                           new Building("98")
                       }),
                       new Street("Закусочная", new List<Building>()
                       {
                           new Building("3"),
                           new Building("24"),
                           new Building("69")
                       }),
                       new Street("Водская", new List<Building>()
                       {
                           new Building("16"),
                           new Building("38"),
                           new Building("74")
                       })
                   }),
               }),

            };

            foreach (Country country in countries)
            {
                countryComboBox.Items.Add(country);
            }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedItem == null)
            {
                cityPanel.Visible = false;
                streetPanel.Visible = false;
                buildingPanel.Visible = false;
                return;
            }
            Country currentCountry = (Country)countryComboBox.SelectedItem;
            currentCountry.FillComboBoxWithChildren(cityComboBox);
            cityPanel.Visible = true;
            UpdateStreet();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStreet();
        }

        private void streetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBuilding();
        }

        private void UpdateStreet() 
        {
            if (cityComboBox.SelectedItem == null)
            {
                streetPanel.Visible = false;
                buildingPanel.Visible = false;
                return;
            }
            City currentCity = (City)cityComboBox.SelectedItem;
            currentCity.FillComboBoxWithChildren(streetComboBox);
            streetPanel.Visible = true;
            UpdateBuilding();
        }

        private void UpdateBuilding() 
        {
            if (streetComboBox.SelectedItem == null)
            {
                buildingPanel.Visible = false;
                return;
            }
            Street currentStreet = (Street)streetComboBox.SelectedItem;
            currentStreet.FillComboBoxWithChildren(buildingComboBox);
            buildingPanel.Visible = true;
        }
    }
}

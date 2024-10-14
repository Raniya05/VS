using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using прокат.авто.База_Данных;

namespace прокат.авто.Каршеринг
{
    /// <summary>
    /// Логика взаимодействия для CatalogAvtoPage.xaml
    /// </summary>
    public partial class CatalogAvtoPage : Page
    {
        public CatalogAvtoPage()
        {
            InitializeComponent();
            ListAvto.ItemsSource = AvtoProkatEntities1.GetContext().Автомобили.ToList();
        }

    
    }
}

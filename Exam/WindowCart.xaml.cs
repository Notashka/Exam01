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
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для WindowCart.xaml
    /// </summary>
    public partial class WindowCart : Window
    {
        public WindowCart(List<Exam01> BooksCart)
        {
            InitializeComponent();
            LVKList.Items.Clear();
            LVKList.ItemsSource = BooksCart;
        }
    }
}

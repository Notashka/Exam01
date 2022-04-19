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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для PageShop.xaml
    /// </summary>
    public partial class PageShop : Page
    {
        List<Exam01> BooksCart = new List<Exam01>();

        public PageShop()
        {
            InitializeComponent();
            LVShop.ItemsSource = BaseConnect.Base.Exam01.ToList();
        }

        private void BTAdd_Click(object sender, RoutedEventArgs e)
        {
            var selectedList = LVShop.SelectedItems;
            TBCount.Text = "  " + selectedList.Count;
            int totalCost = 0;
            foreach (Exam01 n in selectedList)
            {
                totalCost += (int)n.Cost;
                BooksCart.Add(n);
            }
            TBCost.Text = "  " + totalCost;
        }

        private void BTPer_Click(object sender, RoutedEventArgs e)
        {
            WindowCart cart = new WindowCart(BooksCart);
            cart.ShowDialog();
        }
    }
}

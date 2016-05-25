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
using mobile_messages.Model;

namespace mobile_messages
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            ViewModel viewModel = new ViewModel();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void ContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Messaging m = new Messaging();
            m.Owner = this;
            m.ShowDialog();
        }

    }
}

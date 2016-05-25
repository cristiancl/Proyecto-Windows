using System.Windows;



namespace mobile_messages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 m = new Window1();
            m.Owner = this;
            m.ShowDialog();  
        }
    }
}

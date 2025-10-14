using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFKargo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            Employees = []; // create a new collection

            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbEmployeeName.Text))
            {
                Employee emp = new Employee(tbEmployeeName.Text);
                Employees.Add(emp);
                tbEmployeeName.Clear();
            }
        }
    }
}
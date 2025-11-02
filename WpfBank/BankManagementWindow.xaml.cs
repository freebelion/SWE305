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

namespace WpfBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BankManagementWindow : Window
    {
        public ObservableCollection<Account> Accounts { get; set; }
        public Account? SelectedAccount { get; set; }

        public BankManagementWindow()
        {
            InitializeComponent();

            Accounts = [];
            SelectedAccount = null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;

            for(int i=0; i< 5; i++)
            {
                Accounts.Add(new Account());
                Accounts[i].DoTransaction(500);
            }
        }

        private void DoTransaction(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            decimal amount = Convert.ToDecimal(btn.Tag);
            if(SelectedAccount != null)
            { SelectedAccount.DoTransaction(amount); }
        }
    }
}
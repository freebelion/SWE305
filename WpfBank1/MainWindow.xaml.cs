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

namespace WpfBank1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This dynamic list of Account objects
        /// will be the source of items for the ListBox.
        /// A simple generic list like List<Account>
        /// would be a static data source,
        /// i.e. additions and deletions on the list
        /// would not be observed on the ListBox.
        /// </summary>
        public ObservableCollection<Account> Accounts { get; set; }

        /// <summary>
        /// This property keeps track of whichever Account
        /// the user has selected on the ListBox.
        /// It is nullable, because the user
        /// may not have selected an account.
        /// </summary>
        public Account? SelectedAccount { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            // The source of data bindings is this window, itself.
            this.DataContext = this;

            // Create the account list
            Accounts = [];
            // Add some empty accounts
            for(int i=0; i< 10; i++)
            {// In recent versions of C#, simply calling new() is enough to create an object
                Accounts.Add(new()); // same as Accounts.Add(new Account());
            }
            // Initially, there is no selectedAccount
            SelectedAccount = null;         
        }

        /// <summary>
        /// This member function will handle the Click events
        /// of all the transaction buttons.
        /// The name should have been more descriptive,
        /// like "DoTransaction".
        /// </summary>
        /// <param name="sender">The source of the event (any of the ATM transaction buttons)</param>
        /// <param name="e">The details of the event</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the identity of the button which has been cliked
            Button btn = (Button)sender; // Note that this will fail if the source is not a button
            // Get the transaction amount from the tag property
            decimal amount = Convert.ToDecimal(btn.Tag); // which requires a conversion, because Tag is a string
            // If there is a selected account, do the transaction on it
            if (SelectedAccount != null)
            {
                SelectedAccount.DoTransaction(amount);
            }
        }

        /// <summary>
        /// This event handler function has a descriptive name,
        /// thanks to "refactoring".
        /// </summary>
        /// <param name="sender">The source of event (+ button at the bottom of the left column)</param>
        /// <param name="e">The details of the event</param>
        private void CreateAccount(object sender, RoutedEventArgs e)
        {// Sadly, the new account object that we add won't be shown in the ListBox
            Accounts.Add(new());
        }
    }
}
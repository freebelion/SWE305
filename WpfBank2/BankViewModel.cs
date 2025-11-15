using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBank2
{
    public partial class BankViewModel : ObservableObject
    {
        public ObservableCollection<Account> Accounts { get; set; }

        [ObservableProperty]
        private Account? _selectedAccount;

        public BankViewModel()
        {
            Accounts = [];
            SelectedAccount = null;
        }

        [RelayCommand]
        private void CreateAccount()
        {
            Accounts.Add(new());
        }
    }
}

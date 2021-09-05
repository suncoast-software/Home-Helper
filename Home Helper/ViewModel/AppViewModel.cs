using Home_Helper.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Helper.ViewModel
{
    public class AppViewModel : BaseViewModel
    {
        private string _currentDate;
        public string CurrentDate
        {
            get => _currentDate;
            set => OnPropertyChanged(ref _currentDate, value);
        }

        private ObservableCollection<Bill> _bills;
        public ObservableCollection<Bill> Bills
        {
            get => _bills;
            set => OnPropertyChanged(ref _bills, value);
        }

        public AppViewModel()
        {
            CurrentDate = DateTime.Now.ToShortDateString();
            Bills = new ObservableCollection<Bill>();
            LoadBills();
        }

        private void LoadBills()
        {
            Bill bill = new()
            {
                AccountNumber = "1234",
                Payee = null,
                DueDate = DateTime.Parse(CurrentDate),
                PaidDate = DateTime.Now,
                ConfirmationNumber = "123456",
                Paid = true,
            };
            Bills.Add(bill);
        }
    }
}

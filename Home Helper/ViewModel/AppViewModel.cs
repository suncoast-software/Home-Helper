using Home_Helper.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Home_Helper.ViewModel
{
    public class AppViewModel : BaseViewModel
    {
        public ICommand AddNewBillCommand { get; set; }

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

        private Bill _bill;
        public Bill Bill
        {
            get => _bill;
            set => OnPropertyChanged(ref _bill, value);
        }

        public AppViewModel()
        {
            CurrentDate = DateTime.Now.ToShortDateString();
            Bills = new ObservableCollection<Bill>();
            AddNewBillCommand = new RelayCommand(AddNewBill);
            Bill = new();
            LoadBills();
        }

        private void AddNewBill()
        {
            _ = MessageBox.Show("Test");
        }

        private void LoadBills()
        {
            Bill bill = new()
            {
                Id = 1,
                AccountNumber = "1234",
                Payee = new Payee() { PayeeName = "Best Buy" },
                DueDate = DateTime.Parse(CurrentDate),
                PaidDate = DateTime.Now,
                ConfirmationNumber = "123456",
                Recurring = true,
                Paid = true,
            };
            Bill bill1 = new()
            {
                Id = 2,
                AccountNumber = "2222",
                Payee = new Payee() { PayeeName = "Florida Power & Light(FPL)" },
                DueDate = DateTime.Parse(CurrentDate),
                PaidDate = DateTime.Now,
                ConfirmationNumber = "22222222",
                Recurring = true,
                Paid = true,
            };
            Bill bill2 = new()
            {
                Id = 3,
                AccountNumber = "3333",
                Payee = new Payee() { PayeeName = "Honda International" },
                DueDate = DateTime.Parse(CurrentDate),
                PaidDate = DateTime.Now,
                ConfirmationNumber = "333333",
                Recurring = true,
                Paid = false,
            };
            Bills.Add(bill);
            Bills.Add(bill1);
            Bills.Add(bill2);
        }
    }
}

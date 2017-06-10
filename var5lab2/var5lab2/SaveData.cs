using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace var5lab2
{
    class SaveData: ICommand
    {
       public bool CanExecute(object parameter)
        {
            return true;
        } 
        public void Execute(object parameter)
        {
            MainWindowViewM.SaveCardData();
            MainWindowViewM.SaveCashData();
            MainWindowViewM.ID = MainWindowViewM.ID + 1;
        }
        public event EventHandler CanExecuteChanged;
    }
}

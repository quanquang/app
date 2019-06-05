using app.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace app.ViewModel
{
    public class thuc_don:BaseViewModel
    {
        public ObservableCollection<thucUong> _dsThucUong;
        public ObservableCollection<thucUong> dsThucUong
        {
            get { return _dsThucUong; }
            set
            {
                _dsThucUong = value;
                OnPropertyChanged("dsThucUong");
            }
        }
        public ICommand ButtonTaoSP { get; set; }


        public thuc_don()
        {
           
        }
    }
}

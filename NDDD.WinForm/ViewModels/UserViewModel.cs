using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.WinForm.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public string UserIdText { get; set; }
        public string UserNameText { get; set; }
        public string UserLoginPasswordText { get; set; }

        public void Search()
        {
            throw new NotImplementedException();
        }
    }
}

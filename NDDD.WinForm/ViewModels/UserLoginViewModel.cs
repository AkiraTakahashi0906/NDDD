using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.WinForm.ViewModels
{
    public class UserLoginViewModel : ViewModelBase
    {
        private IUserRepository _userRepository;
        private UserEntity _user;

        public UserLoginViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string UserIdText
        {
            get
            {
                if (_user == null)
                {
                    return string.Empty;
                }
                return _user.UserId.ToString().PadLeft(4, '0');
            }
        }
        public string UserNameText
        {
            get
            {
                if (_user == null)
                {
                    return string.Empty;
                }
                return _user.UserName.ToString();
            }
        }
        public string UserLoginPasswordText
        {
            get
            {
                if (_user == null)
                {
                    return string.Empty;
                }
                return _user.UserLoginPassword.ToString();
            }
        }

        public void Search()
        {
            _user = _userRepository.GetUserData();
            base.OnPropertyChanged();
        }
    }
}

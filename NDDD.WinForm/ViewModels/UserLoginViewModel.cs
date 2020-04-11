using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure;
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

        private string _userIdText;
        private string _userNameText;
        private string _userLoginPassword;

        public UserLoginViewModel()
            :this(Factories.CreateUser())
        {
        }

        public UserLoginViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string UserIdText
        {
            get { return _userIdText; }
            set
            {
                SetProperty(ref _userIdText, value);
            }
        }
        public string UserNameText
        {
            get { return _userNameText; }
            set
            {
                SetProperty(ref _userNameText, value);
            }
        }
        public string UserLoginPasswordText
        {
            get { return _userLoginPassword; }
            set
            {
                SetProperty(ref _userLoginPassword, value);
            }
        }

        public void Search()
        {
            var user = _userRepository.GetUserData(1);
            UserIdText= user.UserId.ToString().PadLeft(4, '0');
            UserNameText= user.UserName.ToString();
            UserLoginPasswordText= user.UserLoginPassword.ToString();
        }
    }
}

using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.WinForm.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private IUserRepository2 _users;

        public LoginViewModel()
            : this(Factories.CreateUser2())
        {
        }

        public LoginViewModel(IUserRepository2 users)
        {
            _users = users;
            foreach (var user in users.GetUser())
            {
                Users.Add(new UserEntity2(user.UserId, user.UserName,user.UserLoginPassword));
            }
        }

        private object _selectedUserId;
        public object SelectedUserId
        {
            get { return _selectedUserId; }
            set
            {
                SetProperty(ref _selectedUserId, value);
            }
        }

        public BindingList<UserEntity2> Users { get; set; }= new BindingList<UserEntity2>();
    }
}

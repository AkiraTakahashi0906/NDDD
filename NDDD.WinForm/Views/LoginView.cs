using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDDD.WinForm.Views
{
    public partial class LoginView : BaseForm
    {
        private LoginViewModel _viewModel = new LoginViewModel();
        public LoginView()
        {
            InitializeComponent();
            UsersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UsersComboBox.DataBindings.Add(
                "SelectedValue", _viewModel, nameof(_viewModel.SelectedUserId));
            UsersComboBox.DataBindings.Add(
                "DataSource", _viewModel, nameof(_viewModel.Users));
            UsersComboBox.ValueMember = nameof(UserEntity2.UserId);
            UsersComboBox.DisplayMember = nameof(UserEntity2.UserName);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Shared.LoginId = LoginTextBox.Text;
            using(var f = new MaterialStoringView())
            {
                f.ShowDialog();
            }
        }
    }
}

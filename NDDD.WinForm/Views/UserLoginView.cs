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
    public partial class UserLoginView : Form
    {
        private UserLoginViewModel _viewModel = new UserLoginViewModel();
        public UserLoginView()
        {
            InitializeComponent();

            UserIdTextBox.DataBindings.Add("Text",
                _viewModel,
                nameof(_viewModel.UserIdText));

            UserNameTextBox.DataBindings.Add("Text",
                _viewModel,
                nameof(_viewModel.UserNameText));

            PassWordTextBox.DataBindings.Add("Text",
                _viewModel,
                nameof(_viewModel.UserLoginPasswordText));

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }
    }
}

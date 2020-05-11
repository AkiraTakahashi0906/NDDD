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
    public partial class MaterialStoringView : BaseForm
    {
        private MaterialStoringViewModel _viewModel = new MaterialStoringViewModel();
        public MaterialStoringView()
        {
            InitializeComponent();
            BarcodeReadTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.BarcodeReadText));
            MaterialCodeTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.MaterialCodeText));
            DeliveryRecordTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.DeliveryRecordText));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.MaterialSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.DeliveryRecordSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

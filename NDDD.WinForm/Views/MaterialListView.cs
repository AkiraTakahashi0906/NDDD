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
    public partial class MaterialListView : Form
    {
        private MaterialListViewModel _viewModel = new MaterialListViewModel();
        public MaterialListView()
        {
            InitializeComponent();
            MaterialDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.MaterialReceipts));
            //MaterialDataGrid.Columns[1].HeaderText = "test";
        }
    }
}

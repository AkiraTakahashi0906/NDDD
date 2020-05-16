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
    public class MaterialListViewModel : ViewModelBase
    {
        private IMaterialReceiptRepository _materialReceipt;

        public MaterialListViewModel():this(Factories.CreateMaterialReceipt())
        {
        }

        public MaterialListViewModel(IMaterialReceiptRepository materialReceipt)
        {
            _materialReceipt = materialReceipt;
            foreach(var entity in _materialReceipt.GetData())
            {
                MaterialReceipts.Add(new MaterialListViewModelMaterial(entity));
            }
        }

        public BindingList<MaterialListViewModelMaterial> MaterialReceipts { get; set; } 
            = new BindingList<MaterialListViewModelMaterial>();
    }
}

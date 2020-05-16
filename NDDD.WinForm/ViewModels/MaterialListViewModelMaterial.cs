using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.WinForm.ViewModels
{
    public sealed class MaterialListViewModelMaterial
    {
        private MaterialReceiptEntity _entity;
        public MaterialListViewModelMaterial(MaterialReceiptEntity entity)
        {
            _entity = entity;
        }
        public string MaterialManagementCode => _entity.MaterialManagementCode.Value;
        public string MaterialReceiptDate => _entity.MaterialReceiptDate.ToString();
        public string MaterialDeliveryPlace => _entity.MaterialDeliveryPlace.Value;
    }
}

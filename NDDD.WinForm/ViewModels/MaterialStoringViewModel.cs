using NDDD.Domain.Entities;
using NDDD.Domain.Modules.Helpers;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDDD.WinForm.ViewModels
{
    public class MaterialStoringViewModel : ViewModelBase
    {
        private IMaterialRepository _materialRepository;
        private string _barcodeReadText = string.Empty;
        private string _materialCodeText = string.Empty;
        private string _materialNameText = string.Empty;
        private string _materialQuantityText = string.Empty;
        private string _materialUnitText = string.Empty;
        private string _materialExpirationDateText = string.Empty;
        private string _DeliveryRecordText = string.Empty;
        private MaterialEntity _materialEntity;

        public MaterialStoringViewModel():this(Factories.CreateMaterial())
        {
        }

        public MaterialStoringViewModel(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public string BarcodeReadText { get; set; } = string.Empty;

        public string MaterialCodeText
        {
            get { return _materialCodeText; }
            set
            {
                SetProperty(ref _materialCodeText, value);
            }
        }

        public string MaterialNameText
        {
            get { return _materialNameText; }
            set
            {
                SetProperty(ref _materialNameText, value);
            }
        }

        public string MaterialQuantityText
        {
            get { return _materialQuantityText; }
            set
            {
                SetProperty(ref _materialQuantityText, value);
            }
        }

        public string MaterialUnitText
        {
            get { return _materialUnitText; }
            set
            {
                SetProperty(ref _materialUnitText, value);
            }
        }

        public string MaterialExpirationDateText
        {
            get { return _materialExpirationDateText; }
            set
            {
                SetProperty(ref _materialExpirationDateText, value);
            }
        }


        public string DeliveryRecordText
        {
            get { return _DeliveryRecordText; }
            set
            {
                SetProperty(ref _DeliveryRecordText, value);
            }
        }

        public void MaterialSearch()
        {
            var readBarcode = new Barcode(Guard.IsStringEmpty(BarcodeReadText, "材料バーコード空白エラー"));
            _materialEntity = _materialRepository.GetMaterial(readBarcode);
            MaterialCodeText = _materialEntity.MaterialCode.DisplayValue;
            MaterialNameText = _materialEntity.MaterialName.DisplayValue;
            MaterialQuantityText = _materialEntity.MaterialQuantity.DisplayValue;
        }

        public void DeliveryRecordSave()
        {
            Guard.IsStringEmpty(DeliveryRecordText, "配送先バーコード空白エラー");
            //var entity= new MaterialEntity
            _materialRepository.DeliveryRecordSave((MaterialEntity)Guard.IsNull(_materialEntity,"材料データが見つかりません。"));
        }

    }
}

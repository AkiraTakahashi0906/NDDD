using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public MaterialStoringViewModel()
        {

        }
        public string BarcodeReadText
        {
            get { return _barcodeReadText; }
            set
            {
                SetProperty(ref _barcodeReadText, value);
            }
        }

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

        //本番コード
        public void MaterialSearch(Barcode key)
        {
            var material = Factories.CreateMaterial();
            var materialEntity = material.GetMaterial(key);
            BarcodeReadText = materialEntity.BarcodeReadText.DisplayValue;
        }

        //テストコードテストコード
        public void MaterialSearch(Barcode key,IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
            var materialEntity = _materialRepository.GetMaterial(key);
            BarcodeReadText = materialEntity.BarcodeReadText.DisplayValue;
        }


    }
}

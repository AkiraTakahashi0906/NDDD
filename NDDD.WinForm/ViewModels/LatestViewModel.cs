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
    public class LatestViewModel : ViewModelBase
    {
        //private IMeasureRepository _measureRepository;
        private MeasureRepository _measureRepository;//具象クラス

        //プライベート変数は頭に_をつける
        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        //コンストラクタに指定がなければ本番コード->ファクトリーが四べれてから下のコンストラクタが走る
        public LatestViewModel()
            :this(Factories.CreateMeasure())
        {
        }

        //テストコードの場合はこちらが走る
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            //_measureRepository = measureRepository;
            _measureRepository = new MeasureRepository(measureRepository);//具象クラス
        }

        public string AreaIdText
        {
            get { return _areaIdText; }
            set
            {
                SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText
        {
            get { return _measureDateText; }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText
        {
            get { return _measureValueText; }
            set
            {
                SetProperty(ref _measureValueText, value);
            }
        }

        public void Search()
        {
            var measure = _measureRepository.GetLatest();//具象クラスに飛ぶF12
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
        }
    }
}

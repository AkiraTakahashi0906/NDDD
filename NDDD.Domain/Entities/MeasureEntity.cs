using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity
    {
        //Newするときにコンストラクタで必ず値が入る。完全コンストラクタパターン
        public MeasureEntity(int areaId,
            DateTime measureDate,
            float measureValue)
        {
            AreaId =new AreaId(areaId);
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = new MeasureValue(measureValue);
        }
        //メジャーテーブルからとってこれるデータ
        public AreaId AreaId { get; }
        public MeasureDate MeasureDate { get; }
        public MeasureValue MeasureValue { get; }

        //複合的の項目にまたがるようなロジックはEntityに
    }
}

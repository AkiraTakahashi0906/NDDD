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
            AreaId = areaId;
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }
        //メジャーテーブルからとってこれるデータ
        public int AreaId { get; }
        public DateTime MeasureDate { get; }
        public  float MeasureValue { get; }
    }
}

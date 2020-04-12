using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        //完全コンストラクタパターン
        //コンストラクタで値設定後は値を変更できないクラス。
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        //プロパティをゲットだけ（読み取り専用）
        public DateTime Value { get; }

        public string DisplayValue => Value.ToString("yyyy/MM/dd HH:mm:ss");

        protected override bool EqualsCore(MeasureDate other)
        {
            return this.Value == other.Value;
        }
    }
}

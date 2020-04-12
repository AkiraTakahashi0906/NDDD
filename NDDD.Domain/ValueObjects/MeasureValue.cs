using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        //完全コンストラクタパターン
        //コンストラクタで値設定後は値を変更できないクラス。
        public MeasureValue(float value)
        {
            Value = value;
        }

        //プロパティをゲットだけ（読み取り専用）
        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2) + "℃";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}

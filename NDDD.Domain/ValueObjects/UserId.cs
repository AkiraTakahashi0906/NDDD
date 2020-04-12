using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class UserId : ValueObject<UserId>
    {
        //完全コンストラクタパターン
        //コンストラクタで値設定後は値を変更できないクラス。
        public UserId(int value)
        {
            Value = value;
        }

        //プロパティをゲットだけ（読み取り専用）
        public int Value { get; }

        public string DisplayValue => Value.ToString().PadLeft(4, '0');

        protected override bool EqualsCore(UserId other)
        {
            return this.Value == other.Value;
        }
    }
}

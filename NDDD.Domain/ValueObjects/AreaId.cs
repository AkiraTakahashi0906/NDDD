using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class AreaId
    {
        //完全コンストラクタパターン
        //コンストラクタで値設定後は値を変更できないクラス。
        public AreaId(int value)
        {
            Value = value;
        }

        //プロパティをゲットだけ（読み取り専用）
        public int Value { get; }
    }
}

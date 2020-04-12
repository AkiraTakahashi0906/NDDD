using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ヘルパーズ　拡張された関数　　MSフレームワークにあったらよかったのにな、でもないけどなってやつ
namespace NDDD.Domain.Helpers
{
    public static class FloatHelper
    {
        //this float　拡張メソッド
        public static string RoundString(this float value,int decimalPoint)
        {
            value = Convert.ToSingle(Math.Round(value, decimalPoint));
            return value.ToString(decimalPoint == 0 ?
                string.Empty : "." + 
                string.Concat(Enumerable.Repeat("0",decimalPoint)));
        }
    }
}

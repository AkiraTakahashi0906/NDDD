using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Exceptios
{
    //Exceptionは必ずExceptionクラスを継承する
    //SQLServerでわかる例外はインフラ層に書いた方が良い
    public sealed class DataNotExistsException : ExceptionBase
    {
        public DataNotExistsException()
            : base("データがありません")
        {
        }

        public override ExceptionKind Kind => ExceptionKind.info ;
    }
}

using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//外部接触部はインターフェース越しにリポジトリ経由でとってくる
namespace NDDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
    }
}

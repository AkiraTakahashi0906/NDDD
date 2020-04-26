using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MaterialFake : IMaterialRepository
    {
        public MaterialEntity GetMaterial(Barcode barcode)
        {
            return  new MaterialEntity(
                        "AAAA",
                        "050050505050442",
                        "1775B22",
                        1.5f,
                        "EA",
                        Convert.ToDateTime("2012/12/12 12:34:56")
                        );
        }

        public IReadOnlyList<MaterialEntity> GetMaterials()
        {
            throw new NotImplementedException();
        }
    }
}

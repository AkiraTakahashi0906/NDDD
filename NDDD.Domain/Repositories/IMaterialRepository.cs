using NDDD.Domain.Entities;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Repositories
{
    public interface IMaterialRepository
    {
        MaterialEntity GetMaterial(Barcode barcode);
        IReadOnlyList<MaterialEntity> GetMaterials();
    }
}

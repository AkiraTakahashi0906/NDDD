using NDDD.Domain.Entities;
using NDDD.Domain.Exceptios;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.SQLServer
{
    internal sealed class MaterialSqlServer : IMaterialRepository
    {
        public void DeliveryRecordSave(MaterialEntity material)
        {
            throw new NotImplementedException();
        }

        public MaterialEntity GetMaterial(Barcode barcode)
        {
            string sql = @"
select MaterialManagementCode,
    MaterialCode,
    MaterialName,
    MaterialUnitName,
    MaterialQuantity,
    MaterialExpirationDate
from MaterialTable
where MaterialManagementCode = @MMC
";
            MaterialEntity user = null;
            SqlServerHelper.Query(
                sql,
                new List<SqlParameter> { new SqlParameter("@MMC", barcode.Value) }.ToArray(),
                                    reader =>
                                    {
                                        user = new MaterialEntity(Convert.ToString(reader["MaterialManagementCode"]),
                                                                Convert.ToString(reader["MaterialCode"]),
                                                                Convert.ToString(reader["MaterialName"]),
                                                                Convert.ToSingle(reader["MaterialQuantity"]),
                                                                Convert.ToString(reader["MaterialUnitName"]),
                                                                Convert.ToDateTime(reader["MaterialExpirationDate"]));
                                    });

            if (user == null)
            {
                throw new DataNotExistsException();
            }
            return user;
        }

        public IReadOnlyList<MaterialEntity> GetMaterials()
        {
            throw new NotImplementedException();
        }

    }
}

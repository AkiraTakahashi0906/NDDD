using NDDD.Domain.Entities;
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
        public MaterialEntity GetMaterial(Barcode barcode)
        {
            string sql = @"
select Top 1 UserID,
    UserName,
    Password
from UserTable
where UserID = @UserID
order by UserID
";
            MaterialEntity user = null;
            SqlServerHelper.Query(
                sql,
                new List<SqlParameter> { new SqlParameter("@UserID", barcode.Value) }.ToArray(),
                                    reader =>
                                    {
                                        user = new MaterialEntity(Convert.ToString(reader["UserID"]),
                                                                Convert.ToString(reader["UserName"]),
                                                                Convert.ToString(reader["UserName"]),
                                                                Convert.ToInt32(reader["UserName"]),
                                                                Convert.ToString(reader["UserName"]),
                                                                Convert.ToDateTime(reader["Password"]));
                                    });
            return user;
        }

        public IReadOnlyList<MaterialEntity> GetMaterials()
        {
            throw new NotImplementedException();
        }
    }
}

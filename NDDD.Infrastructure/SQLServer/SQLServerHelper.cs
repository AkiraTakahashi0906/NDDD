﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

//できるだけInfrastructure層はシンプルに
//シンプルにとってきたデータをc#で加工したほうがバグりにくい

//Infrastructure層ではいっさいのトランザクションはしない。使う側に管理させる（ViewModelでトランザクションを管理する)

namespace NDDD.Infrastructure.SqlServer
{
    internal static class SqlServerHelper
    {
        internal readonly static string ConnectionString;
        static SqlServerHelper()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-8B0KCU1\SQLEXPRESS";
            builder.InitialCatalog = "DDD2";
            builder.IntegratedSecurity = true;
            ConnectionString = builder.ConnectionString;
        }

        internal static void Query(
           string sql,
           SqlParameter[] parameters,
           Action<SqlDataReader> action)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {

                connection.Open();
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        action(reader);
                    }
                }
            }
        }

        internal static void Execute(
          string sql,
          SqlParameter[] parameters)
        {
            using (var connection =
            new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
            }
        }
    }
}


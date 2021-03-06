﻿using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptios;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(
                Shared.FakePath + "MeasureFake.txt");
                var value = lines[0].Split(',');
                return new MeasureEntity(
                    Convert.ToInt32(value[0]),
                    Convert.ToDateTime(value[1]),
                    Convert.ToSingle(value[2])
                    );
            }
            catch(Exception ex)
            {
                throw new FakeException("MeasureFakeの取得に失敗しました", ex);
                //return new MeasureEntity(
                //            10,
                //            Convert.ToDateTime("2012/12/12 12:34:56"),
                //            12.341f
                //            );
            }
        }

        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            var result = new List<MeasureEntity>();
            result.Add(
                new MeasureEntity(
                            10,
                            Convert.ToDateTime("2012/12/12 12:34:56"),
                            12.341f
                            ));
            result.Add(
            new MeasureEntity(
                20,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                22.341f
                ));
            result.Add(
            new MeasureEntity(
                30,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                32.341f
                ));
            return result;
        }
    }
}

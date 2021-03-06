﻿using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Repositories
{
    public interface IMaterialReceiptRepository
    {
        void DeliveryRecordSave(MaterialReceiptEntity material);
        IReadOnlyList<MaterialReceiptEntity> GetData();
    }
}

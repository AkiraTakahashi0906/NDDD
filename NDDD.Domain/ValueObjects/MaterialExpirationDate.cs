using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MaterialExpirationDate : ValueObject<MaterialExpirationDate>
    {

        public MaterialExpirationDate(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; }
        protected override bool EqualsCore(MaterialExpirationDate other)
        {
            return this.Value == other.Value;
        }
    }
}

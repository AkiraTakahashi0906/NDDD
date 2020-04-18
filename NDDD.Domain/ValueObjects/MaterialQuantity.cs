using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MaterialQuantity : ValueObject<MaterialQuantity>
    {
        public MaterialQuantity(float value)
        {
            Value = value;
        }

        public float Value { get; }

        protected override bool EqualsCore(MaterialQuantity other)
        {
            return this.Value == other.Value;
        }
    }
}

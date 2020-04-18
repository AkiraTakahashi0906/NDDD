using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public class MaterialUnit : ValueObject<MaterialUnit>
    {

        public MaterialUnit(string value)
        {
            Value = value;
        }

        public string Value { get; }
        protected override bool EqualsCore(MaterialUnit other)
        {
            return this.Value == other.Value;
        }
    }
}

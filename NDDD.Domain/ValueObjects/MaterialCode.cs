using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MaterialCode : ValueObject<MaterialCode>
    {
        public MaterialCode(string value)
        {
            Value = value;
        }
        public string Value { get; }

        public string DisplayValue => "MC:[" +Value + "]";

        protected override bool EqualsCore(MaterialCode other)
        {
            return this.Value == other.Value;
        }
    }
}

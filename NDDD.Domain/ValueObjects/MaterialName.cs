using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MaterialName: ValueObject<MaterialName>
    {
        public MaterialName(string value)
        {
            Value = value;
        }
        public string Value { get; }

        public string DisplayValue => "名称:[" + Value + "]";

        protected override bool EqualsCore(MaterialName other)
        {
            return this.Value == other.Value;
        }
    }
}

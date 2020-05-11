using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed　class MaterialDeliveryPlace : ValueObject<MaterialDeliveryPlace>
    {
        public MaterialDeliveryPlace(string value)
        {
            Value = value;
        }
        public string Value { get; }
        public string DisplayValue => "配送場所:[" + Value + "]";

        protected override bool EqualsCore(MaterialDeliveryPlace other)
        {
            return this.Value == other.Value;
        }
    }
}

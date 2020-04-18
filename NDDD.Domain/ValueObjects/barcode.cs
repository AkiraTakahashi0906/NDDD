using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class Barcode: ValueObject<Barcode>
    {
        public Barcode(string value)
        {
            Value = value;
        }
        public string Value { get; }

        public string DisplayValue => Value;

        protected override bool EqualsCore(Barcode other)
        {
            return this.Value == other.Value;
        }
    }
}

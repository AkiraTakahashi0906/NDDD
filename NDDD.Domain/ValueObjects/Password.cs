using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class Password : ValueObject<Password>
    {
        public Password(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public string DisplayValue => Value + "PW";

        protected override bool EqualsCore(Password other)
        {
            return this.Value == other.Value;
        }
    }
}

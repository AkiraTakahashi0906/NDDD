using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class UserName : ValueObject<UserName>
    {
        public UserName(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public string DisplayValue => Value + "さん";

        protected override bool EqualsCore(UserName other)
        {
            return this.Value == other.Value;
        }
    }
}


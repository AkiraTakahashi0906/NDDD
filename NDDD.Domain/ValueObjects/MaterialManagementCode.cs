using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MaterialManagementCode : ValueObject<MaterialManagementCode>
    {
        public MaterialManagementCode(string value)
        {
            Value = value;
        }
        public string Value { get; }

        protected override bool EqualsCore(MaterialManagementCode other)
        {
            return this.Value == other.Value;
        }
    }
}

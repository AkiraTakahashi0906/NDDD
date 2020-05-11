using NDDD.Domain.Exceptios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Modules.Helpers
{
    public static class Guard
    {
        public static object IsNull(object o, string message)
        {
            if (o == null)
            {
                throw new InputException(message);
            }
            return o;
        }
        public static string IsStringEmpty(string o, string message)
        {
            if (o == String.Empty)
            {
                throw new InputException(message);
            }
            return o;
        }
        public static float IsFloat(string text, string message)
        {
            float floatValue;
            if (!float.TryParse(text, out floatValue))
            {
                throw new InputException(message);
            }
            return floatValue;
        }
    }
}

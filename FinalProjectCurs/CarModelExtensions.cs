using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{
    public static class CarModelExtensions
    {
        public static string Description(this Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute),
                                                       false);
            return attributes.Length == 0
                ? value.ToString()
                : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}

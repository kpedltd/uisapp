using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Helpers
{
    class EnumToStringAttribute : System.Attribute
    {
        private string value;

        public EnumToStringAttribute(string value)
        {
            this.value = value;
        }

        public string Value
        {
            get { return value; }
        }
    }

    public static class EnumToString
    {
        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();
            FieldInfo field = type.GetField(value.ToString());

            EnumToStringAttribute[] attrs = field.GetCustomAttributes(typeof(EnumToStringAttribute), false) as EnumToStringAttribute[];

            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }
}

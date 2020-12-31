using System.ComponentModel;
using foodapp.entity;

namespace foodapp.webui.Extensions
{
    public static class EnumStringValueExtension
    {
        public static string ToDescriptionString(this EnumOrderState val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
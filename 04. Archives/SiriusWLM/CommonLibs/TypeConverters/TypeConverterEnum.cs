using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Globalization;

namespace Sirius.CommonLibs
{
	public class TypeConverterEnum : EnumConverter
	{
		private Type _enumType;

		public TypeConverterEnum(Type type) : base(type)
		{
			_enumType = type;
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
		{
			return destType == typeof(string);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
		{
            string result;
            if (value == null)
            {
                result = "-";
            }
            else
            {
                result = "- Selecteaza -";
                string enumName = Enum.GetName(_enumType, value);
                if (enumName != null)
                {
                    FieldInfo fi = _enumType.GetField(enumName);
                    if (fi != null)
                    {
                        DescriptionAttribute dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
                        if (dna != null)
                        {
                            result = dna.Description;
                        }
                    }
                }
            }
            return result;
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
		{
			return srcType == typeof(string);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			foreach (FieldInfo fi in _enumType.GetFields())
			{
				DescriptionAttribute dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
				if ((dna != null) && ((string)value == dna.Description))
				{
					return Enum.Parse(_enumType, fi.Name);
				}
			}
			return Enum.Parse(_enumType, (string)value);
		}
	}
}

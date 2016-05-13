using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sirius.CommonLibs
{
    public static class EnumsLib
    {
        public static string GetDescription(Enum en)
        {
            string result = en.ToString();
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                result = ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return result;
        }

        public static int GetId(Enum en)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(en);
            }
            catch
            {
            }
            return result;
        }

        public static void PopulateSelectBox<T>(CustomControls.EntitySelectBox selectBox, Enum selectedEnum)
	    {
		    if (typeof(T).IsEnum)
		    {
                Type enumType = typeof(T);
                List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
                foreach (Enum value in Enum.GetValues(enumType))
                {
                    items.Add(new CustomControls.EntityItem(GetId(value), GetDescription(value)));
                }
                selectBox.SetItems(items, GetId(selectedEnum), false);
		    }
	    }

	    public static T GetSelectBoxSelectedEnum<T>(CustomControls.EntitySelectBox selectBox)
	    {
            T result = default(T);

            if ((typeof(T).IsEnum) && (selectBox.SelectedItem != null))
            {
                int id = selectBox.GetSelectedId();
                result = (T)Enum.ToObject(typeof(T), id);
            }
            return result;
	    }
    }
}

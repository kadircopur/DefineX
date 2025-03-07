using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RequiredFieldControl
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class RequiredField : Attribute
    {
        public static bool Verify(object entityToVerify)
        {
            Type typeToVerify = entityToVerify.GetType();
            FieldInfo[] typeFieldsToVerify = typeToVerify.GetFields(
                                                  BindingFlags.Public |
                                                  BindingFlags.Instance);
            foreach (FieldInfo typeField in typeFieldsToVerify)
            {
                object[] requiredFieldAttr = typeField.GetCustomAttributes(typeof(RequiredField), true);
                if (requiredFieldAttr.Length != 0)
                {
                    string fieldValue = typeField.GetValue(entityToVerify) as string;
                    if (string.IsNullOrEmpty(fieldValue))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}

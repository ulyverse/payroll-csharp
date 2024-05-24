using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public static class Helper
    {
        public static string HashToMd5(string text)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }

        public static PropertyInfo[] GetCustomProperties(this Type type)
        {
            return type.GetProperties()
              .Where(pi => !Attribute.IsDefined(pi, typeof(ExcludePropertyAttribute)))
              .ToArray();
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ExcludePropertyAttribute : Attribute
    {
        public ExcludePropertyAttribute() { }
    }
}

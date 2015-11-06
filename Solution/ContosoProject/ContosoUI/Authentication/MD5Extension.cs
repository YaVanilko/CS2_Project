using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.Authentication
{
    public static class MD5Extension
    {
        public static string ToMD5(this string input)
        {
            MD5 md = MD5.Create();
            byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            foreach (var d in data)
	        {
		        sBuilder.Append(d.ToString("x2"));
	        }
            return sBuilder.ToString();
        }
    }
}

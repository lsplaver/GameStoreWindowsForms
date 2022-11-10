using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Validator
    {
        public static string IsPresent(string s)
        {
            string errorMsg = "";
            if (s == null)
            {
                errorMsg = "Field is null";
            }
            else if (s == "") 
            {
                errorMsg = "Field is empty";
            }
            return errorMsg;
        }

        public static string IsEmail(string s)
        {
            string errorMsg = "";
            if (!s.Contains("@"))
            {
                errorMsg = "Not a valid email";
            }
            else
            {
                string[] x = s.Split('@');
                if (x.Length >= 2) 
                { 
                    for (int i = 1; i < x.Length; i++)
                    {
                        if (!x[i].Contains('.'))
                        {
                            errorMsg = "Not a valid email";
                        }
                    }
                }
            }
            
            return errorMsg;
        }
    }
}

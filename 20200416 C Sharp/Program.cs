using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200416_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //object temp_obj_val1 = 10;
            //object temp_obj_val1 = 10f;
            object temp_obj_val1 = (string)"String";

              switch (Convert.GetTypeCode(temp_obj_val1))
              {
                  case TypeCode.Int32:
                      Console.WriteLine("INT32\n");
                      break;
                  case TypeCode.Single:
                      Console.WriteLine("Single\n");
                      break;
                  case TypeCode.String:
                      Console.WriteLine("String\n");
                      break;
                  default:
                      Console.WriteLine("etc\n");
                      break;
              }

            if (temp_obj_val1.GetType() == typeof(int)) Console.WriteLine("INT32\n");
            else if (temp_obj_val1.GetType() == typeof(float)) Console.WriteLine("Single\n");
            else if (temp_obj_val1.GetType() == typeof(string)) Console.WriteLine("String\n");
            else Console.WriteLine("etc\n");
        }
    }
}

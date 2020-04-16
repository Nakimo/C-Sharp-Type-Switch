using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200416_C_Sharp
{
    class Program
    {

        static void TestFN3(params object[] param)
        {
            int sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (param[i].GetType() == typeof(int)) {
                    sum += (int)param[i];
                }
                else if (param[i].GetType() == typeof(string)) {
                    sum += Convert.ToInt32(param[i]);
                }

                Console.Write($"{param[i]}");
                if (i < param.Length - 1) Console.Write(" + ");
            }
            Console.WriteLine($" = {sum}");
        }

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
                      Console.WriteLine("Etc\n");
                      break;
              }

            if (temp_obj_val1.GetType() == typeof(int)) Console.WriteLine("INT32\n");
            else if (temp_obj_val1.GetType() == typeof(float)) Console.WriteLine("Single\n");
            else if (temp_obj_val1.GetType() == typeof(string)) Console.WriteLine("String\n");
            else Console.WriteLine("Etc\n");


            TestFN3(10, 20, "30", 40, "50", "60");
            
        }
    }
}

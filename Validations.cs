using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Validations
    {

        static void Main()
        {
            Console.WriteLine("AAABBBCC");
            int sum = 0;
            int[] i = new int[5];
            Console.WriteLine("Enter Array Values");
            for (int j = 0; j < i.Length; j++)
            {
                i[j] = int.Parse(Console.ReadLine());

                int mo=i[j];
                
                if (mo%7==0)
                {
                    int[] v = new int[5];

                    for (int z = 0; z < v.Length; z++)
                    {
                        v[z] = mo;
                    }
                    sum = sum + i[j];


                    Console.WriteLine("this value can devide by  7 [{0}] = and sum is {1}", i[j], sum);

                }
            }
            //Console.WriteLine("Display Array Values");
            //for (int j = 0; j < i.Length; j++)
            //{
            //    Console.WriteLine("i[{0}]={1}", j, i[j]);



            //}
            
            Console.WriteLine(sum);

            Console.ReadLine();

        }


        
    }
       
}

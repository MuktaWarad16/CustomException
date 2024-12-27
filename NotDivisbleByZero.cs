using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CustomException
{
    public class NotDivisbleByZero : Exception
    {

        public static void meth1()
        {
            try
            {
                int a = 100;

                Console.WriteLine(a / 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

      

        
    }
}

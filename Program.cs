using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise2
{
    public class OurExc : Exception
    {
        public OurExc(string msg):base(msg) {
           
        }
    } 
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter name , email, password to create account");
            try
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                string password = Console.ReadLine();

                if (name.Length < 6)
                {
                    throw new OurExc("Name nust be 6 characters long");
                }
                else if (password.Length < 6)
                {
                    throw new OurExc("Name nust be 6 characters long");

                }
            }
            catch (OurExc ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {

            }

            Console.ReadKey();
         


        }
    }
}

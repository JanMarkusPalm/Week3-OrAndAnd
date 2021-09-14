using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta kasutajatunnus ja seejärel parool");
            string Kasutajatunnus = Console.ReadLine();
            string Kasutajaparool = Console.ReadLine();
            // && V; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi. 
            if (Kasutajatunnus != "admin" || Kasutajaparool != "admin1234")
            {
                Console.WriteLine("Login failed, please try again.");
            }
            else
            {
                Console.WriteLine("Login Success!");
            }
        }
    }
}

using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajalt sisestada kasutaja tunnust
            //programm küsib kasutajalt sisestada parool
            //programm kontrollib, kas mõlemad kasutaja tunnus, kui ka parool on õiged
            //kui mõlemad kasutaja tunnus kui ka parool on õiged, kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus v parool on vale, siis programm kuvab "sisselogimine ebaõnnestus, proovi uuesti."
            //username : admin ; pass : admin1234


            Console.WriteLine("Palun sisesta kasutajatunnus ja seejärel parool");
            string Kasutajatunnus = Console.ReadLine();
            string Kasutajaparool = Console.ReadLine();
                                     // && V; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi. 
            if (Kasutajatunnus == "admin" && Kasutajaparool == "admin1234")
            {
                Console.WriteLine("Login Success!");
            }
            else
            {
                Console.WriteLine("Login failed, please try again.");
            }






        }
    }
}

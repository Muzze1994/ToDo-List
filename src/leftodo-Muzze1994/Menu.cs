using System;

namespace leftodo_Muzze1994
{
    class Menu
    {

        //Method for creating the menu in the console
        public static void PrintMenu()
        {

            Console.WriteLine("\t\t\tVälkommen till din att göra-lista!\n");
            Console.WriteLine("Här får du välja att lista all dina uppgifter, lägga till uppgifter eller arkivera gjorda uppgifter!");
            Console.WriteLine("Du slutför uppgifter genom att skriva in samma siffra som det id uppgiften du lagt till har. Slutförda uppgifter visas med en \u221A.");
            Console.WriteLine("Så vad vill du göra?\n");
            Console.WriteLine("[1] Lägga till ny uppgift");
            Console.WriteLine("[2] Lista alla dagens uppgifter");
            Console.WriteLine("[3] Vill du slutaföra uppgifter");
            Console.WriteLine("[4] Lägg till en uppgift med en deadline");
            Console.WriteLine("[5] Arkivera uppgifter");
            Console.WriteLine("[6] Lista arkiverade uppgifter");
            Console.WriteLine("[7] Avsluta programmet");

        }
    }
}

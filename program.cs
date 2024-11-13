using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

public class Gyaakorals
{
    public static void Main(string[] args)
    {
        int szam;
        int max = 0;
        int menu_kerdopont;
        do
        {

            Console.WriteLine("1.legnagyobb szam\n2.faktorialis\n3.háromszög\n4.0 kilépés");
            menu_kerdopont = Convert.ToInt32(Console.ReadLine());


            while (menu_kerdopont != 0 && menu_kerdopont != 1 && menu_kerdopont != 2 && menu_kerdopont != 3 && menu_kerdopont != 4)
            {
                menu_kerdopont = Convert.ToInt32(Console.ReadLine());
            }


            if (menu_kerdopont == 1)
            {
                int leszamolas = 4;
                szam = 0;
                while (leszamolas != 0)
                {
                    Console.WriteLine("szám:");
                    szam = Convert.ToInt32(Console.ReadLine());

                    if (szam > max)
                    {
                        max = szam;
                    }
                    leszamolas--;
                }
                Console.WriteLine("\nlegnagyobb szám: " + max + "\n");
            }
            else if (menu_kerdopont == 2)
            {
                {
                    Console.WriteLine("minek a faktorialisat akarod kiszamolni?: ");
                    szam = Convert.ToInt32(Console.ReadLine());
                    int Faktorialis(int n) => (n <= 1) ? 1 : n * Faktorialis(n - 1);
                    Console.WriteLine("");
                    Console.WriteLine(Faktorialis(szam));
                    Console.WriteLine("");
                }
            }

            else if (menu_kerdopont == 3)
            {
                Console.WriteLine("elso oldal oldal:");
                int szam1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("masodik oldal:");
                int szam2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("harmadik oldal:");
                int szam3 = Convert.ToInt32(Console.ReadLine());

                int kerulet = szam1 + szam2 + szam3;
                Console.WriteLine("negyzet kerulete: " + kerulet);

                if (szam1 + szam2 > szam3 && szam1 + szam3 > szam2 && szam2 + szam3 > szam1)
                {
                    Console.WriteLine("\nLehet belöle háromszög\n");
                }
                else
                {
                    Console.WriteLine("\nnem lehet belöle háromszög\n");
                }

            }

        }
        while (menu_kerdopont != 0);
    }
}
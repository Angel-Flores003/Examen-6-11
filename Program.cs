using System;

public class Program
{
    public static void Main()
    {
        const string MsgInpu = "Introdueix un número (0 per sortir): ";
        const string MsgError = "Error";
        const string MsgDiv = "Els números divisors de {0} són: ";
        const string MsgEndProg = "Programa finalitzat.";
        int num = 1;
        do
        {
            try
            {
                Console.Write(MsgInpu);
                num = Int32.Parse(Console.ReadLine());                                
                if (num != 0)
                {
                    Console.Write(MsgDiv, num);
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(MsgEndProg);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgError);
            }
        } while (num != 0);         
    }
}
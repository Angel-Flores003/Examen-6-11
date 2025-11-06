using System;
public class Program
{
    public static void Main()
    {
        const string MsgINpput = "Introdueix el número secret del nivell:";
        const string DoorsGenerated = "S'han generat {0} portes.";
        const string MsgDoorsAbleOpen = "Pots obriri les portes: ";
        const string MsgError = "Error";
        int secNum = 1, doors, multi = 1;
        Random rand = new Random();
       
        try
        {
            Console.WriteLine(MsgINpput);
            secNum = Int32.Parse(Console.ReadLine());
            if (secNum > 0)
            {
                doors = rand.Next(5, 16);
                Console.WriteLine(DoorsGenerated, doors);
                Console.Write(MsgDoorsAbleOpen);
                for (int i = 1; i <= doors; i++)
                {
                    if (secNum * multi == i )
                    {
                        Console.Write(i + " ");
                        multi++;
                    }
                }                
            }                
        }
        catch (FormatException)
        {
            Console.WriteLine(MsgError);
        }        
    }
}
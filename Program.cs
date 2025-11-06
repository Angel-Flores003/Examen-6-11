using System;

public class Program
{
    public static void Main()
    {
        const string MsgCoinFound = "You found a coin";
        const string MsgFoundTrap = "You found a trap";
        const string MsgWin = "You've won!";
        const string MsgLost = "You've lost!";        
        const int MaxCoins = 5;        
        int lives = 3, coins = 0, prob;
        Random rand = new Random();        

        do
        {
            prob = rand.Next(1, 11);
            if (prob <= 3)
            {
                Console.WriteLine(MsgFoundTrap);
                lives--;
                Console.WriteLine($"Now you have {lives} lives");
                Thread.Sleep(1000);
            }
            if (lives > 0)
            {
                prob = rand.Next(1, 11);
                if (prob <= 5)
                {
                    Console.WriteLine(MsgCoinFound);
                    coins++;
                    Console.WriteLine($"Now you have {coins} coins");
                    Thread.Sleep(1000);
                }
            }                        
        } while (lives > 0 && coins != MaxCoins);
        if (coins == MaxCoins)
        {
            Console.WriteLine(MsgWin);
        }
        else
        {
            Console.WriteLine(MsgLost);
        }
    }
}

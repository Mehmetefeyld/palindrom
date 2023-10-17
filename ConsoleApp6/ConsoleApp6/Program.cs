using System;

class ATM
{
    static double accountBalance = 1000;

    static void Main()
    {


        Console.Write("Bir kelime giriniz: ");
        string word = Console.ReadLine();

        if (IsPalindrome(word))
        {
            Console.WriteLine(word + "     palindrom!");
        }
        else
        {
            Console.WriteLine(word + "    palindrom DEĞİL!");
        }

        Console.ReadKey();
    }

    static bool IsPalindrome(string word)
    {
        int length = word.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}
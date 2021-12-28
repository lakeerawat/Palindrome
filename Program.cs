using System;
using System.Text;

public class Palindrome
{
    public static void Main(string[] args)
    {
        (bool, int) IsPalindrome(string thestr)
        {
            string strinput;
            strinput = thestr.ToUpper();
            var sb = new StringBuilder();
            foreach (char c in strinput)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            strinput = sb.ToString();
            int i = 0, j = strinput.Length - 1;
            while (i <= j)
            {
                if (strinput[i] != strinput[j])
                {
                    return (false, 0);
                }
                i++;
                j--;
            }
            return (true, thestr.Length);
        }

        string inputstr = "";
        (bool b, int l) result;
        Console.WriteLine("Type the input");
        while (inputstr != "exit")
        {
            inputstr = Console.ReadLine();
            if (inputstr != "exit")
            {
                result = IsPalindrome(inputstr);
                Console.WriteLine($"Status {result.b}, The length of string {result.l}");
            }
            break;
        }
        Console.ReadLine();
    }
}
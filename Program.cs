using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace Task22._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək.

            //Console.WriteLine("Text:");
            //string text = Console.ReadLine();
            //string output = "";

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //    {
            //        output += text[i];
            //    }
            //}
            //Console.WriteLine(output);




            //Task2. Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram.  

            //string word = "reqemler";
            //char letter = 'e';
            //int count = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (letter == word[i])
            //    {
            //        count++;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("Bu herf sozde yoxdur.");
            //}
            //else
            //{
            //    Console.WriteLine($"Bu herf sozde {count} defe istirak etmisdir.");
            //}





            //Task3. Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram (Misalçün
            //verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır. 

            //string text = "   salam necesen?   ";
            //char element = ' ';
            //bool bosluq = true;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ' ')
            //    {
            //    text = text.Remove(i, 1); 
            //        continue;
            //    }
            //}
            //if (bosluq)
            //{
            //    Console.WriteLine(text);
            //}
            //else
            //{
            //    Console.WriteLine(text);
            //}




            //Task 6.

            //string word = "SALAM";
            //char letter = 'A';
            //int count = 0;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (letter == word[i])
            //    {
            //        count++;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("Bu herf sozde yoxdur.");
            //}
            //else
            //{
            //    Console.WriteLine($"{letter} herfi sozde {count} defe istirak etmisdir.");
            //}

        }
    }
}

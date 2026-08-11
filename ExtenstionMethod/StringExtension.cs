using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.ExtenstionMethod
{
    public static class StringExtension
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greated than or equal to 0");

            if (numberOfWords == 0)
                return "";

            var words=str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;
            return string.Join(" ", words.Take(numberOfWords));
        }
    }

    /*
     *  internal class Program
    {

        static void Main(string[] args)
        {
            string post = "This is supposed to be avery long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }


    }
     */
}

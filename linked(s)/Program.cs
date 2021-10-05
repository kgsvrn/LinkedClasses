using System;

namespace linked_s_
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> one = new LinkedList<int>();
            one.Append(9);
            one.Append(11);
            one.Append(93);
            one.Append(1221);
            LinkedList<string> two = new LinkedList<string>();
            two.Append("safasdfas");
            two.Append("ffffff");
            two.Append("qwerty");
            two.Append("wwwww");

            foreach (var i in one)
            {
               
                Console.WriteLine(i);
            }
            foreach (var i in two)
            {

                Console.WriteLine(i);
            }
        }
    }
}

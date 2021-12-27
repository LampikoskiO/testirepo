using System;

namespace Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int sanap = 0;
            string[] tervehdys = new string[] {"mo", "moi", "hei", "haloo"};
            for (int i = 0; i < tervehdys.Length; i++) {
                sanap = tervehdys[i].Length;
              //  Console.WriteLine(sanap);
                if (sanap >= 3){
                Console.WriteLine(tervehdys[i]);
                }
            }
        }
    }
}
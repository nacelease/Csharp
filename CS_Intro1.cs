using System;

namespace CS_Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string Mia = "NaC" + "elease";
            string Nasa = " love pineapples.";
            string Nasa1 = "love reading.";
            string Nasa2 = "Edgar Allen Poe.";
            string Nasa3 = "100 Years by Five for Fighting.";
            String Nasa4 = "Pizza";
            
            int Sa = 555;
            float Ba = 20;
            double We = 00055;
            bool Ss = true;

            const string Key = "Min + No";
            const int Sea = 20;
            const float Fall = 40;
            const double Hg = 500;
            const bool Ja = true;

            Console.WriteLine(Mia);
            Console.WriteLine(Sa);
            Console.WriteLine(Ba);
            Console.WriteLine(We);
            Console.WriteLine(Ss);

            string concat = Mia + "" + Sa;
            Console.WriteLine(concat);

            string concat1 = concat + "" + Mia;
            Console.WriteLine(concat1);

            float seasaw = 20;
            float oo = seasaw * Ba;
            Console.WriteLine(oo);

            Console.WriteLine("My name is{0}.I really{1}, and I also {2}",Mia,Nasa1,Nasa);

            Console.WriteLine("My favorite author is{0}. My favorite song is {1}. My favorite food is {2}.", Nasa2, Nasa3, Nasa4);
            

        }
    }
}

 
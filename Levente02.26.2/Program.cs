using System;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {   string path = @"C:\Users\User\Downloads\e_inffor_17maj_fl\valaszok.txt";
            if(!File.Exists(path))
            {
                Console.WriteLine("Nem talhato fajl");
            }else
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                    Console.WriteLine(line);
                string helyes = lines[0];

                string[] valaszok = new string[lines.Length-1];
                string[] nevek = new string[lines.Length - 1];

                for(int i=1; i<lines.Length; i++)
                {
                    int szokozhelye = lines[i].IndexOf(" ");

                    valaszok[i] = lines[i].Substring(szokozhelye+1);
                    nevek[i] = lines[i].Substring(0, szokozhelye);
                    Console.WriteLine(szokozhelye);
                    Console.WriteLine(valaszok[i]);
                    Console.WriteLine(nevek[i]);
                }
            }
            

        }
    }
}
using System;

namespace HomeworkWeek9
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach(char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }return true;
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach(char nucleotide in halfDNASequence)
            {
                result +="TAGC"["ATCG".IndexOf(nucleotide)];
            }return result;
        }
        static void Main(string[] args)
        {
            string DNA;
            bool IsValid;
            int Q1 = 1;
            while (Q1 == 1)
            {
                Console.Write("Input DNA:");
                DNA = Console.ReadLine();
                IsValid = IsValidSequence(DNA);
                if (IsValid == true)
                {
                    Console.WriteLine("Current half DNA sequence:{0}", DNA);
                    Console.WriteLine("Do you want to replicate it? (Y/N):");
                    Char Answer = Char.Parse(Console.ReadLine());
                    int Q2 = 1;
                    while (Q2 == 1)
                    {
                        if (Answer == 'Y')
                        {
                            string Answer2;
                            Answer2 = ReplicateSequence(DNA);
                            Console.WriteLine("Replicated half DNA sequence:{0}",Answer2);
                        }
                        Q2 = 2;
                        if (Answer == 'N')
                        {
                            Q2 = 2;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                            Answer = Char.Parse(Console.ReadLine());
                        }
                    }
                }
                if (IsValid == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                Console.WriteLine("Do you want to process another sequence ? (Y/N)");
                Char Answer3 = Char.Parse(Console.ReadLine());
                int Q3 = 1;
                while (Q3 == 1)
                {
                    if (Answer3 == 'Y')
                    {
                        Q3 = 2;
                    }else if (Answer3 == 'N')
                    {
                        Q3 = 2;
                        Q1 = 2;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Answer3 = char.Parse(Console.ReadLine());
                    }
                }
            }Console.ReadLine();
        }
    }
}


        
            /* static void Main(string[] args)
             {
                 int num, n;
                 num = int.Parse(Console.ReadLine());
                 n = num;
                 while (num > 0)
                 {
                     fo
                 }
             }*/
        

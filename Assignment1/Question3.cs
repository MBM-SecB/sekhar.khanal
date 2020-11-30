using System;

    public class Ques3
    {
        // static void Main3(string[] args)
        // {
        //     Ques3 p = new Ques3();
        //     p.GetInitials();
        // }

        public void GetInitials()
        {
            Console.Write("Enter two words separated by space: ");
            string s = Console.ReadLine();
            string[] output = s.Split(' ');
             if(output.Length!=2)
                {
                Console.WriteLine("Please enter only two words.");
                }
            
            foreach (string a in output)
            {
            
                    Console.Write(a[0]);
                }
            }

        }

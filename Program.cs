using System;

namespace Csharp_New_Driving_License
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            program();
        }
        public static void program()
        {
            try {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("How many agents?");
            int number_agents = Int32.Parse(Console.ReadLine());
            Console.WriteLine("First name of the other people (Separated by Space)");
            string names = Console.ReadLine();
            names = names + " " + name;
            license(name, number_agents, names);
            }
            catch (Exception x)
            {
                program();
            }
        }
        public static void license(string name, int number_agents, string names)
        {
            string[] array_names = names.Split(' ');
            Array.Sort(array_names);
            int array_length = array_names.Length;
            int my_position = Array.FindIndex(array_names, item => item == name) + 1;
            int serving = array_length / number_agents;
            int minutes = 0;
            for (int it = 1; it < serving; it++)
            {
                if (it < my_position)
                {
                    minutes = minutes + 20;
                }
                else if (it == my_position)
                {
                    minutes = minutes + 20;
                }
            }
            Console.WriteLine(minutes);
        }
    }
}
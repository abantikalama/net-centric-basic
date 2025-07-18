using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Employee Skill Tracker---\n");

            string[][] employeeSkills = new string[3][];
            employeeSkills[0] = new string[] { "AWS", "SQL", "Docker" };
            employeeSkills[1] = new string[] { "Python", "SQL" };
            employeeSkills[2] = new string[] { "C#", "Azure", "JavaScript" };

            string[] employeeNames = { "Abantika", "Kyurisha", "Nikita" };

            int[,] proficiencyLevels = new int[3, 4]
            {
                { 5, 5, 3, 0 },
                { 5, 4, 0, 0 },
                { 3, 5, 4, 0 }
            };

            Console.WriteLine("Employee Skills (Jagged Array):");
            for (int i = 0; i < employeeSkills.Length; i++)
            {
                Console.Write($"- {employeeNames[i]}: ");
                for (int j = 0; j < employeeSkills[i].Length; j++)
                {
                    Console.Write($"{employeeSkills[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nProficiency Matrix (Multi-Dimensional Array):");
            Console.Write($"{"Employee",-10}");//-10 is for aligning the output to the left
            for (int j = 0; j < employeeSkills[0].Length; j++)
            {
                Console.Write($"{employeeSkills[0][j],-10}");
            }
            Console.WriteLine();

            for (int i = 0; i < proficiencyLevels.GetLength(0); i++)
            {
                Console.Write($"{employeeNames[i],-10}");
                for (int j = 0; j < proficiencyLevels.GetLength(1); j++)
                {
                    if (proficiencyLevels[i, j] != 0)
                        Console.Write($"{proficiencyLevels[i, j],-10}");
                    else
                        Console.Write($"{"-",-10}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
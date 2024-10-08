using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean keepPlanning = true;
            do
            {
                Console.WriteLine("Welcome to the Student Planner! What would you like to track assignments, internship applications, or events? Enter A for assignments, I for internships, E for events, S to stop using the app!");
                String plannerType = Console.ReadLine().ToUpper();
                if (plannerType.Equals("L"))
                {
                    keepPlanning = false;
                    break;
                }

            }
            while (keepPlanning);

        }

        static void AssignmentTracking()
        {
            Console.WriteLine("How many assignments do you have to enter?");
            String[] assignmentNames = new String[Convert.ToInt32(Console.ReadLine())];
            int[] assignmentDates = new int[Convert.ToInt32(Console.ReadLine())];
            int i = 0;
            while (i < assignmentNames.Length)
            {
                Console.WriteLine("Enter the name of the assignment ");
                assignmentNames[i] = Console.ReadLine();
            }
        }

        static void InternshipTracking()
        {

        }

        static void EventTracking()
        {

        }
    }
}
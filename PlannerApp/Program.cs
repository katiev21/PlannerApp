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
                Console.Write("Welcome to the Student Planner! What would you like to track assignments, internship applications, or events? Enter A \nfor assignments, I for internships, E for events, S to stop using the app! ");
                String plannerType = Console.ReadLine().ToUpper();
                if (plannerType.Equals("S"))
                {
                    keepPlanning = false;
                    break;
                }
                else if (plannerType.Equals("A"))
                {
                    AssignmentTracking();
                }
                else if (plannerType.Equals("I"))
                {
                    InternshipTracking();
                }

            }
            while (keepPlanning);

        }

        static void AssignmentTracking()
        {
            Console.Write("How many assignments do you have to enter?");
            int totalAssignments = Convert.ToInt32(Console.ReadLine());
            String[] assignmentNames = new String[totalAssignments];
            int[] assignmentDates = new int[totalAssignments];
            int i = 0;
            while (i < assignmentNames.Length)
            {
                Console.Write("Enter the name of the assignment: ");
                assignmentNames[i] = Console.ReadLine();
                Console.Write("Enter the how many days until the assignment is due: ");
                assignmentDates[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for (int j = 0; j < assignmentNames.Length; j++)
            {
                Console.WriteLine(assignmentNames[j] + " - due in " + assignmentDates[j] + " days");
            }
            Console.WriteLine();
        }

        static void InternshipTracking()
        {
            Console.Write("How many applicatinos do you have to enter?");
            int totalApplications = Convert.ToInt32(Console.ReadLine());
            String[] applicationNames = new String[totalApplications];
            String [] internshipTypes = new String[totalApplications];
            int[] applicationsDates = new int[totalApplications];
            int i = 0;
            while (i < applicationNames.Length)
            {
                Console.Write("Enter the name of the internship: ");
                applicationNames[i] = Console.ReadLine();
                Console.Write("Enter what field or department the internship is under: ");
                internshipTypes[i] = Console.ReadLine();
                Console.Write("Enter the how many days until the assignment is due: ");
                applicationsDates[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for (int j = 0; j < applicationNames.Length; j++)
            {
                Console.WriteLine(applicationNames[j] + " internship of " + internshipTypes[j] + " due in " + applicationsDates[j] + " days");
            }
            Console.WriteLine();
        }

        static void EventTracking()
        {

        }
    }
}
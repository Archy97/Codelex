using System;

namespace TeacherLessonTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courseNames = new string[]
            {
                "English III",
                "Precalculus",
                "Music Theory",
                "Biotechnology",
                "Principles of Technology I",
                "Latin II",
                "AP US History",
                "Business Computer Information Systems"
            };

            string[] teacherNames = new string[]
            {
                "Ms. Lapan",
                "Mrs. Gideon",
                "Mr. Davis",
                "Ms. Palmer",
                "Ms. Garcia",
                "Mrs. Barnett",
                "Ms. Johannessen",
                "Mr. James"
            };

            string repeatedString = new string('-', 61);
            Console.WriteLine("+" + repeatedString + "+");

            for (int i = 0; i < courseNames.Length; i++)
            {
                string courseColumn = courseNames[i].PadRight(37);
                string teacherColumn = teacherNames[i].PadRight(15);

                Console.WriteLine($"| {i + 1} | {courseColumn} | {teacherColumn} |");
            }

            Console.WriteLine("+" + repeatedString + "+");
        }
    }
}
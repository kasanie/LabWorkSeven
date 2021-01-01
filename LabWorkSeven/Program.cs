using System;

namespace LabWorkSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            Student.NewStudent(students);

            Console.WriteLine(" Полный список студентов:");

            for (int i = 0; i < students.Length; i++)
            {
                if (students.GetValue(i) == null)
                    break;
                students[i].AllStudents();
            }
            Console.WriteLine("Список студентов, имеющих только отличные оценки:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students.GetValue(i) == null)
                    break;
                students[i].ExcellentStudents();
            }
            Console.WriteLine("Cписок студентов, имеющих хотя бы одну неудовлетворительную оценку:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students.GetValue(i) == null)
                    break;
                students[i].BadStudents();
            }
        }
    }
    class Student
    {
        string fullName;
        string score1;
        string score2;


        public Student(string fullName, string score1, string score2)
        {
            this.fullName = fullName;
            this.score1 = score1;
            this.score2 = score2;
        }
        public static void NewStudent(Student[] array)
        {
            for (int num = 0; num < array.Length; num++)
            {
                Console.WriteLine($"Введите ФИО {num + 1}-го студента: ");
                string fullName = Console.ReadLine();
                Console.WriteLine($"Введите оценку {num + 1}-го студента по программированию: ");
                string score1 = (Console.ReadLine());
                Console.WriteLine($"Введите оценку {num + 1}-го студента по математике: ");
                string score2 = (Console.ReadLine());
                array[num] = new Student(fullName, score1, score2);
                for (; ; )
                {
                    if (num + 1 == array.Length)
                    { break; }
                    Console.WriteLine("Ввести данные еще одного студента? (Enter - да/Escape - нет)");
                    break;
                }
                if (num + 1 == array.Length)
                { break; }
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                { break; }
            }
        }
        public void AllStudents()
        {
            Console.WriteLine($"Студент {fullName.ToUpper()}");
        }
        public void ExcellentStudents()
        {
            var intscore1 = int.Parse(score1);
            var intscore2 = int.Parse(score2);
            if (intscore1 == 5 && intscore2 == 5)
            {
                Console.WriteLine($"Студент {fullName.ToUpper()}");
            }
        }
        public void BadStudents()
        {
            var intscore1 = int.Parse(score1);
            var intscore2 = int.Parse(score2);
            if (intscore1 <= 2 || intscore2 <= 2)
            {
                Console.WriteLine($"Студент {fullName.ToUpper()}");
            }
        }
    }
}
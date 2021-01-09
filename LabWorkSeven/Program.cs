using System;

namespace LabWorkSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            var count = Student.NewStudent(students);
            Console.WriteLine(" Полный список студентов:");
            for (int i = 0; i < count; i++)
            {
                students[i].AllStudents();
            }
            Console.WriteLine("Список студентов, имеющих только отличные оценки:");
            for (int i = 0; i < count; i++)
            {
                students[i].ExcellentStudents();
            }
            Console.WriteLine("Cписок студентов, имеющих хотя бы одну неудовлетворительную оценку:");
            for (int i = 0; i < count; i++)
            {
                students[i].BadStudents();
            }
        }
    }
    class Student
    {
        string fullName;
        int score1;
        int score2;

        public Student(string fullName, int score1, int score2)
        {
            this.fullName = fullName;
            this.score1 = score1;
            this.score2 = score2;
        }
        public static int NewStudent(Student[] array)
        {
            var countOfStudents = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите ФИО {i + 1}-го студента: ");
                string fullName = Console.ReadLine();
                Console.WriteLine($"Введите оценку {i + 1}-го студента по программированию: ");
                int score1 = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Введите оценку {i + 1}-го студента по математике: ");
                int score2 = (Convert.ToInt32(Console.ReadLine()));
                array[i] = new Student(fullName, score1, score2);
                countOfStudents++;
                for (; ; )
                {
                    if (countOfStudents == array.Length)
                    { break; }
                    Console.WriteLine("Ввести данные еще одного студента? (Enter - да/Escape - нет)");
                    break;
                }
                if (countOfStudents == array.Length)
                { break; }
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                { break; }
            }
            return countOfStudents;
        }
        public void AllStudents()
        {
            Console.WriteLine($"Студент {fullName.ToUpper()}");
        }
        public void ExcellentStudents()
        {
            var intscore1 = score1;
            var intscore2 = score2;
            if (intscore1 == 5 && intscore2 == 5)
            {
                Console.WriteLine($"Студент {fullName.ToUpper()}");
            }
        }
        public void BadStudents()
        {
            var intscore1 = score1;
            var intscore2 = score2;
            if (intscore1 <= 2 || intscore2 <= 2)
            {
                Console.WriteLine($"Студент {fullName.ToUpper()}");
            }
        }
    }
}
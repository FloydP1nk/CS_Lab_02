using System;

namespace Lab_02
{
    public class ClassRoom
    {
        private Pupil[] classStudents;

        public Pupil[] ClassStudents
        {
            get { return classStudents; }
        }

        public ClassRoom(params Pupil[] students)
        {
            if (students.Length < 2 || students.Length > 4)
            {
                throw new ArgumentException("В классе должно быть от 2 до 4 учеников");
            }

            classStudents = students;
        }

        public void printClassroomInfo()
        {
            foreach (Pupil pupil in ClassStudents)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Информация об ученике: {pupil.GetType().Name}");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine("------------------------------");
            }
        }
    }
}
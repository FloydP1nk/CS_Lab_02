namespace Lab_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pupil pupil1 = new ExcellentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.printClassroomInfo();
        }
    }
}
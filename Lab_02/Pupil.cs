using System;

namespace Lab_02
{
    public class Pupil
    {
        public virtual void Study()
        {
        }

        public virtual void Read()
        {
        }

        public virtual void Write()
        {
        }

        public virtual void Relax()
        {
        }
    }

    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"ExcelentPupil study");
        }

        public override void Read()
        {
            Console.WriteLine($"ExcelentPupil read");
        }

        public override void Write()
        {
            Console.WriteLine($"ExcelentPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine($"ExcelentPupil relax");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"GoodPupil study");
        }

        public override void Read()
        {
            Console.WriteLine($"GoodPupil read");
        }

        public override void Write()
        {
            Console.WriteLine($"GoodPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine($"GoodPupil relax");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"BadPupil study");
        }

        public override void Read()
        {
            Console.WriteLine($"BadPupil read");
        }

        public override void Write()
        {
            Console.WriteLine($"BadPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine($"BadPupil relax");
        }
    }
}
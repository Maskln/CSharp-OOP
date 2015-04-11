namespace School
{
    public class Student : People, ICommentable
    {


        public Student(string name, uint uniqueClassNumb)
            : base(name)
        {
            this.UniqueClassNumb = uniqueClassNumb;
        }


        public uint UniqueClassNumb { get; private set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Student name: {0}, UN: {1}",this.Name, this.UniqueClassNumb);
        }

    }
}

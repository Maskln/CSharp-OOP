namespace School
{
    public class Teacher : People, ICommentable
    {
      
        public Teacher(string name)
          : base(name)
        {
          
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Teacher: {0}", this.Name);
        }
    }
}

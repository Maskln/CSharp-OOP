namespace School
{
    public class Class : Student, ICommentable
    {
        
        public Class(string name, uint uniqueClassNumb, string uniqueClassIdentifier) 
            : base(name, uniqueClassNumb)           

        {
            this.UniqueClassIdentier = uniqueClassIdentifier;  
        }
        
        public string UniqueClassIdentier { get; private set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Student name: {0}, UN: {1}, Class: {2}", this.Name, this.UniqueClassNumb, this.UniqueClassIdentier);
        }
    }
}

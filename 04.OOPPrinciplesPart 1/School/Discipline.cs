namespace School
{
    public class Discipline : Teacher, ICommentable
    {
        
        public Discipline(string name, string disciplineName, uint numbersOfLecture, uint numbersOfExercise)
            :base(name)
        {
            this.DisciplineName = disciplineName;
            this.NumbersOfLecture = numbersOfLecture;
            this.NumbersOfExercise = numbersOfExercise;
        }


        public string DisciplineName { get; private set; }

        public uint NumbersOfLecture { get; private set; }

        public uint NumbersOfExercise { get; private set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("Teacher: {0}, Discipline: {1}, Numbers of lectures: {2}, Numbers of exercises: {3}", this.Name, this.DisciplineName, this.NumbersOfLecture, this.NumbersOfExercise);
        }

       
    }
}

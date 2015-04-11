namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable
    {

        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress, string mobileNumber,
            string course, Specialty speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobileNumber = mobileNumber;
            this.Course = course;
            this.Specialty = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int Ssn { get; private set; }

        public string PermanentAddress { get; private set; }

        public string MobileNumber { get; private set; }

        public string Course { get; private set; }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }


        //Overrides

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.Ssn.Equals((obj as Student).Ssn)) return false;
            if (!this.MobileNumber.Equals((obj as Student).MobileNumber)) return false;
            if (!this.PermanentAddress.Equals((obj as Student).PermanentAddress)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            int valueHash = 5;

            valueHash = (valueHash * 5) + this.Ssn.GetHashCode();

            return valueHash;
        }

        public static bool operator ==(Student firstSudent, Student secondStudent)
        {
            return firstSudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }

        public override string ToString()
        {
            return string.Format("Student Info: \n-------------\nName: {0} {1} {2};\nSSN: {3};\nAddress: {4}; \nTel: {5}; \nCourse: {6}; \nSpeciality: {7}; \nUniversity: {8}; \nFaculty: {9};",
                                this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress, this.MobileNumber,
                                this.Course, this.Specialty, this.University, this.Faculty);
        }

        // Problem 2

        #region ICloneable Members

        public object Clone()
        {
            Student cloning = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress,
                              this.MobileNumber, this.Course, this.Specialty, this.University, this.Faculty);

            return cloning;
        }

        #endregion

        //Problem 3

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }

            if (this.Ssn.CompareTo((obj as Student).Ssn) != 0)
            {
                return this.Ssn.CompareTo((obj as Student).Ssn);
            }

            return 0;
        }

        #endregion
    }
}

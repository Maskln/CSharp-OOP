using System;
using System.Text;

namespace _01.DefineClass
{
    public class Call
    {
        private string dateOfCall;
        private string timeOfCall;
        private string dialledNumber;
        private uint durationCall;


        public Call(string dateOfCall, string timeOfCall, string dialledNumber, uint durationCall)
        {
            this.dateOfCall = dateOfCall;
            this.timeOfCall = timeOfCall;
            this.dialledNumber = dialledNumber;
            this.durationCall = durationCall;
        }

        public string DateOfCall
        {
            get { return dateOfCall; }
        }

        public string TimeOfCall
        {
            get { return timeOfCall; }
        }

        public string DialledNumber
        {
            get { return dialledNumber; }
        }

        public uint DurationCall
        {
            get { return durationCall; }
            set { durationCall = value; }
        }

        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendFormat("Call Information");
            information.AppendFormat("-----------------");
            information.AppendFormat("Date of Call: {0}", this.dateOfCall);
            information.AppendFormat("Time of Call: {0}", this.timeOfCall);
            information.AppendFormat("Dialled Number: {0}", this.dialledNumber);
            information.AppendFormat("Duration Of Call: {0}", this.durationCall);
           
            return information.ToString();
        }
    }
}

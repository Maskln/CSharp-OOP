using System;


namespace Structure
{



    //Problem 11

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public string Version { get; set; }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }

   

}

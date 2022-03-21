using System;

namespace MidtermProject
{
    public class Manager : Employee
    {
        public string firstName;
        public string lastName;
        public string department;
        public string region;

        public Manager(string getFirstName, string getLastName, string id, string getDepartment, string getRegion) : base(getFirstName, getLastName, id, EmployeeType.Manager) 
        {
            firstName = getFirstName;
            lastName = getLastName;
            department = getDepartment;
            region = getRegion;
        }
        public void setFirstName(string First)
        {
            this.firstName = First;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public void setLastName(string Last)
        {
            this.lastName = Last;
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public void setDepartment(string Dep)
        {
            this.department = Dep;
        }
        public string getDepartment()
        {
            return this.department;
        }
        public void setRegion(string Region) 
        {
            this.region = Region;
        }
        public string getRegion()
        {
            return this.region;
        }
    }
}

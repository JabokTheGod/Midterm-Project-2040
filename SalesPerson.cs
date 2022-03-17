using System;

namespace MidtermProject
{
    public class SalesPerson : Employee
    {
        private string department { get; }
        private float totalSales { get; }

        public SalesPerson(string firstName, string lastName, string id, string getDepartment, float getSales) : base(firstName, lastName, id, EmployeeType.Sales) 
        {
            department = getDepartment;
            totalSales = getSales;
        }

    }
}

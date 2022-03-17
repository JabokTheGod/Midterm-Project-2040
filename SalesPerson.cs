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

        public void updateSales()
        {  
            float value = 0.0f;
            float updatedSales = totalSales + value;
        }

    }
}

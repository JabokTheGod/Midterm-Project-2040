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
        public void updateSales(float value)
        {  
            float totalSales = this.totalSales + value;
        }
        public float getSales() 
        {
            float output = this.totalSales;
            return output;
        }
        //Enumerator
        public enum SalesLevel
        {
            Platinum,
            Diamond,
            Gold,
            Silver,
            Bronze
        }
        public SalesLevel GetSalesLevel()
        {
            if (this.totalSales >= 40000) 
            {
                return SalesLevel.Platinum;
            }
            else if (this.totalSales <= 39999.99 && this.totalSales >= 30000)
            {
                return SalesLevel.Diamond;
            }
            else if (this.totalSales <= 29999.99 && this.totalSales >= 20000)
            {
                return SalesLevel.Gold;
            }
            else if (this.totalSales <= 19999.99 && this.totalSales >= 10000)
            {
                return SalesLevel.Silver;
            }
            else
            {
                return SalesLevel.Bronze;
            }
        }
    }
}

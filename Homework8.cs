using System.Runtime.InteropServices.Marshalling;
using System.Web;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };
    

        TotalCredits(customer_list);
        //call Q1 method

        AmarilloAverageAge(customer_list);
        //call Q2 method

        CanyonAge(customer_list);
        //call Q3 method
    }
    //Q1 create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list)
    {
        //to be implemented
        double TotalCredits = 0;
        foreach (Customer c in customer_list)
        {
            TotalCredits += c.customerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {TotalCredits} ");
    }

    //Q2 create a method to calculate and print the average age of customers living in amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        //to be implemented
        double totalAge = 0;
        int count = 0;

        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                totalAge += c.customerAge;
                count++;
            }
        }
        double average = totalAge / count;
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {average}");
    }
    //Q3 create a method to print the names of customers who live in canyon and are older than 30
    public static void CanyonAge(Customer[] customer_list)
    {
        //to be implemented
        List<string> names = new List<string>();

        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Canyon" && c.customerAge > 30)
            {
                names.Add(c.customerName);
            }
        }
        Console.WriteLine($"Q3: Customers who live in Canyon and over 30 years old: {string.Join(",", names)} ");
    }
    //Q0: create a class called customer
    public class Customer
    {
        //to be implemented
        public string customerName { get; set; }
        public double customerAge { get; set; }
        public string customerCity { get; set; }
        public double customerCredit { get; set; }
        
        //constructor
        public Customer(string customerName, double customerAge, string customerCity, double customerCredit)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerCity = customerCity;
            this.customerCredit = customerCredit;
        }
    }

}

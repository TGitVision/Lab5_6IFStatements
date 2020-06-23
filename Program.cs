using System;

namespace Lab5_6IFStatements
{
    class Program
    {
        struct Customer
        {
            public enum MembershipType 
            { 
                standard,
                premium
            }

            public bool canShopOnlineForAlcohol;
            public MembershipType membershipType;
            public DateTime birthDate;
            public int age;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_6IFStatements!");

            // Company: World of Beer

            // Bus rule: Under 21 can't shop online

            // Customer 1 - Underage
            Customer customer1 = new Customer();
            customer1.birthDate = Convert.ToDateTime("6/23/2005");
            customer1.age = CalculateAge(customer1.birthDate);
            customer1.membershipType = Customer.MembershipType.standard;
            customer1.canShopOnlineForAlcohol = customer1.age >= 21 ? true : false;

            if (customer1.canShopOnlineForAlcohol != true)
            {
                Console.WriteLine($"Customer1 is {customer1.age} and is underage. Customer1 has a {customer1.membershipType} membership.");
            }
            else 
            {
                Console.WriteLine($"Customer1 is {customer1.age} and is of legal age. Customer1 has a {customer1.membershipType} membership.");
            }

            // Customer 2 - Legal age but not a premium member
            Customer customer2 = new Customer();
            customer2.birthDate = Convert.ToDateTime("2/23/1998");
            customer2.age = CalculateAge(customer2.birthDate);
            customer2.membershipType = Customer.MembershipType.standard;
            customer2.canShopOnlineForAlcohol = customer2.age >= 21 ? true : false;

            if (customer2.canShopOnlineForAlcohol != true)
            {
                Console.WriteLine($"Customer2 is {customer2.age} and is underage. Customer2 has a {customer2.membershipType} membership.");
            }
            else
            {
                Console.WriteLine($"Customer2 is {customer2.age} and is of legal age. Customer2 has a {customer2.membershipType} membership.");
            }

            // Customer 3 - Legal age and premium member
            Customer customer3 = new Customer();
            customer3.birthDate = Convert.ToDateTime("8/23/1995");
            customer3.age = CalculateAge(customer3.birthDate);
            customer3.membershipType = Customer.MembershipType.premium;
            customer3.canShopOnlineForAlcohol = customer3.age >= 21 ? true : false;

            if (customer3.canShopOnlineForAlcohol != true)
            {
                Console.WriteLine($"Customer3 is {customer3.age} and is underage. Customer3 has a {customer3.membershipType} membership.");
            }
            else
            {
                Console.WriteLine($"Customer3 is {customer3.age} and is of legal age. Customer3 has a {customer3.membershipType} membership.");
            }

        }

        // url: https://www.c-sharpcorner.com/code/961/how-to-calculate-age-from-date-of-birth-in-c-sharp.aspx
        private static int CalculateAge(DateTime dateofBirth) 
        {
            int age = 0;
            age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear) 
            {
                age = age - 1;
            }

            return age;

        }
    }
}

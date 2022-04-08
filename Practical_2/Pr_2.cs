using System;

namespace Practical_2
{
    class Customer_Account
    {
        string bank_name;
        long customer_accountNo;
        string customer_name;

        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }

        public void printInfo()
        {
            System.Console.WriteLine("Bank Name: {0}", bank_name);
            System.Console.WriteLine("Customer Account Number: {0}", customer_accountNo);
            System.Console.WriteLine("Customer Name: {0}", customer_name);
        }

        public static void Main(string[] args)
        {
            Customer_Account info = new Customer_Account(5287842573, "Janvi Patel");
            info.bank_name = "State Bank Of India";
            info.printInfo();
        }
    }
}
    

using System;
using System.Collections.Generic;
namespace CompanyItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, choice,isThereNext,desc="";
            int quantity=0;
            double rate=0.0;
            Company companyobj = new Company();
            Item itemobj = new Item();
            RegCustomer customerobj = new RegCustomer();
            OrderedItem orderedItemobj=new OrderedItem();
            Order orderobj = new Order();
            Console.WriteLine("enter the discount for registered customers");
            companyobj.discount= Convert.ToDouble(Console.ReadLine());
        label:
            customerobj = new RegCustomer();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Existing customer? enter 'yes' or 'no'");
            choice= Console.ReadLine();
            Console.WriteLine("enter the number of different items purchased");
            int num= Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("Enter the description of the product");
                desc = Console.ReadLine();
                Console.WriteLine("Enter the rate of the product");
                rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the quantity of the product ordered");
                quantity = Convert.ToInt32(Console.ReadLine());
                itemobj.rate = rate;
                itemobj.description = desc;
                orderedItemobj.OrderedQuantity = quantity;
                orderedItemobj.Itemobj = itemobj;
                orderobj.orderedItems.Add(orderedItemobj);
                if (choice == "yes")
                    companyobj.regcustomerprices.Add(orderobj.gettotalofcustomer());
                else if(choice=="no")
                    companyobj.customerprices.Add(orderobj.gettotalofcustomer());
            }
            Console.WriteLine("Are there more customer ? enter 'yes' or 'no'");
            isThereNext= Console.ReadLine();
            
            customerobj.name = name;
            customerobj.address = address;
            companyobj.items.Add(itemobj);
            if (choice == "yes")
                companyobj.regCustomers.Add(customerobj);
            else if (choice == "no")
                companyobj.customers.Add(customerobj);
            else
                Console.WriteLine("Wrong choice");
            if (isThereNext == "yes")
                goto label;
            //calculation and printing
            Console.WriteLine("\n");
            Console.WriteLine("Registered Customers data");
            //Console.WriteLine("sl.no."+"    "+"Customer name"+" "+"Address"+"   "+"Total amount");
            for(int i=0;i<companyobj.regCustomers.Count;i++)
            {
                Console.Write((i+1)+".   "+companyobj.regCustomers[i].name+"  "+ companyobj.regCustomers[i].address+"    "+companyobj.GetTotalregcustomer(companyobj.regcustomerprices[i]));
                Console.WriteLine();
            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Unegistered/New Customers data");
            for (int i = 0; i < companyobj.customers.Count; i++)
            {
                Console.Write((i + 1) + ".   " + companyobj.customers[i].name + "  " + companyobj.customers[i].address + "    " +companyobj.customerprices[i]);
                Console.WriteLine();
            }
        }
    }
    public class Company
    {
        public List<Item> items = new List<Item>();
        public List<Customer> customers = new List<Customer>();
        public List<RegCustomer> regCustomers = new List<RegCustomer>();
        public List<double> customerprices = new List<double>();
        public List<double> regcustomerprices = new List<double>();
        public double discount;
        public double GetTotalregcustomer(double price)
        {
            return (price - ((price * discount) / 100));          
        }
    }
    public class Item
    {
        public string description;
        public double rate;
    }
    public class Customer
    {
        public List<Order> orders = new List<Order>();
        public string name;
        public string address;
    }
    public class RegCustomer :Customer
    {
        public double discount;
        public double getSplDiscount(double rate) 
        {
            rate = rate-(rate * discount) / 100;
            return rate;
        }
    }
    public class Order
    {
        Customer customerobj = new Customer();
        RegCustomer regCustomer = new RegCustomer();
        public List<OrderedItem> orderedItems = new List<OrderedItem>();
        OrderedItem o;
        public double gettotalofcustomer()
        {
            double price = 0.0;
            foreach (OrderedItem orderedItem in orderedItems)
            {
                o = orderedItem;
            }
            price += o.Itemobj.rate * o.OrderedQuantity;
            return price;
        }
    }
    public class OrderedItem
    {
        public Item Itemobj = new Item();
        public int OrderedQuantity;
    }
    public class orderdetails
    {

    }
    
}

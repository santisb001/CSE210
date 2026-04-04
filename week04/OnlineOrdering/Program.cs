using System;

class Program
{
    static void Main(string[] args)
    {
        //Customer information
        Console.WriteLine("Order 1");
        Address address1 = new Address("Street 1","Laguna Paiva","Buenos Aires","Argentina");
        Customer customer1 = new Customer("Matias Larroque",address1);
        //Products for this order
        Product product1 = new Product("Turbo Fan","Q742RT-y",23,4);
        Product product2 = new Product("French Wrenches","P982MK-z",15,10);
        Product product3 = new Product("Generator","E556KP-t",70,2);
        Product product4 = new Product("Gas pump","F201LJ-u",15,1);
        //First order
        Order order1 = new Order(customer1);
        //Add products
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);
        //Create package label
        order1.PackingLabel();
        //Create shiping label
        order1.ShippingLabel();
        //Total cost
        Console.WriteLine($"{order1.CalculateOrderTotalPrice()}");
        Console.WriteLine("");

        Console.WriteLine("Order 2");
        //Customer information Forest Park Ave, St. Louis, MO 63108, EE. UU.
        Address address2 = new Address("Forest Park Ave","St. Louis","Missouri","USA");
        Customer customer2 = new Customer("Frederic Monroe",address2);
        //Products for this order
        Product product5 = new Product("Peanut butter","MK428P-a",3,25);
        Product product6 = new Product("Butter cream","LQ321O-p",7,39);
        Product product7 = new Product("Wooden spoon","RP112M-r",14,2);
        Product product8 = new Product("Cookies","FN333R-u",2,32);
        //First order
        Order order2 = new Order(customer2);
        //Add products
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);
        //Create package label
        order2.PackingLabel();
        //Create shiping label
        order2.ShippingLabel();
        //Total cost
        Console.WriteLine($"{order2.CalculateOrderTotalPrice()}");
    }
}


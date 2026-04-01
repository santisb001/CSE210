using System;

class Program
{
    static void Main(string[] args)
    {
        //Customer information
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
        Console.WriteLine($"{order1.PackingLabel()}");
        //Create shiping label
        Console.WriteLine($"{order1.ShippingLabel()}");
        //Total cost
        Console.WriteLine($"{order1.CalculateOrderTotalPrice()}");





    }
}
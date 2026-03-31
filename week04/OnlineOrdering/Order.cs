using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Order
{
    //Attributes
    private List<Product> _products;
    private float _totalPrice;
    private Customer _customer;
    
    

    //Constructor
    public Order(Customer customerName)
    {
        _customer = customerName;
        _products = new List<Product>();
        _totalPrice = 0;
    }


    //Methods
    public void AddProduct(Product productToAdd)
    {
        _products.Add(productToAdd);
    }

    public float CalculateOrderTotalPrice()
    {
        foreach (Product P in _products)
        {
            _totalPrice =+ P.CalculatePrice();
        } 
        if (_customer.IsUSA())
        {
            _totalPrice =+ 5;
        }
        else
        {
            _totalPrice =+ 35;
        }
        return _totalPrice;
    }

    public void PackingLabel()
    {
        foreach (Product P in _products)
        {
            Console.WriteLine($"{P.ReturnProductLabel()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.ReturnCustomer()}");
    }







}
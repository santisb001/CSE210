using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Order
{
    //Attributes
    private List<Product> _products;
    private float _totalPrice;
    

    //Constructor
    public Order()
    {
        
    }



    

    //Methods
    public void AddProduct(Product productToAdd)
    {
        _products.Add(productToAdd);
    }

    public double CalculateOrderPrice()
    {
        return ;
    }







}
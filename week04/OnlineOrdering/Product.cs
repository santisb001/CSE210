using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Product
{
    //Attributes
    private string _prodName;
    private int _prodID;
    private float _price;

    private int _quantity;
    private float _prodTotalPrice;


    //Constructor
    public Product(string productName, int productID, float productPrice, int productQuantity)
    {
        _prodName = productName;
        _prodID = productID;
        _price = productPrice;
        _quantity = productQuantity;
        _prodTotalPrice = 0;
    }


    //Methods
    public float CalculatePrice()
    {
        //The total cost of this product is computed by multiplying the price per unit and the quantity.
        //(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
        _prodTotalPrice = _price * _quantity;

        return _prodTotalPrice;
    }

    public string ReturnProductLabel()
    {
        return $"Product: {_prodName}, ID: {_prodID}, Quantity: {_quantity}";
    }

    //public string ReturnProduct()
    //{
    //    return $"Product: {_prodName}, ID: {_prodID}, Price: {_prodTotalPrice}, Quantity: {_quantity}";
    //}













}
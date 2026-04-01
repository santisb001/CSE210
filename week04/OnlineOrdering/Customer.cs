using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Customer
{
    //Attributes
    private string _name;
    private Address _address;


    //Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    //Methods
    public string ReturnCustomer()
    {
        return $"{_name}, Address: {_address.ReturnAddress()}";
    }


    public bool IsUSA()
    {
        return _address.IsInTheUSA();
    }
}
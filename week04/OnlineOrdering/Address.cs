using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Address
{    
    //Attributes
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;


    //Constructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateOrProvince;
        _country = country;
    }


    //Methods
    public string ReturnAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}.";
    }

    public bool IsInTheUSA()
    {
        _country = _country.ToLower();
        if (_country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
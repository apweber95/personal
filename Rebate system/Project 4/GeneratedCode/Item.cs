﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Item
{
    private float price;
    private string name;
    private int amount;
    private int rAmount;
    private bool returned;

    public float Price
    {
        get
        {
            return price;
        }
    }

    public bool Returned
    {
        get
        {
            return returned;
        }
        set
        {
            returned = value;
        }
    }

    public int Amount
    {
        set
        {
            amount = value;
        }
        get
        {
            return amount;
        }
    }

    public int RAmount
    {
        get
        {
            return rAmount;
        }
        set
        {
            rAmount = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public override string ToString()
    {

        string formatPrice = string.Format("{0:C2}", price);
        string s = "";
        if (amount > 0)
            s += ("Item: " + name + "\nPrice: " + formatPrice + "\nQty: " + amount + "\n");
        if (returned)
        {
            s += "\n*** Returned ***\nItem: " + name + "\nPrice: " + formatPrice + "\nQty: " + rAmount + "\n****************\n";
        }
        return s;
    }

    public Item(string n, float p, int a)
    {
        name = n;
        price = p;
        amount = a;
    }

}


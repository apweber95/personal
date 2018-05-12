using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rebate
{
    private int transID;
    private DateTime date;
    private float rebateAmount;
    
    public DateTime Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
        }
    }

    public float RebateAmount
    {
        set
        {
            rebateAmount = value;
        }
        get
        {
            return rebateAmount;
        }
    }

    public int TransID
    {
        get
        {
            return transID;
        }
        set
        {
            transID = value;
        }
    }

    public override string ToString()
    {
        return "ID: " + transID + "\nDate: " + date.ToString() + "\nAmount: $" + rebateAmount;
    }
}


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
using Project_4.GeneratedCode;

public class ReturnsManager
{
    public delegate string ReturnHandler(string n, int i);

    public delegate void EndReturnHandler(int i);

    public ReturnHandler returnHandler;

    ReciptOutputView.Observer updateReturnsOutput;
    ModelI dataBase;

    public ReturnsManager(ModelI m)
    {
        dataBase = m;
        returnHandler = new ReturnHandler(returnItem);

    }
    public void endReturn(int id)
    {
        updateReturnsOutput(id, true);
    }


	public string returnItem(string name, int id)
	{

        
        Transaction t = dataBase.getTransaction(id);
        if(t != null)
        {
            if(t.Rebate == false)
            {
                if (t.Items.ContainsKey(name) )
                {
                    Item i = t.Items[name];
                    i.Returned = true;
                    if (i.Amount > 1)
                    {
                        i.Amount--;
                        i.RAmount++;
                    }
                    else if(i.Amount == 1)
                    {
                        i.Amount = 0;
                        i.RAmount++;
                    }
                    else
                    {
                        return "Max number of items returned.";

                    }
                   
                    return "Item returned.";

                }
                return "Item not found.";

            }
            return "Rebate Entered, return not valid.";
        }
        return "Transaction not found.";


    }

    internal void register(ReciptOutputView.Observer run)
    {
        updateReturnsOutput = run;
    }
}


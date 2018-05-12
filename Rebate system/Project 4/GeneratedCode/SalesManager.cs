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
using System.Windows.Forms;

public class SalesManager
{
    public delegate void TransactionHandler(int id);
    public delegate void ItemHandler(int q, float p, string n);
    public delegate void EndTransactionHandler();

    public TransactionHandler transHandler;
    public ItemHandler itemHandler;
    public EndTransactionHandler endHandler;

    ReciptOutputView.Observer updateTransactionOutput;
    ConsoleReciptOutput.Observer updateTransactionOutput_C;
    ModelI dataBase;
    Transaction currentTrans;

    public SalesManager(ModelI m)
    {
        dataBase = m;
        transHandler = new TransactionHandler(createTransaction);
        itemHandler = new ItemHandler(addItem);
        endHandler = new EndTransactionHandler(endTransaction);
    }

	public void createTransaction(int tNum)
	{
       currentTrans = new Transaction(tNum);
       
    }

    public void endTransaction()
    {
        dataBase.addTransaction(currentTrans); //add to db once transaction has ended
        updateTransactionOutput?.Invoke(currentTrans.getID(), true);
        updateTransactionOutput_C?.Invoke(currentTrans.getID(), true);
    }


    public void addItem(int quantity, float price, string name)
    {
        Item item = new Item(name, price, quantity);
        if (currentTrans.Items.ContainsKey(name))
        {
            currentTrans.Items[name].Amount++;
        }
        else
        {
            currentTrans.Items.Add(name, item);
        }
    }

    internal void register(ReciptOutputView.Observer o)
    {
        updateTransactionOutput = o;
    }

    internal void register(ConsoleReciptOutput.Observer o)
    {
        updateTransactionOutput_C = o;
    }
}


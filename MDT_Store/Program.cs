using System;
public class Program
{
    public static void Main(string[] args)
    {
        DATA ID = new DATA();
        Console.Write("Please input Name : ");
        ID.Name =  DATA.INPUT();
        Console.Write("Please input Number : ");
        ID.ID_Number = VarConverter.StringToLong(DATA.INPUT());
        Console.Write("Please input Owner Name : ");
        ID.Owner_Name = DATA.INPUT();
        Console.Write("Please input Registered Value : ");
        ID.Registered_Value = VarConverter.StringToDouble(DATA.INPUT());
        DATA.PrintShopInformation(ID);
        Console.Write("Please input money : ");
        ID.Money = VarConverter.StringToDouble(DATA.INPUT());
        Exchange.Ex(ID);
    }
}
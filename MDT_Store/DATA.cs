using System;
public class DATA
{
    public static string INPUT()
    {
        return Console.ReadLine();
    }
    public string Name = "";
    public string Owner_Name = "";
    public long ID_Number;
    public double Registered_Value;
    public double Money;
    public static void PrintShopInformation(DATA data)
    {
        Console.WriteLine("—------------------Shop Information-------------------");
        Console.WriteLine("Name : {0}",data.Name);
        Console.WriteLine("Number : {0}",data.ID_Number);
        Console.WriteLine("Owner Name : {0}",data.Owner_Name);
        Console.WriteLine("Registered Value : {0}",data.Registered_Value);
        Console.WriteLine("—-----------------------------------------------------");
    }
}
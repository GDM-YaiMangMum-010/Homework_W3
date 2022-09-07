public class Exchange
{
    public static void Ex(DATA Ex)
    {
        Console.WriteLine("1000 : {0}",Math.Floor(Ex.Money/1000));
        Console.WriteLine("500 : {0}",Math.Floor(Ex.Money%1000/500));
        Console.WriteLine("100 : {0}",Math.Floor(Ex.Money%1000%500/100));
        Console.WriteLine("50 : {0}",Math.Floor(Ex.Money%1000%500%100/50));
        Console.WriteLine("20 : {0}",Math.Floor(Ex.Money%1000%500%100%50/20));
        Console.WriteLine("10 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20/10));
        Console.WriteLine("5 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20%10/5));
        Console.WriteLine("2 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20%10%5/2));
        Console.WriteLine("1 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20%10%5%2/1));
        Console.WriteLine(".50 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20%10%2%1/0.5));
        Console.WriteLine(".25 : {0}",Math.Floor(Ex.Money%1000%500%100%50%20%10%2%1%0.5/0.25));
    }
}
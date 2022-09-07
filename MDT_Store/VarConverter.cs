public class VarConverter
{
    public static long StringToLong(string value)
    {
        if(long.TryParse(value,out long number))
        {
            return number;
        }
        throw new Exception("Wrong Word");
    }
    public static double StringToDouble(string value)
    {
        if(double.TryParse(value,out double d_number))
        {
            return d_number;
        }
        throw new Exception("Wrong Word");
    }
}
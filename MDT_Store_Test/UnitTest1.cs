namespace MDT_Store_Test;

public class UnitTest1
{
    [Fact]
    public void TestStringToLong()
    {
        long number = VarConverter.StringToLong("7005");
        Assert.Equal(number,7005);
    }
    [Fact]
    public void TestStringToLongWrong()
    {
        Assert.Throws<Exception>(()=>VarConverter.StringToLong("Kaiwa"));
    }
    [Fact]
    public void TestStringToDouble()
    {
        double number = VarConverter.StringToDouble("5007.526");
        Assert.Equal(number,5007.526);
    }
    [Fact]
    public void TestStringToDoubleWrong()
    {
        Assert.Throws<Exception>(()=>VarConverter.StringToDouble("Aroi"));
    }
}
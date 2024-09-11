using Unittest;

namespace Tests;

public class UnitTest1
{
    private readonly Class1 _exercises = new Class1();

    [Fact]
    public void  TestReverseString()
    {
        var teststring = "vedran";

        var result = _exercises.ReverseString(teststring);
        Assert.Equal("nardev", result);
    }

    [Fact]
    public void TestIsEaven()
    {
        int testNumber = 4;

        var result = _exercises.IsEven(testNumber);
        Assert.Equal(true, result);
        
    }

    [Fact]
    public void TestFindMax()
    {
        int[] testnum = { 1, 3, 7, 5 };

        var result = _exercises.FindMax(testnum);
        Assert.Equal(7, result);
    }
    
}
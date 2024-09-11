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

    [Fact]
    public void TestCountOccurrences()
    {
        string test = "heyyy";
        

        var result = _exercises.CountOccurrences(test,'y');
        Assert.Equal(3,result);

    }

    [Fact]
    public void TestRemoveDuplicates()
    {
        int[] test = { 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };

        var result = _exercises.RemoveDuplicates(test);
        
        int[] expected = { 1, 2, 3, 4, 5, 0 };
        Assert.Equal(expected,result);
    }
    
}
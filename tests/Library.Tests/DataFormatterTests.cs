using TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectDatte()
    {
        string test = "05/12/2002";
        string expected = "2002-12-05";
        string resultado=DateFormatter.ChangeFormat(test);
        Assert.AreEqual(expected,resultado);
    }
     [Test]
    public void EmptyDate()
    {
        string test = "";
        string expected = "";
        string resultado=DateFormatter.ChangeFormat(test);
        Assert.AreEqual(expected,resultado);
    }
     [Test]
    public void WrongDate(){
        string test = "2002/12/05";
        string expected = "2002-12-05";
        string resultado=DateFormatter.ChangeFormat(test);
        Assert.AreEqual(expected,resultado);   
    }
}
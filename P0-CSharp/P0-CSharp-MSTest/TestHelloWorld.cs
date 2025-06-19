using P0_CSharp;

namespace P0_CSharp_MSTest;

[TestClass]
public class TestHelloWorld
{
    [TestMethod]
    public void TestToString()
    {
        HelloWorld helloWorld = new HelloWorld();
        string result = helloWorld.ToString();
        Assert.AreEqual("Hello, World!", result);
    }
}
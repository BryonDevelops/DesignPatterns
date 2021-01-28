[TestClass]
public class DuckTest
{
    [TestMethod]
    public void TestMallardDuck()
    {
        var mallard = new MallardDuck();
        Assert.AreEqual("Quack", mallard.PerformQuack());
        Assert.AreEqual("I'm flying!!", mallard.PerformFly());
    }

    [TestMethod]
    public void TestModelDuck()
    {
        var modelDuck = new ModelDuck();
        Assert.AreEqual("Quack", modelDuck.PerformQuack());
        Assert.AreEqual("I can't fly.", modelDuck.PerformFly());

        modelDuck.FlyBehaviour = new FlyWithWings(); // changing the behavior runtime
        Assert.AreEqual("I'm flying!!", modelDuck.PerformFly());
    }
}
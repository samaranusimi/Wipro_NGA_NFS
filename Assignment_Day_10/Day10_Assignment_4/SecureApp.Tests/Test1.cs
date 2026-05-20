namespace SecureApp.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void Register_ShouldHashPassword()
    {
        var user = User.Register("test", "123");

        Assert.AreNotEqual("1234", user.HashedPassword);
    }

    [TestMethod]
    public void Authenticate_ShouldReturnTrue()
    {
        var user = User.Register("test", "123");

        bool result = user.Authenticate("123");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Authenticate_ShouldFail_WrongPassword()
    {
        var user = User.Register("test", "123");

        bool result = user.Authenticate("wrong");

        Assert.IsFalse(result);
    }
}

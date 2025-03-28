namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Strumberger()
    {
        Assert.AreEqual(1, Program.Subtract("2", "1"));
        Assert.AreEqual(7, Program.Subtract("10", "3"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Strumberger()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Strumberger()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiply
{
    [TestMethod]
    public void Multiply_Valid_Strumberger()
    {
        Assert.AreEqual(2, Program.Multiply("1", "2"));
        Assert.AreEqual(-20, Program.Multiply("-5", "4"));
        Assert.AreEqual(0, Program.Multiply("5", "0"));
    }
    [TestMethod]
    public void Multiply_Invalid_Strumberger()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }
    [TestMethod]
    public void Multiply_Null_Strumberger()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Divide
{
    [TestMethod]
    public void Divide_Valid_Strumberger()
    {
        Assert.AreEqual(2, Program.Divide("4", "2"));
        Assert.AreEqual(-5, Program.Divide("-10", "2"));
        Assert.AreEqual(1, Program.Divide("0", "5"));
    }
    [TestMethod]
    public void Divide_Invalid_Strumberger()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }
    [TestMethod]
    public void Divide_Null_Strumberger()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }
}

[TestClass]
public class Power
{
    [TestMethod]
    public void Power_Valid_Strumberger()
    {
        Assert.AreEqual(8, Program.Power("2", "3")); 
        Assert.AreEqual(5, Program.Power("5", "0")); 
        Assert.AreEqual(0.25, Program.Power("2", "-2")); 
    }
    [TestMethod]
    public void Power_Invalid_Strumberger()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }
    [TestMethod]
    public void Power_Null_Strumberger()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}


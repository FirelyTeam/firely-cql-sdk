using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreTests.Tuples;

[TestClass]
public class TupleTests
{
    [TestMethod]
    public void Constructor_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a = new("Paul", dateTime);

        // Assert
        Assert.AreEqual("(Name=Paul, DOB=31-12-2000 00:00:00)", a.ToString());
    }

    [TestMethod]
    public void ConstructorWithNamedArguments_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a1 = new(name: "Paul");

        // Assert
        Assert.AreEqual("(Name=Paul, DOB=)", a1.ToString());
    }

    [TestMethod]
    public void ObjectInitializer_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a2 = new TupleA { DOB = dateTime };

        // Assert
        Assert.AreEqual("(Name=, DOB=31-12-2000 00:00:00)", a2.ToString());
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithItself()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        bool result = a.Equals(a);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        bool result = a.Equals((object)a);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnFalse_WhenComparingWithDifferentInstance()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleA a1 = new("John", dateTime);

        // Act
        bool result = a.Equals(a1);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnFalse_WhenComparingWithDifferentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleA a1 = new("John", dateTime);

        // Act
        bool result = a.Equals((object)a1);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithEquivalentTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        bool result = a.Equals(b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithEquivalentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        bool result = a.Equals((object)b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetHashCode_ShouldReturnSameValue_WhenCalledOnEquivalentTuples()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        int hashCodeA = a.GetHashCode();
        int hashCodeB = b.GetHashCode();

        // Assert
        Assert.AreEqual(hashCodeA, hashCodeB);
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals(b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals((object)b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentTuple_WhenComparingWithOriginalTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a == b1);
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject_WhenComparingWithOriginalTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals(b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject_WhenComparingWithOriginalObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals((object)b1));
    }

    [TestMethod]
    public void GetHashCode_ShouldReturnSameValue_WhenCalledOnCopiedTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);
        int hashCodeA = a.GetHashCode();
        int hashCodeB = b1.GetHashCode();

        // Assert
        Assert.AreEqual(hashCodeA, hashCodeB);
    }
}

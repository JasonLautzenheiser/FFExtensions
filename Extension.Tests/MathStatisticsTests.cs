using System;
using Extensions.Math;
using NUnit.Framework;

namespace Extension.Tests
{
  [TestFixture]
  public class MathStatisticsTests
  {
    [Test]
    public void DecimalAverageWith1ItemReturnsSelf()
    {
      Assert.That(23m.Average(1), Is.EqualTo(23m));
    }

    [Test]
    public void DecimalAverageWith2ItemsReturnsAverage()
    {
      Assert.That(24m.Average(2), Is.EqualTo(12m));
    }

    [Test]
    public void DecimalAverageWith3ItemsReturnsAverage()
    {
      Assert.That(23m.Average(3).CompareTo(23m/3), Is.EqualTo(0));
    }

    [Test]
    public void DecimalAverage0ItemsThrowsException()
    {
      decimal blah = 23m;
      var testDelegate = new TestDelegate(() => blah.Average(0));
      Assert.That(testDelegate, Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void IntegerAverageWith1ItemReturnsSelf()
    {
      Assert.That(23.Average(1), Is.EqualTo(23));
    }

    [Test]
    public void IntegerAverageWith2ItemsReturnsAverage()
    {
      Assert.That(24.Average(2), Is.EqualTo(12));
    }

    [Test]
    public void IntegerAverageWith3ItemsReturnsAverage()
    {
      Assert.That(23.Average(3).CompareTo(23/3.0), Is.EqualTo(0));
    }

    [Test]
    public void IntegerAverage0ItemsThrowsException()
    {
      decimal blah = 23;
      var testDelegate = new TestDelegate(() => blah.Average(0));
      Assert.That(testDelegate, Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void DoubleAverageWith1ItemReturnsSelf()
    {
      Assert.That((23.0).Average(1), Is.EqualTo(23));
    }

    [Test]
    public void DoubleAverageWith2ItemsReturnsAverage()
    {
      Assert.That((24.0).Average(2), Is.EqualTo(12));
    }

    [Test]
    public void DoubleAverageWith3ItemsReturnsAverage()
    {
      Assert.That((23.0).Average(3).CompareTo(23.0/3), Is.EqualTo(0));
    }

    [Test]
    public void DoubleAverage0ItemsThrowsException()
    {
      double blah = 23.0;
      var testDelegate = new TestDelegate(() => blah.Average(0));
      Assert.That(testDelegate, Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void AverageEmptyArrayThrowsException()
    {
      int[] items = new int[0];
      var testDelegate = new TestDelegate(() => items.Average());
      Assert.That(testDelegate, Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void AverageOneItemArrayReturnsItem()
    {
      Assert.That(new int[1] {23}.Average(), Is.EqualTo(23));
    }
    [Test]
    public void AverageTwoItemArrayReturnsAverage()
    {
      Assert.That(new int[2] {23,12}.Average(), Is.EqualTo(17.5));
    }

    [Test]
    public void AverageEmptyDoubleArrayThrowsException()
    {
      double[] items = new double[0];
      var testDelegate = new TestDelegate(() => items.Average());
      Assert.That(testDelegate, Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void AverageOneItemDoubleArrayReturnsItem()
    {
      Assert.That(new double[1] {23.5}.Average(), Is.EqualTo(23.5));
    }
    [Test]
    public void AverageTwoItemDoubleArrayReturnsAverage()
    {
      Assert.That(new double[2] {23.0,12.0}.Average(), Is.EqualTo(17.5));
    }
  }
}
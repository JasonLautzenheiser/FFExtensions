using System.Linq;

namespace Extensions.Math
{
  public static class Statistics
  {
    public static decimal Average(this decimal total, int items)
    {
      if (items == 0) throw new System.DivideByZeroException();
      return total/items;
    }

    public static double Average(this int total, int items)
    {
      if (items == 0) throw new System.DivideByZeroException();
      return total/(double)items;
    }

    public static double Average(this double total, int items)
    {
      if (items == 0) throw new System.DivideByZeroException();
      return total/items;
    }

    public static double Average(this int[] items)
    {
      if (items.Length==0) throw new System.DivideByZeroException();
      return items.Sum()/(double)items.Length;
    }

    public static double Average(this double[] items)
    {
      if (items.Length==0) throw new System.DivideByZeroException();
      return items.Sum()/items.Length;
    }
  }
}
namespace System.Linq
{
  class Program
  {
    static void Main()
    {
      Console.Write(
        Console.ReadLine() == "0" ? 0 : Console.ReadLine()
          .Split(' ').Select(int.Parse)
          .OrderBy( x => -x*x+x )
          .Last()
        );
    }
  }
}

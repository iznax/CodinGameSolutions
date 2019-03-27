namespace System.Linq{class P{static void Main(){Console.Write((Console.ReadLine()!="0"?Console.ReadLine():"0").Split(' ').Select(int.Parse).OrderBy(x=>-x*x+x).Last());}}}

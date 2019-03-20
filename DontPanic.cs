using System;
class Program // https://www.codingame.com/ide/puzzle/don't-panic
{
    static void Main()
    {
        Func<string,int>p=int.Parse;
        Func<string>c=Console.ReadLine;
        string[] i=c().Split(' ');
        int v=p(i[7]); // number of elevators
        int[]x=new int[15];
        x[p(i[3])]=p(i[4]); // exit[ floor ] = position;
        while (v-->0)
        {
            i=c().Split(' ');
            x[p(i[0])]=p(i[1]); // elevator[ floor ] = position;
        }
        for(;;)
        {
            i=c().Split(' ');
            v=p(i[0]); // lead.floor
            var w = v>=0; // handle "-1 -1 NONE"
            if (w)
            {
                v = x[v] - p(i[1]); // exit[flooar] - lead.position
                w = v==0 || i[2][0] == (v<0?'L':'R'); // direction = LEFT or RIGHT?
            }
            Console.WriteLine(w?"WAIT":"BLOCK");
        }
    }
}

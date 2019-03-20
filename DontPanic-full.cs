using System; class P{static void Main(){
    Func<string,int>p=int.Parse;
    Func<string>c=Console.ReadLine;
    string[] i=c().Split(' ');
    int v=p(i[7]);
    int[]x=new int[15];
    x[p(i[3])]=p(i[4]);
    while (v-->0)
    {
        i=c().Split(' ');
        x[p(i[0])]=p(i[1]);
    }
    for(;;)
    {
        i=c().Split(' ');
        v=p(i[0]);
        var w=v>=0;
        if (w)
        {
            v=x[v]-p(i[1]);
            w=v==0||i[2][0]==(v<0?'L':'R');
        }
        Console.WriteLine(w?"WAIT":"BLOCK");
}}}

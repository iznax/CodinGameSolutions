using System;
class Program // https://www.codingame.com/ide/puzzle/power-of-thor
{
  static void Main()
  {
    Func<string>r=Console.ReadLine;
    Func<string,int>p=int.Parse;
    string[]i=r().Split(' ');
    //int LX = ;
    //int LY = ;
    //int TX = ;
    //int TY = ;
    int dx = p(i[0])-p(i[2]);
    int dy = p(i[1])-p(i[3]);
    int sx = dx>0 ? 1:-1;
    int sy = dy>0 ? 1:-1;
    int ax = dx*sx;
    int ay = dy*sy;
    var tx = sx>0 ? "E":"W";
    var ty = sy>0 ? "S":"N";
    int a = (dx>dy) ? ax/2:ay/2;
    for(;;)
    {
      r();
      string dir;
      if (ax > ay)
      {
        dx += sx;
        dir = tx;
        a += ay;
        if (a > ax)
        {
          dy += sy;
          a -= ax;
          dir = ty+tx;
        }
      }
      else
      {
        dy += sy;
        dir = ty;
        a += ax;
        if (a > ay)
        {
          dx += sx;
          a -= ay;
          dir = ty+tx;
        }
      }
      Console.WriteLine(dir);
    }
  }
}

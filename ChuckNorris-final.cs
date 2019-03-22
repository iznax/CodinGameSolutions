//using System;ConsoleConsole
namespace System{using C=Console;

class S
{
    static void Main()
    {
        var code="";
        
        int b=-1;
        int count = 0;

        Action dump=()=>
        {
            if (count > 0)
            {
                code+=code.Length>0?" ":"";
                code+=b>0?"0 ":"00 ";
                while(count-->0)code+="0";
            }
        };
        
        foreach (var r in C.ReadLine())
            {int k=r;
            for(int i=0; i<7; ++i,k*=2,count++)
            {
                if ((k&64)!=b)
                {
                    dump();
                    b = k&64;
                    count=0;
                }
            }
        }
        
        dump();

        C.Write(code);
    }
}
}

using System;

// https://www.codingame.com/ide/puzzle/chuck-norris-codesize
class Solution
{
    static string dump(int bit, int count)
    {
        string res = (bit == 0) ? "00 " : "0 ";
        while (count-- > 0) res += "0";
        return res;
    }
    
    static void Main(string[] args)
    {
        string code = "";
        
        int b = 0;
        int count = 0;
        
        int bits = 0;
        foreach (char raw in Console.ReadLine())
        {
            int ch = raw;
            for (int i=0; i<7; ++i)
            {
                int and = ch & 64;
                if (count == 0)
                {
                    b = ch&64;
                    count = 1;
                }
                else if (and == b)
                {
                    count += 1;
                }
                else
                {
                    string work = dump(b,count);
                    code += (code.Length == 0) ? "" : " ";
                    code += work;
                    b = and;
                    count = 1;
                }
                ch <<= 1;
            }
        }
        
        if (count != 0)
        {
            code += (code.Length == 0) ? "" : " ";
            code += dump(b,count);
        }

        Console.WriteLine(code);
    }
}

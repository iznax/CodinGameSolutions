namespace System
{
    class Program
    {
        static void Main()
        {
            int i, k, o=2;
            foreach(char c in Console.ReadLine())
                for(i=7; i-- > 0; o=k)
                    Console.Write( (k=c>>i&1) != o ? (o>1?"":" ") + (k>0?"0 0":"00 0") : "0" );
        }
    }
}

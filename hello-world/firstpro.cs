using System.Diagnostics;

namespace hello_c
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class firstpro
{
    static void Main(int mynum)
    {
        const int Mynum = 20;
            mynum = 30;
        
        System.Console.WriteLine(Mynum);
    }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
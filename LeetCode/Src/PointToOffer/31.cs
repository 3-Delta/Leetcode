using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class _31
{
    public class Tiple3
    {
        public int max;
        public int startIndex;
        public int endIndex;

        public Tiple3() { }
        public Tiple3(int max, int startIndex, int endIndex)
        {
            this.max = max;
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }
        public override string ToString()
        {
            return string.Format("max:{0} start:{1} end:{2}", max, startIndex, endIndex);
        }
    }

    public static void Func()
    {
        Tiple3 ret = new Tiple3();

        Console.WriteLine(ret.ToString());
    }
}
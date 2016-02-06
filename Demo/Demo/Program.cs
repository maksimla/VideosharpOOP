using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public struct StructPixel
        {
            public int x;
            public int y;

            public StructPixel(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


        public class ClassPixel
        {
            public int x;
            public int y;

            public ClassPixel(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public class ClassPixel3D : ClassPixel
        {
            public int z;
            public ClassPixel3D(int x, int y,int z):base(x,y)
            {
                this.z = z;
            }
        }

        static void Main(string[] args)
        {
            DateTime dt;
            StructPixel sp;
            ClassPixel cp;

            sp = new StructPixel(10, 20);
            cp = new ClassPixel(100, 200);
            MovePixel(ref sp);
            MovePixel(cp);
        }

        static void MovePixel(ref StructPixel sp)
        {
            sp.x++;
            sp.y++;
        }

        static void MovePixel(ClassPixel cp)
        {
            cp.x++;
            cp.y++;
        }
    }
}

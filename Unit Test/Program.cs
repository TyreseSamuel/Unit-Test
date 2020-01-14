using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    class Program
    {
        public static void Matrix3Multiply()
        {
            Matrix3 m3a = new Matrix3();
            m3a.SetRotateX(3.98f);

            Matrix3 m3c = new Matrix3();
            m3c.SetRotateZ(9.62f);

            Matrix3 m3d = m3a * m3c;
        }
        static void Main(string[] args)
        {
            Matrix3Multiply();
            Console.ReadKey();
        }
    }
}

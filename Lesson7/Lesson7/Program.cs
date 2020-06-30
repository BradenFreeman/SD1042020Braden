using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Lesson7
{
    class Program
    {
        public static ClassA classAObject;
        public static ClassB classBObject;
        static public void Main();
    };
    class ClassA
    {
        public int state = 1;
    }
    class ClassB
    {
        private int state = 7;
    }
}

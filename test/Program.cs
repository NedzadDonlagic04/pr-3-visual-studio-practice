using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace test
{
    internal class Program
    {
        public class MyClass { }

        static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = arr1;

            arr2[0] = 5;

            Console.WriteLine(arr1[0]);

            int a = 5;
            object o1 = a;
            object o2 = o1;
            
            o2 = 10;

            Console.WriteLine(o1);
            Console.WriteLine(o2);

            unsafe {
                var typeHandleValue = typeof(MyClass).TypeHandle.Value;
                var size = Marshal.ReadInt32(typeHandleValue, 4);
                var mem = stackalloc byte[size];
                *(IntPtr*)mem = typeHandleValue;
                var instance = Unsafe.AsRef<MyClass>(&mem);
            }
        }
    }
}
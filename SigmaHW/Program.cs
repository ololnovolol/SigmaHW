using System;

namespace SigmaHW
{
    internal class Program
    {

        private enum MyEnum

        {

            First = 11,

            Second,

            Third = 33

        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)MyEnum.Second);

            Console.ReadKey();
        }



    }

    public struct MyStruct : IDisposable

    {

        private bool dispose;

        public void Dispose()

        {

            dispose = true;

        }

        public bool GetDispose()

        {

            return dispose;

        }

    }



    public class MyClass

    {

        public void TestMethod()

        {

            var myStruct = new MyStruct();



            using (myStruct)

            {

                Console.WriteLine(myStruct.GetDispose());

            }



            Console.WriteLine(myStruct.GetDispose());

        }

    }
}

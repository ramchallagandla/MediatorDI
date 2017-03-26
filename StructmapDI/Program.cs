namespace StructmapDI
{
    using MediatorDI;
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            var sample = Ioc.Container.GetInstance<SampleController>();
            sample.DoSomething(new DoSomethingReq { Input = true });
            Console.ReadLine();
        }
    }
}

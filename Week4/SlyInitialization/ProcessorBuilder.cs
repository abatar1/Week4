using System;

namespace Week4
{
    public static class ProcessorBuilder
    {
        public static T CreateEngine<T>()
        {
            throw new NotImplementedException();
        }
    }

    public static class MyEngineExtension
    {
        public static MyLogger For<T>(this MyEngine a)
        {
            throw new NotImplementedException();
        }
    }

    public static class SomeExtension
    {
        public static Processor<T, T, T> With<T>(this T a)
        {
            throw new NotImplementedException();
        }
    }
}

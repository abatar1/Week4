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
        public static T For<T>(this MyEngine a)
        {
            throw new NotImplementedException();
        }
    }

    public static class MyLoggerExtension
    {
        public static Processor<T, T, T> With<T>(this MyEntity a)
        {
            throw new NotImplementedException();
        }
    }
}

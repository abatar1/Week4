using System;

namespace Week4
{
    public static class ProcessorBuilder
    {
        public static TEngine CreateEngine<TEngine>()
        {
            throw new NotImplementedException();
        }
    }

    public static class MyEngineExtension
    {
        public static TEntity For<TEntity>(this MyEngine a)
        {
            throw new NotImplementedException();
        }
    }

    public static class MyLoggerExtension
    {
        public static Processor<MyEngine, MyEntity, TLogger> With<TLogger>(this MyEntity a)
        {
            throw new NotImplementedException();
        }

    }
}

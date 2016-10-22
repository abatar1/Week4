namespace Week4
{
    public static class ProcessorBuilder
    {
        public static T CreateEngine<T>() where T: new()
        {
            return new T();
        }
    }

    public static class MyEngineExtension
    {
        public static MyLogger For<T>(this MyEngine a)
        {
            return new MyLogger();
        }
    }

    public static class SomeExtension
    {
        public static Processor<T, T, T> With<T>(this T a)
        {
            return new Processor<T, T, T>();
        }
    }
}

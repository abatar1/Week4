namespace Week4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = ProcessorBuilder.CreateEngine<MyEngine>()
                                            .For<MyEntity>()
                                            .With<MyLogger>();
                                            
        }
    }
}

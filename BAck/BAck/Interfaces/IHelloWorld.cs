namespace BAck.Interfaces
{
    public interface IHelloWorld
    {
        void Hello(string name);
    }

    public class HelloService : IHelloWorld
    {
        private Random random = new Random();
        public void Hello(string name)
        {
            Console.WriteLine($"Привет, {name}! {random.Next(0,42)}");
        }
    }
}

namespace _006_AsyncAwait
{
    internal class MyClass
    {
        public void Operation()
        {
            Console.WriteLine("Primary Thread Id = {0}", Environment.CurrentManagedThreadId);
        }

        public async Task OperationAsync()
        {
            await Task.Factory.StartNew(Operation);
        }
    }
}

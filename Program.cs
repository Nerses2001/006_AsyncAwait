using _006_AsyncAwait;

MyClass my = new ();

Task task = my.OperationAsync();

await task.ContinueWith(t => Console.WriteLine("Continuing the task"));

Console.ReadLine();
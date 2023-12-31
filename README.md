# 006_AsyncAwait
## Asynchronous Programming with C#

This project contains an example of asynchronous code implemented in C# using the `async/await` technique.

## Terms

### Task

In C#, a Task represents an asynchronous operation or task that can be executed asynchronously. It is an abstraction designed for performing asynchronous operations in .NET.

### `ContinueWith` Method in the Task Class

The `ContinueWith` method allows you to specify an action to be performed after the completion of a task (Task). This can be useful for specifying subsequent steps to be executed after the completion of an asynchronous operation.

## Code Example

```csharp
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

using _006_AsyncAwait;

MyClass my = new ();

Task task = my.OperationAsync();

await task.ContinueWith(t => Console.WriteLine("Continuing the task"));

Console.ReadLine();
```
In this example, an instance of the MyClass class is created, an asynchronous operation is performed using the OperationAsync method, which asynchronously starts the Operation method. Then, ContinueWith is used to perform an action after the task is completed. In this case, the message "Continuing the task" will be displayed after the task is completed.
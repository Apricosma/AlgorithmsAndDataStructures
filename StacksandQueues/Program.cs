char[] letters = { 'a', 'b', 'c' };

Queue<int> intQueue = new Queue<int>();
Stack<int> intStack = new Stack<int>();

// Queue: first in, first out
// stack: first in, last out

intStack.Push(0);
intStack.Push(1);
intStack.Push(2);
intStack.Push(3);

int[] ints = intStack.ToArray();
Stack<int> secondStack = new Stack<int>();

// removes the top value of the stack
Console.WriteLine(intStack.Pop());

for (int i = 0; i < intStack.Count; i++ )
{
    secondStack.Push(intStack.Pop());
}

foreach(int i in secondStack)
{
    Console.WriteLine(i);
}

Console.WriteLine();
intQueue.Enqueue(0);
intQueue.Enqueue(1);

Console.WriteLine(intQueue.Dequeue());
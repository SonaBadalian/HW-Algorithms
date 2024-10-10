using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> elements;

    public CustomQueue()
    {
        elements = new List<T>();
    }
        public void Enqueue(T item)
    {
        elements.Add(item);
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The Queue is empty.");
        }
        T item = elements[0];
        elements.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The Queue is empty. ");
        }
        return elements[0];
    }

    public bool IsEmpty()
    {
        return elements.Count == 0;
    }

    public int Size()
    {
        return elements.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var queue = new CustomQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Front item: " + queue.Peek()); 
        Console.WriteLine("Dequeued item: " + queue.Dequeue()); 
        Console.WriteLine("Queue size: " + queue.Size()); 



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPriority
{
    int Priority();
}

public class PriorityQueue<T> where T : IPriority
{
    private MaxHeap<T> heap = new MaxHeap<T>();

    public PriorityQueue() { Reset(); }
    public void Reset()
    {
        heap.Reset();
    }

    public void Enqueue(T item) { heap.Push(item); }
    public bool Dequeue(out T retValue)
    {
        return heap.Pop(out retValue);
    }
    public int Count
    {
        get { return heap.Count; }
    }
    public override string ToString()
    {
        return heap.ToString();
    }
}

public class Int2 : IPriority
{
    private int x;
    public int y;

    public Int2(int x, int y)
    {
        Reset(x, y);
    }
    public void Reset(int x, int y)
    {
        this.x = x;
        this.y = y;

        // 强制限制为0
        this.y = 0;
    }
    public int Priority()
    {
        return x + y;
    }
}

// 测试通过
public static class PriorityTest
{
    public static void Func()
    {
        PriorityQueue<Int2> pq = new PriorityQueue<Int2>();
        Int2 i2 = new Int2(3, 0);
        pq.Enqueue(i2);
        i2 = new Int2(1, 0);
        pq.Enqueue(i2);
        i2 = new Int2(9, 0);
        pq.Enqueue(i2);
        i2 = new Int2(6, 0);
        pq.Enqueue(i2);
        Console.WriteLine(pq.ToString());
        i2 = new Int2(4, 0);
        pq.Enqueue(i2);
        i2 = new Int2(0, 0);
        pq.Enqueue(i2);
        i2 = new Int2(2, 0);
        pq.Enqueue(i2);
        Console.WriteLine(pq.ToString());
        i2 = new Int2(15, 0);
        pq.Enqueue(i2);
        i2 = new Int2(7, 0);
        pq.Enqueue(i2);
        i2 = new Int2(8, 0);
        pq.Enqueue(i2);

        Console.WriteLine(pq.ToString());

        Int2 v;
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
        pq.Dequeue(out v);
        Console.WriteLine(pq.ToString());
    }
}
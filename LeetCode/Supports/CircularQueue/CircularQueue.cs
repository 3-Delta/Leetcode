using System;
using System.Collections.Generic;

public class CircularQueue<T>
{
    private T[] queue;
    private int head;
    private int tail;
    private int capacity;

    public CircularQueue(int capacity)
    {
        Reset(capacity);
    }
    public void Reset(int capacity)
    {
        this.capacity = capacity;
        this.queue = new T[capacity];
        this.head = this.tail = 0;
    }
    public void Reset()
    {
        this.head = this.tail = 0;
    }

    public bool Push(T value)
    {
        // ensure:头尾不交叉
        bool ret = (tail + 1) % capacity != head;
        if (ret)
        {
            queue[tail] = value;
            tail = (tail + 1) % capacity;
        }
        return ret;
    }
    public bool Top(out T retValue)
    {
        retValue = default(T);
        bool ret = tail != head;
        if (ret)
        {
            retValue = queue[head];
        }

        return ret;
    }
    public bool Pop(out T retValue)
    {
        retValue = default(T);
        bool ret = tail != head;
        if (ret)
        {
            retValue = queue[head];
            head = (head + 1) % capacity;
        }

        return ret;
    }
}
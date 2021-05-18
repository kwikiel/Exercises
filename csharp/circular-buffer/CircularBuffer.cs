using System;

public class CircularBuffer<T>
{
    private T[] array;
    int base_point; 
    int head;
    int tail;
    int length;
    int count; 
    public CircularBuffer(int capacity)
    {
        array = new T[capacity];
        base_point = 0;
        head = 0;
        tail = 0;
        count = 0;
        length = capacity; 
    }
    public T Read()
    {
        if(count == 0)
        {
            throw new InvalidOperationException("Empty buffer, cannot read from, it");
        }
        int old_tail = tail;
        tail++;
        tail = tail % length;
        count = count - 1; 
        return array[old_tail];
    }

    public void Write(T value)
    {
        if(count == length)
        {
            throw new InvalidOperationException("Full buffer, cannot");
        } 
        array[head] = value;
        this.head++;
        head = head % length;
        count = count + 1; 
    }

    public void Overwrite(T value)
    {
        if(count < length)
        {
            Write(value);
        }
        else {
            array[tail] = value;
            tail++;
            tail = tail % length;
        }

    }

    public void Clear()
    {
        tail = 0;
        head = 0;
        count = 0; 
        for(int i = 0; i< array.Length; i++)
        {
            array[i] = default(T); 
        }
    }
}
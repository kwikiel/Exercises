using System;

public class CircularBuffer<T>
{
    private T[] array;
    int head;
    int size; 
    public CircularBuffer(int capacity)
    {
        array = new T[capacity];
        size = 0; 
    }

    public T Read()
    {
        if(size == 0)
        {
            throw new InvalidOperationException("You need to implement this function.");
        }
        return array[0];
    }

    public void Write(T value)
    {
        size++;
    }

    public void Overwrite(T value)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public void Clear()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
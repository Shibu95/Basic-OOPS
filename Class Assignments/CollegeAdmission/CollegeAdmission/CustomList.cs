using System;
using System.Collections;


namespace CollegeAdmission;

public partial class CustomList<Type>
{
    private int _count;
    private int _size;
    public int Count { get { return _count; } }
    public int Size { get { return _size; } }
    private Type[] _array;

    //property indexer
    public Type this[int index]
    {
        get { return _array[index]; }
        set { _array[index] = value; }
    }

    public CustomList()
    {
        _count = 0;
        _size = 4;
        _array = new Type[_size];
    }

    public CustomList(int size)
    {
        _count = 0;
        _size = size;
        _array = new Type[size];
    }

    public void Add(Type data)
    {
        if (_count == _size)
        {
            GrowSize();
        }
        _array[_count] = data;
        _count++;

    }
    //To double the size of the array
    public void GrowSize()
    {
        _size *= 2;
        Type[] temp = new Type[_size];
        for (int i = 0; i < _count; i++)
        {
            temp[i] = _array[i];
        }
        _array = temp;
    }
    //To extend the size of the array
    public void AddRange(CustomList<Type> dataList)
    {
        _size = _size + dataList.Count + 4;
        Type[] temp = new Type[_size];
        for (int i = 0; i < _count; i++)
        {
            temp[i] = _array[i];
        }
        int k = 0;
        for (int j = _count; j < _count + dataList.Count; j++)
        {
            temp[j] = dataList[k];
        }
        k++;
        _array = temp;
        _count += dataList.Count;

    }

    public void Insert(int position, Type data)
    {
        _size++;
        Type[] temp = new Type[_size];
        for (int i = 0; i < _count+1; i++)
        {
            if (i < position)
            {
                temp[i] = _array[i];
            }
            else if (i == position)
            {
                temp[i] = data;
            }
            else
            {
                temp[i] = _array[i - 1];
            }
        }
        _array = temp;
        _count++;
    }

    public void RemoveAt(int position)
    {
        for(int i=0;i<_count;i++)
        {
            if(i==position)
            {
                _array[i]=_array[i+1];
            }
            else if(i>position && i+1<_count)
            {
                _array[i]=_array[i+1];
            }
        }
        _count--;
    }



}

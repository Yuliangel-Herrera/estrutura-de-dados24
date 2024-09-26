public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList<T> : IEnumerable<T>
{
    public Node<T> Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void Add(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void PrintList()
    {
        Node<T> current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Exemplo
LinkedList<int> list = new LinkedList<int>();
list.Add(02);
list.Add(76);
list.Add(89);
list.PrintList(); 
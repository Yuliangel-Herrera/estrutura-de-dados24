public class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public string Genero { get; set; }

    public Musica(string titulo, string artista, string genero)
    {
        Titulo = titulo;
        Artista = artista;
        Genero = genero;
    }
}

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

public class CircularLinkedList<T> : IEnumerable<T>
{
    public Node<T> Head { get; set; }

    public CircularLinkedList()
    {
        Head = null;
    }

    public void Add(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (Head == null)
        {
            Head = newNode;
            newNode.Next = Head;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != Head)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = Head;
        }
    }

    public void PrintList()
    {
        Node<T> current = Head;
        if (current != null)
        {
            do
            {
                Musica musica = (Musica)current.Value;
                Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}, Gênero: {musica.Genero}");
                current = current.Next;
            } while (current != Head);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = Head;
        if (current != null)
        {
            do
            {
                yield return current.Value;
                current = current.Next;
            } while (current != Head);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Exemplo de uso
CircularLinkedList<Musica> playlist = new CircularLinkedList<Musica>();
playlist.Add(new Musica("Happy", "Pharrell Williams", "Pop"));
playlist.Add(new Musica("Uptown Funk", "Mark Ronson ft. Bruno Mars", "Funk"));
playlist.Add(new Musica("Can't Stop the Feeling!", "Justin Timberlake", "Pop"));
playlist.PrintList();

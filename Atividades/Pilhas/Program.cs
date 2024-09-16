// Basicamente as pilhas trabalham com uma estrutura LIFO -> Last In First Out 
// Três métodos importantes:
// Push() -> Insere um elemento no topo da pilha 
// Pop() -> Remove um elemento do topo e o retorna
// Peek() -> Retorna o elemento do topo sem removê

// Invertendo as bolas
Stack<char> caracteres = new Stack<char>();
foreach(char c in "DARCY DA MONTANHA") // Base da pilha "D" / Ponta da pilha "A"
{
    caracteres.Push(c);
}

// Desenpilhando
string invertido = string.Empty;
while(caracteres.Count > 0)
{
    invertido += caracteres.Pop();
}
Console.WriteLine(invertido);



using System.Collections;

// Utilizando a lista simples
// ArrayList arrayList= new ArrayList(); ou a opção mais rapida 
ArrayList arrList = new();
arrList.Add(5);
arrList.Add("Mauricio");

// É possivel adicionar um conjunto de valores de uma só vez
arrList.AddRange(new int[] {1,2,3});

// O método .Add() insere o valor ao final do vetor

arrList.Insert(1, 15);
// Já o metodo insert, me permite incluir o valor desejado na posição especificada no primeiro parãmetro

// Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.WriteLine(obj);
}
//Obtendo o tamanho total da lista
int tamanho = arrList.Count;

// Obter a capacidade quantos podem ser armazenados
int capacidade = arrList.capacity;

// Percorrendo no modo clasico 
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}")
}
// Recursos importantes da lista 
// Verificando é contido na lista 
bool contemNome = arrList.Contains("Lola");
if(!contemNome)
    Console.WriteLine("Nome Lola não encontrado");

// Para saber o índice que contem o valor buscado
// Neste caso se o valor existir na lista ele retorna o índice (número inteiro)
// Caso o valor não exista na lista, retorna -1
int indiceDoValor = arrList.IndexOf("Lola");
if(indiceDoValor >= 0)
   Console.WriteLine(
    $"Lola está em [{indiceDoValor}]";
   );
else
{
    Console.WriteLine("È, realmente não tem.");
}
// È possivel tambem remover item da lista
arrList.Remove("Lola"); // Remove pelo vaor
arrList.Remove(4); // Remove no índice
arrList.RemoveRange(0,2); // Primeiro paramêtro = indice, segundo = quantas casas após o indice
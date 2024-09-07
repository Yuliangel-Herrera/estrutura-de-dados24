// È conhecido como vetor de vetores

int [][] nombers = new int [5][]; // [][] indica que é um vetor de vetor
                                 // 4 pocições contendo vetores de tamanho indefinido

numbers [0] = new int [] {1,2,3};
numbers [1] = new int [] {4,3,2,1,0};
numbers [2] = new int [] {1,2,0};
numbers [3] = new int [] {57};
numbers [4] = null!;

//Para obter valor de jaggedArray
int valor = numbers [0][2];
Console.WriteLine (valor);

// Para atribuir valor em um jaggedArray
numbers[1][2] = 0;
Console.WriteLine (numbers[1][2] );
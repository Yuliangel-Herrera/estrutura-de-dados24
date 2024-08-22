//Comentario

/* 
   Comentario multiplas linhas
*/

// Declarando variavel
using Aula01;

int number;
number = 10;

 //Atribuindo valor
const int DAYS_IN_WEEK = 7;

//Imprimindo string concatenada
Console.WriteLine($"a SEMANA TEM {DAYS_IN_WEEK} dias.");

/*
*/
TipoEnum tipoEnum = new TipoEnum(); 

TipoEnum.Language enumEnglish = tipoEnum.GetLanguageEnum("ingles");

Console.WriteLine($"O enum de englês é {enumEnglish}");

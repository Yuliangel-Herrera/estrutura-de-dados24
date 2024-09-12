using ListaGenerica;

List<double> numbers = new List<double>();
do
{
    Console.WriteLine("Informe um número: ");
    string? numberStr = Console.ReadLine(); // string? permite que o valor seja 0 ou nulo
    //validando a entrada do usuário
    if(!double.TryParse(numberStr, out double number)) // variavel criada dentro da função
        break; // Pode ficar sem {} quando tiver uma condição só
    
    numbers.Add(number);
    Console.WriteLine($"A media dos valores é {numbers.Average()}");
}
while(true);

// Lista pessoas 
List <Person> people = new List <Person> ();
Person p1 = new Person();
p1.Name = "João";
p1.Age = 12;
p1.country = CountryEnum.BR;
people.Add(p1);

p1.Name = "boboca";

people.Add(new Person(){
    Name= "Lee Jeno",
    Age = 24,
    country = CountryEnum.KO
});

Person p3 = new Person(){
    Name= "mocotó",
    Age = 30,
    country = CountryEnum.US
};
people.Add(p3);

//formas de percorrer lista generica
foreach(Person p in people){
    Console.WriteLine(p.Name);
}
//Modo for tradicional
for (int i =0; i<people.Count; i++){
    Console.WriteLine( $"nome: {people[i].Name}");
}
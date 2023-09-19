// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numbersString = "0 1 2 3 4 5 6 7 8 9";
var numberArray = numbersString.Split(' ');

//Aqui é feita uma conversão de um tipo de array para outro tipo de array
var convertToList = Array.ConvertAll(numberArray, Convert.ToInt32);

//Neste caso foi feita uma conversao de array para lista
List<string> listaArray = new List<string>(numberArray);

Console.WriteLine(convertToList);



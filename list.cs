Lists:

String interpolation:
var names = new List<string> { "<name>", "sithamshu", "teegala" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Output:
Hello <NAME>!
Hello SITHAMSHU!
Hello TEEGALA!


Modify list contents:

var names = new List<string> { "<name>", "sithamshu", "teegala" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it");
Output:
Hello <NAME>!
Hello SITHAMSHU!
Hello TEEGALA!

Hello <NAME>!
Hello SITHAMSHU!
Hello TEEGALA!
Hello MARIA!
Hello BILL!
My name is <name>.
I've added TEEGALA and Maria to the list.
The list has 5 people in it


Search and sort lists:

var index = names.IndexOf("TEEGALA");
if (index != -1)
  Console.WriteLine($"The name {names[index]} is at index {index}");
var notFound = names.IndexOf("Not Found");
  Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
  names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
Output:
The name TEEGALA is at index 2
When an item is not found, IndexOf returns -1
Hello <NAME>!
Hello TEEGALA!
Hello BILL!
Hello MARIA!
Hello SITHAMSHU!


Fibonacci series:

var fibonacciNumbers = new List<int> {1, 1};
while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);
Output:
1
1
2
3
5
8
13
21
34
55
89
144
233
377
610
987
1597
2584
4181
6765
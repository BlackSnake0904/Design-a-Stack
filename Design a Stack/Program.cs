// See https://aka.ms/new-console-template for more information

using Design_a_Stack;

Console.WriteLine("Hello, World!");



Zasobnik stack = new Zasobnik();
stack.Push(1);
stack.Push(2);
stack.Push(3);


Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop()); 
Console.WriteLine(stack.Pop());
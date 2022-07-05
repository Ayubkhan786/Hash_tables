using Hashtable;
Console.WriteLine("Welcome to Hash Tables program");

//To find the frequency of words

HashFrequency<string> list = new HashFrequency<string>();

list.Insert("to");
list.Insert("be");
list.Insert("or");
list.Insert("not");
list.Insert("to");
list.Insert("be");


string f1, f2;
Console.WriteLine("Enter the String : ");
f1 = Console.ReadLine();
Console.WriteLine(HashFrequency<string>.FindFrequency(f1, "to"));
f2 = Console.ReadLine();
Console.WriteLine(HashFrequency<string>.FindFrequency(f2, "be"));













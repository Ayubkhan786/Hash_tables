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




//To find the frequency of Larger words

string l1;
Console.WriteLine("Enter the String : ");
l1 = "Paranoids are notparanoid because they are paranoid butbecause they keep putting themselvesdeliberately into paranoid avoidablesituations";
Console.WriteLine(HashFrequency<string>.FindFrequency(l1, "paranoid"));







//To Delete the Word

string Del = "Paranoids are notparanoid because they are paranoid butbecause they keep putting themselvesdeliberately into paranoid avoidable situations";

HashFrequency<string> list1 = new HashFrequency<string>();

list1.Insert("to");
list1.Insert("be");
list1.Insert("or");
list1.Insert("not");
list1.Insert("to");
list1.Insert("be");
list1.Insert("Paranoids are notparanoid because they are paranoid butbecause they keep putting themselvesdeliberately into paranoid avoidable situations");
list1.Delete("avoidable",Del.GetHashCode());




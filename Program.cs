string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

string[] fraudulentIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentIDs[0]}");
Console.WriteLine($"Second: {fraudulentIDs[1]}");
Console.WriteLine($"Third: {fraudulentIDs[2]}");

fraudulentIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentIDs[0]}");
Console.WriteLine($"There are {fraudulentIDs.Length} fraudulent orders to process.");

//LOOPING

string[] names = {"Rowena", "Robin", "Bao"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");

string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string id in orderIDs)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}
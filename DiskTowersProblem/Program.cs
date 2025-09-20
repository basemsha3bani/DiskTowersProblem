
using DiskTowersProblem;
using System.Text.RegularExpressions;

Console.WriteLine("Enter number of disks");

int numberOfDisks;
if(!int.TryParse(Console.ReadLine(),out numberOfDisks))
{
    Console.WriteLine("invalid number");
    return;
}
if(numberOfDisks<=0 ||numberOfDisks>10000000)
{
    Console.WriteLine("number out of range");
    return;
}
Console.WriteLine("Enter disk sizes");
List<int>DiskSizes = Console.ReadLine().Split(" ").Select(s=>
{
    int diskSize;
    if(!int.TryParse(s,out diskSize))
    {
        return 0;
        
    }
    return diskSize;

}).ToList();

DiskTowerBulder towerBulder = new DiskTowerBulder();
towerBulder.diskSizes = DiskSizes;
towerBulder.numberOfDisks = numberOfDisks;

List<string> blocks= towerBulder.buildTower();


Console.ReadLine();


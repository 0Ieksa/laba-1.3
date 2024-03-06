List<int> list = new List<int>() {1,2,3,1,4,5,2,2,1};

var norepeat = list.Distinct();

foreach (int i in norepeat)
{
    Console.Write(i + " ");
}

Console.ReadKey();
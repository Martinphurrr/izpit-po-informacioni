// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int[] arr = {4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7};
Array.Sort(arr);
Console.Write("podreden masiv: ");
Console.WriteLine(string.Join(" ,",arr));
List<int> sortArr = new List<int>();
sortArr.Add(arr[0]);

for (int i = 1; i < arr.Length; i++) 
{ 
    if (arr[i] == sortArr[sortArr.Count - 1] + 1)
    { 
      sortArr.Add(arr[i]);
    }
    else
    {
        break;
    }
}
Console.Write("nay-dulgata poreica ot nay-malkoto: ");
Console.WriteLine(string.Join(" ,",sortArr));
Console.WriteLine("dylzhina: " +sortArr.Count);
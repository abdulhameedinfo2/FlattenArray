
var arr = new object[] { 1, new object[] { 2, new object[] { 3, 4 } }, 5 };
var result = new FlattenArray().Flatten(arr);
Console.WriteLine(string.Join(", ", result));
public class FlattenArray
{
    public int[] Flatten(object[] arr)
    {
        var flattenArray = new List<int>();
        FlattenRecursive(arr, flattenArray);
        return flattenArray.ToArray();
    }

    private void FlattenRecursive(object[] arr, List<int> flattenArray)
    {
        foreach (object o in arr)
        {
            if (o is int)
            {
                flattenArray.Add((int)o);
            }
            else if (o is object[])
            {
                FlattenRecursive((object[])o, flattenArray);
            }
        }
    }
}

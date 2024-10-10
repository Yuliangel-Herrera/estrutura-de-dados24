using InsertionSort;

int[] nums = [0, 7, 6, 2, 20, 1];

Console.Write('[');
foreach(int i in nums){
    Console.Write($"{i} ");
}
Console.Write(']');

Console.Write(" Before sorting: ");
InsertionSort.InsertionSort.Print(nums);
InsertionSort.InsertionSort.Sort(nums);

Console.Write(" After sorting: ");
InsertionSort.InsertionSort.Print(nums);


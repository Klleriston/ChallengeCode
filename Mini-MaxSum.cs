 public static void miniMaxSum(List<int> arr)
 {
   arr.Sort();
   int totalSum = 0;
   foreach (int num in arr)
   {
     totalSum += num;
   }
   int minSum = totalSum - arr[arr.Count - 1];
   int maxSum = totalSum - arr[0];
   Console.WriteLine(minSum + " " + maxSum);
 }
   

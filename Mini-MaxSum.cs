 public static void miniMaxSum(List<int> arr)
 {
   arr.Sort();
   long totalSum = 0;
   foreach (int num in arr)
   {
     totalSum += num;
   }
   long minSum = totalSum - arr[arr.Count - 1];
   long maxSum = totalSum - arr[0];
   Console.WriteLine(minSum + " " + maxSum);
 }
   

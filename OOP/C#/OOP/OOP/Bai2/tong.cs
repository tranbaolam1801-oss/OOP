
 int n = int.Parse(Console.ReadLine());
 int[] A = new int[n];
 for (int i = 0; i < n; i++)
 {
     A[i] = int.Parse(Console.ReadLine());
 }

 foreach (var i in A)
 {
     Console.Write(i + " ");
 }
 Console.WriteLine();

 for (int i = A.Length - 1; i > -1; i--)
 {
     Console.Write(A[i] + " ");
 }
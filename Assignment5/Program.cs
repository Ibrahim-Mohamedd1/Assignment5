namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 19
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {

            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            #endregion
            #region Problem 20
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine("The sum of all elements in the array is: " + sum);
            #endregion
            #region Problem 21
            //Console.Write("Enter the size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] merged = new int[2 * n];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements for the second array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    merged[i] = arr1[i];
            //    merged[i + n] = arr2[i];
            //}

            //Array.Sort(merged);

            //Console.WriteLine("\nMerged and sorted array in ascending order:");
            //foreach (int num in merged)
            //{
            //    Console.Write(num + " ");

            //}
            #endregion
            #region Problem 22
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int[] freq = new int[n];
            //int visited = -1;

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] == visited)
            //        continue;

            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            freq[j] = visited;
            //        }
            //    }

            //    freq[i] = count;
            //}

            //Console.WriteLine("\nFrequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] != visited)
            //    {
            //        Console.WriteLine(arr[i] + " occurs " + freq[i] + " time(s)");
            //    }

            //}

            #endregion
            #region Problem 23
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min = arr[0];
            //int max = arr[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];
            //}

            //Console.WriteLine("\nMaximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion
            #region Problem 24
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must contain at least two elements.");
            //    return;
            //}

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int firstLargest = int.MinValue;
            //int secondLargest = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > firstLargest)
            //    {
            //        secondLargest = firstLargest;
            //        firstLargest = arr[i];
            //    }
            //    else if (arr[i] > secondLargest && arr[i] != firstLargest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //    Console.WriteLine("There is no second largest element (all elements may be the same).");
            //else
            //    Console.WriteLine("The second largest element is: " + secondLargest);
            #endregion
            #region Problem 25
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = n - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; 
            //            {
            //                maxDistance = distance;
            //            }
            //            break; 
            //        }
            //    }
            //}

            //Console.WriteLine("\nThe longest distance between two equal elements is: " + maxDistance);
            #endregion
            #region Problem 26
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //string reversed = "";
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    reversed += words[i];
            //    if (i != 0)
            //        reversed += " ";
            //}

            //Console.WriteLine(reversed);
            #endregion
            #region Problem 27
            //int rows, cols;

            //Console.Write("Enter number of rows: ");
            //rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //Console.WriteLine("\nEnter elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //Console.WriteLine("\nElements of the second array (copied from the first):");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            #region Problem 28
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element [{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
        }
    }
}
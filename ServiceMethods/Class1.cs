namespace Unittest;

public class Class1
{
   public string ReverseString(string input)
   {
       char[] charArray = input.ToCharArray();
          Array.Reverse(charArray);
          return new string(charArray);
   }
   
   public bool IsEven(int number)
   {
      if (number%2 == 0)
      {
         return true;
      }
      return false;
   }

   public int FindMax(int[] numbers)
   {
     return numbers.Max();
   }

   public int CountOccurrences(string input, char character)
   {
      int count = 0;

      foreach (char c in input)
      {
         if (c == character)
         {
            count++;
         }
         
      }

      return count;

   }
   
   public int[] RemoveDuplicates(int[] numbers)
   {
      HashSet<int> uniqueNumbers = new HashSet<int>();
      
      foreach (int num in numbers)
      {
         uniqueNumbers.Add(num);
      }
      
      return uniqueNumbers.ToArray();
   }
   
   public interface IClass
   {
      public void ReverseString(string input);
      bool IsEven(int number);
      int FindMax(int[] numbers);
      int CountOccurrences(string input, char character);

      int[] RemoveDuplicates(int[] numbers);
   }

}
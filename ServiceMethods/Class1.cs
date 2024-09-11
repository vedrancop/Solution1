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
   
   public interface IClass
   {
      public void ReverseString(string input);
      bool IsEven(int number);
      int FindMax(int[] numbers);
   }

}
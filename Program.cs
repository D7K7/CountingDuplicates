using System;

public class Kata
{
  public static int DuplicateCount(string str)
  {
      int duplicateCount = 0;
      int[] charCounts = new int[36]; // 26 letters + 10 digits
  
      str = str.ToLower(); // Convert the string to lowercase for case-insensitive comparison
  
      foreach (char c in str)
      {
          if (char.IsLetterOrDigit(c)) // Check if the character is a letter or digit
          {
              int index = GetCharIndex(c);
              if (index >= 0)
              {
                  if (charCounts[index] == 1)
                  {
                      duplicateCount++;
                  }
                  charCounts[index]++;
              }
          }
      }
  
      return duplicateCount;
  }
  
  static int GetCharIndex(char c)
  {
      if (char.IsLetter(c))
      {
          return c - 'a'; // Index for letters a to z
      }
      else if (char.IsDigit(c))
      {
          return c - '0' + 26; // Index for digits 0 to 9
      }
      else
      {
          return -1; // Not a valid alphanumeric character
      }
  }
}

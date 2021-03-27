using System;

  public static string Solution(string str) 
  {
    char[] charArray = str.ToCharArray();
    
    Array.Reverse( charArray );
    return new string( charArray );
  }


//More Efficient Solution?

// using System;
// using System.Linq;

//   public static string Solution(string str) 
//   {
//      return new string(str.ToArray().Reverse().ToArray());
//   }

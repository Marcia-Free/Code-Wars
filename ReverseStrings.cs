using System;

  public static string Solution(string str) 
  {
    char[] charArray = str.ToCharArray();
    
    Array.Reverse( charArray );
    return new string( charArray );

  }
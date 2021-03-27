using System;

  public static int CountSheeps(bool[] sheeps)
  {  
    int count = 0;
    
    foreach(bool sheep in sheeps) {      
      if(sheep == true) {
        count++;
      }

    }   
    return count;    
  }



//Better more Efficient practice?

//using System;
//using System.Linq;

//public static class Kata
//{
//  public static int CountSheeps(bool[] sheeps)
//  {
//    return sheeps.Count(s => s);
//  }
//}

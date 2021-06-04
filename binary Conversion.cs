using System;
using System.Collections.Generic;

/*

 You need to use a key-value pair data structure in order to hold the binary combinations (binary -> decimal) from 0 - F
  
 You will create a separate function (apart from the main) which will receive a binary number as a parameter.  

 You will create 2 different functions. One function will search your dictionary using the key as a parameter. 

 You will print the middle of the ascii_table without using the key (use some logic to determine the middle)

*/ 

// 0000 -> 0
// .........
// 1000 -> 8
// 1001 -> 9 
// 1010 -> A  
// .........
// 1111 -> F

class MainClass {
  
  // void means return nothing 

  static void printDict( Dictionary<string,string> table ){
    foreach  (KeyValuePair<string,string> data in table){
      Console.WriteLine("Key = {0}, Value = {1}", data.Key, data.Value);
    }
  } 

  static void search(Dictionary<string,string> table, string binary){
    string value = "";
    if(table.TryGetValue(binary,out value )){
      Console.WriteLine("Value = {0}", value);
    }
     else {
      Console.WriteLine("Sorry no can do");
    }

  }

  static void populateDict( Dictionary<string, string> table ){
    table.Add("0000", "0");
    table.Add("0001", "1"); 
    table.Add("0010", "2");
    table.Add("0011", "3");
    table.Add("0100", "4");
    table.Add("0101", "5");
    table.Add("0110", "6");
    table.Add("0111", "7");
    table.Add("1000", "8");
    table.Add("1001", "9");
    table.Add("1010", "A");
    table.Add("1011", "B");
    table.Add("1100", "C");
    table.Add("1101", "D");
    table.Add("1110", "E");
    table.Add("1111", "F");
  }
  
  public static void Main (string[] args) {
    Dictionary<string, string> ascii_table = new Dictionary<string, string>();
    populateDict(ascii_table);
    int i=0;

    while(i==0){
      Console.WriteLine("Enter your Binary Value: ");
      string binary = Console.ReadLine();
      printDict(ascii_table);
      search(ascii_table, binary);
    }

  }
  
}
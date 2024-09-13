using System;

namespace MadTeaParty
{
  class Program
  {
    static void Main(string[] args)
    {
      string drink = "wine";
      string madTeaParty = $"\Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but ther awas nothing on it but tea. \n\"I don't see any {drink},\" she remarked. \n\"There isn't any,\" said the March Hare.";

      int storyLength = madTeaParty.Length;
      string toFind = "March Hare";

      string findLowerCase = toFind.ToLower();
      int findMarchHare = madTeaParty.IndexOf(toFind);

    }
  }
}

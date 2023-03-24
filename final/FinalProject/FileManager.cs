using System;
using System.IO;

public class LCFileManager
{
  public LCFileManager()
  {

  }

  public List<List<string>> LCFileLoader()
  {
    List<List<string>> LCLines = new List<List<string>>();
    string LCFilename = "Recipets.txt";
    string[] LCLinesArray = System.IO.File.ReadAllLines(LCFilename);

    foreach (string LCLineArray in LCLinesArray)
    {
      List<string> LCParts = new List<string>();
      string[] LCPartsArray = LCLineArray.Split("|");

      foreach (string LCPartArray in LCPartsArray)
      {
        LCParts.Add(LCPartArray);
      }
      
      LCLines.Add(LCParts);
    }
    return LCLines;
  }

  public void LCFileSaver(List<string> LCRecieptList, int LCPointsTotal)
  {
    string LCFilename = "Reciepts.txt";
    string[] LCLinesArray = System.IO.File.ReadAllLines(LCFilename);
    List<string> LCLines = new List<string>();
    foreach (string LCLineArray in LCLinesArray)
    {
      LCLines.Add(LCLineArray);
    }

    string LCPointsTotalString = LCPointsTotal.ToString();

    LCLines[0] = LCPointsTotalString;

    foreach (string LCGoal in LCRecieptList)
    {
      LCLines.Add(LCGoal);
    }

    TextWriter LCClear = new StreamWriter(LCFilename, false);
    LCClear.Write(string.Empty);
    LCClear.Close();

    using (StreamWriter LCOutputFile = new StreamWriter(LCFilename))
    {
      foreach (string LCLine in LCLines)
      {
        LCOutputFile.WriteLine($"{LCLine}");
      }
    }
  }
}
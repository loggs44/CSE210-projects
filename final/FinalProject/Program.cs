using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Clear();
    List<String> Levels = new List<String>() { "Recruit", "Amatuer", "Skillfull Shopper", "Expert" };
    string CurrentLevel = Levels[0];
    int CurrentPoints = 0;
    List<ParentReciept> Reciepts = new List<ParentReciept>();
    LCMenu menu = new LCMenu();
    LCFileManager FileManager = new LCFileManager();
    bool KeepRunning = true;

    while (KeepRunning)
    {
      if (CurrentPoints > 800)
      {
        CurrentLevel = Levels[3];
      }
      else if (CurrentPoints > 500)
      {
        CurrentLevel = Levels[2];
      }
      else if (CurrentPoints > 300)
      {
        CurrentLevel = Levels[1];
      }
      Console.Clear();
      Print("Reciept Point Tracker");
      Print("");
      Print($"You have {CurrentPoints} points");
      Print("");
      Print($"You are a {CurrentLevel}");
      menu.LCMainMenu();
      String LCChoice = menu.LCUserSelection();
      switch (LCChoice)
      {
        case "1":
          //Create new goal
          menu.LCStoreMenu();
          LCChoice = menu.LCStoreSelection();
          String LCStoreName = "";
          string LCPurchaseDate = "";
          int LCpurchaseTotal = 0;
          int LCPointsTotal = 0;

          PrintNoBreak("What is the name of the store? ");
          LCStoreName = Read();
          Print("");
          PrintNoBreak("What was the purchase date?(Format: Day-Month-Year) ");
          LCPurchaseDate = Read();
          Print("");
          PrintNoBreak("What was the total?(Rounded to the nearest dollar) ");
          LCpurchaseTotal = int.Parse(Read());
          switch (LCChoice)
          {
            case "1":
              // Walmart Reciept
              WalmartReciept LCWalmart = new WalmartReciept(LCStoreName, LCPurchaseDate, LCPointsTotal, LCpurchaseTotal);
              Reciepts.Add(LCWalmart);
              break;
            case "2":
              // Target Reciept
              TargetReciept LCTarget = new TargetReciept(LCStoreName, LCPurchaseDate, LCPointsTotal, LCpurchaseTotal);
              Reciepts.Add(LCTarget);
              break;
            case "3":
              // SamsClubReciept
              SamsClubReciept LCSamsClub = new SamsClubReciept(LCStoreName, LCPurchaseDate, LCPointsTotal,LCpurchaseTotal);
              Reciepts.Add(LCSamsClub);
            break;
            case "4":
            // Albertsons Reciept
              AlbertsonsReciept LCAlbertsons = new AlbertsonsReciept(LCStoreName, LCPurchaseDate, LCPointsTotal,LCpurchaseTotal);
              Reciepts.Add(LCAlbertsons);
              break;            
          }
          break;
        case "2":
          // List goals
          Print("The Reciepts are:");
          int LCCounter = 1;
          foreach (ParentReciept reciept in Reciepts)
          {
            Print($"{LCCounter}. {reciept.LCToString()}");
            LCCounter++;
          }
          Print("Press Enter to continue");
          Read();
          break;
        case "3":
          // Save Goals
          Print("Saving Reciepts...");
          List<String> LCRecieptsAsStrings = new List<String>();

          foreach (ParentReciept reciept in Reciepts)
          {
            LCRecieptsAsStrings.Add(reciept.LCGetStringToSave());
          }

          FileManager.LCFileSaver(LCRecieptsAsStrings, CurrentPoints);

          Print("File Saved!");
          Print("Press Enter to continue");
          Read();
          break;
        case "4":
          // Load Goals
          Print("Loading Reciepts...");
          List<List<string>> LCLoadedRecieptsStrings = FileManager.LCFileLoader();

          Reciepts.Clear();

          CurrentPoints = int.Parse(LCLoadedRecieptsStrings[0][0]);
          LCLoadedRecieptsStrings.RemoveAt(0);

          foreach (List<String> record in LCLoadedRecieptsStrings)
          {
            switch (record[5])
            {
              case "walmart":
                WalmartReciept loadedwalmartreciept = new WalmartReciept(record[0], record[1], int.Parse(record[2]), int.Parse(record[3]));
                if (record[4] == "True")
                {
                  loadedwalmartreciept.LCAmountofPoints();
                }
                Reciepts.Add(loadedwalmartreciept);
                break;
              case "target":
                TargetReciept loadedtargetreciept = new TargetReciept(record[0], record[1], int.Parse(record[2]), int.Parse(record[3]));
                if (record[4] == "True")
                {
                  loadedtargetreciept.LCAmountofPoints();
                }
                Reciepts.Add(loadedtargetreciept);
                break;
              case "samsclub":
                SamsClubReciept loadedsamsclubreciept = new SamsClubReciept(record[0], record[1], int.Parse(record[2]), int.Parse(record[3]));
                if (record[4] == "True")
                {
                  loadedsamsclubreciept.LCAmountofPoints();
                }
                Reciepts.Add(loadedsamsclubreciept);
                break;
              case "albertsons":
                AlbertsonsReciept loadedalbertsonsreciept = new AlbertsonsReciept(record[0], record[1], int.Parse(record[2]), int.Parse(record[3]));
                if (record[4] == "True")
                {
                  loadedalbertsonsreciept.LCAmountofPoints();
                }
                Reciepts.Add(loadedalbertsonsreciept);
                break;
            }
          }
          Print("File loaded");
          Print("Press Enter to continue");
          Read();
          break;
        // case "5":
        //   // Record Event
        //   Print("The Reciepts:");
        //   int Counter2 = 1;
        //   foreach (ParentReciept Reciept in Reciepts)
        //   {
        //     Print($"{Counter2}. {Reciept.ToString()}");
        //     Counter2++;
        //   }
        //   PrintNoBreak("Which goal did you accomplish? ");
        //   int spamCompltGoal = int.Parse(SpamRead());
        //   int spamEarnedPoints = 0;
        //   if (spamGoals[spamCompltGoal - 1].SpamGetIsComplete())
        //   {
        //     SpamPrint("The goal is already complete.");
        //   }
        //   else
        //   {
        //     spamEarnedPoints = spamGoals[spamCompltGoal - 1].SpamRecordEvent();
        //   }

        //   SpamPrint("");
        //   SpamPrint($"Congratulations! You have earned {spamEarnedPoints} points!");
        //   spamCurrentPoints += spamEarnedPoints;
        //   SpamPrint($"You now have {spamCurrentPoints} points");
        //   SpamPrint("Press enter to continue");
        //   SpamRead();
        //   break;
        case "5":
          // Quit
          KeepRunning = false;
          break;
        default:
          Print("Invalid input. Please select one of the options");
          break;
      }
    }
    Console.Clear();
    Print("Thanks for using this program");

  }

  static void Print(String text)
  {
    Console.WriteLine(text);
  }

  static void PrintNoBreak(String text)
  {
    Console.Write(text);
  }

  static String Read()
  {
    return Console.ReadLine();
  }        
}
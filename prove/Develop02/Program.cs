// Logan Clark 1/24/23
using System;

class Program
{
    
    static void Main(string[] args)
    {
        int _lcUsrNum = -1;
        Journal journal = new Journal();
        ShowMenu();

        while (_lcUsrNum != 6)
        {
            Console.Write("Please use a number to select an option or 0 for menu options. ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out _lcUsrNum);
            if (!isNumber){
                _lcUsrNum = -1;
            }

            switch (_lcUsrNum)
            {
                case 0:
                ShowMenu();
                break;

                case 1: // Write new entry
                Question prompt = new Question();
                string newPrompt = prompt.RandPrompt;
                Console.Write(newPrompt );
                journal.AddEntry(Console.ReadLine(), newPrompt);
                break;

                case 2: // Display journal
                foreach (string entry in journal.Entries){
                    Console.WriteLine(entry);
                }
                break;

                case 3: //Load the jouranl from a file.
                // ask user for file name
                if (journal.FileName != string.Empty){
                    Console.Write(string.Format("Enter in a file name or enter to use {0}: ", journal.FileName));
                }
                else{
                    Console.Write("Enter a file name to load: ");
                }
                
                string loadFileName = Console.ReadLine();

                if (loadFileName == string.Empty){
                    loadFileName = journal.FileName;
                }
                //load the journal
                try{
                journal.Load(loadFileName);
                    foreach (string entry in journal.Entries){
                        Console.WriteLine(entry);
                    }                    
                }
                catch(Exception e){
                    Console.WriteLine(string.Format("An error occured loading the file. {0}", e.Message));
                }
                break;
                
                case 4: // Save the journal to a file
                //ask user for file name
                if (journal.FileName != string.Empty){
                    Console.Write(string.Format("Enter in a file name or enter to save {0}: ", journal.FileName));
                }
                else{
                    Console.Write("Enter a file name to save: ");
                }
                string userFile = Console.ReadLine();

                if (userFile == string.Empty){
                    userFile = journal.FileName;
                }

                //save the file
                try{
                journal.Save(userFile);
                //let the user know the results
                
                Console.WriteLine(string.Format("File saved successfully to {0}.", userFile));
                }
                catch(Exception e){
                    Console.WriteLine(string.Format("File save FAILED to {0}. {1}", userFile, e.Message));
                }
                break;

                case 5: //clear out and create a new journal
                    journal = new Journal();
                    Console.WriteLine("A new journal is ready! Please add entries (menu option 1).");
                
                break;
                
                case 6: //quit the program
                break;

                default:
                //Displays not valid entry
                Console.WriteLine(string.Format("{0} not a valid menu option. Please try again.", userInput));
                break;
            }

        }
    }

    static void ShowMenu(){
        //Provide a menu that allows the user choose these options
        Console.WriteLine("1. Write Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Load Journal");
        Console.WriteLine("4. Save Journal");
        Console.WriteLine("5. Start a new Journal");
        Console.WriteLine("6. Exit");
    }
}

/*
References:
https://learn.microsoft.com/en-us/dotnet/csharp/ - General place to look up keywords and syntax
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch - Used for try catch syntax
https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-7.0 - Used for tryparse syntax
https://www.w3schools.com/cs/cs_comments.php - Used for comments
https://www.geeksforgeeks.org/file-readalllinesstring-method-in-c-sharp-with-examples/ - Used for reading lines in a file syntax
https://parade.com/1308069/steph-nguyen/journaling-prompts/ - Used for Journal Questions.
Had help from my dad as well who programs in c# for a living.

*/
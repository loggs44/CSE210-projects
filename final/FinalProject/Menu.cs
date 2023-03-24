public class LCMenu{
    public LCMenu(){

    }

    public void LCMainMenu(){
        Console.WriteLine("Please select one of the follwoing:");
        Console.WriteLine("1. Enter New Reciept Info.");
        Console.WriteLine("2. List Reciepts");
        Console.WriteLine("3. Save Receipts");
        Console.WriteLine("4. Load Saved Reciepts");
        Console.WriteLine("5. Quit");
    }

    public string LCUserSelection(){
        Console.Write("Please choose from the options above: ");
        return Console.ReadLine();
    }

    public void LCStoreMenu(){
        Console.WriteLine("The different stores that earn rewards.");
        Console.WriteLine("1. Walmart");
        Console.WriteLine("2. Sam's Club");
        Console.WriteLine("3. Albertson's");
        Console.WriteLine("4. Target");
    }

    public string LCStoreSelection(){
        Console.Write("Please select one of the options above: ");
        return Console.ReadLine();
    }
}
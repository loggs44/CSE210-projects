class Journal
{
    public Journal()
    {}

    private List<string> _entries = new List<string>{};

    private string _fileName = string.Empty;

    public List<string> Entries{
        get{
            return _entries;
        }
    }

    public string FileName{
        get{
            return _fileName;
        }
    }

    public void AddEntry(string entry, string question){
        string formattedEntry = string.Format("{0:d}|{1}|{2}", DateTime.Now, question, entry);
        _entries.Add(formattedEntry);
    }

    public string ReadEntry(int position){
        return _entries[position];
    }

    public void Save(string fileName){
        //create the file - overwrite if it exists
        //go through entries and write to file
        // save the file to disk

        _fileName = fileName;

        File.WriteAllLines(fileName, _entries);
    }

    public void Load(string fileName){
        //grab the name from user
        if (File.Exists(fileName)){

            _fileName = fileName;

            //find the file on the disk
            string[] lines = File.ReadAllLines(fileName);
            _entries.Clear();
            foreach(string line in lines){
                _entries.Add(line);
            }
        }
        else{
            throw new Exception("File not found.");
        }
    }
}
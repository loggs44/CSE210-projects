class Journal
{
    public Journal()
    {}

    private List<string> _questions = new List<string>
    {
        "What is something that made you laugh today? ",
        "What steps did you take today towards a goal you are working on? ",
        "Who made your day better today? How can you pay that feeling forward? ",
        "What made today unique? ",
        "What is one thing you want to remember from today? ",
        "How can you make tomorrow (even) better than today? "
        
    };

    private List<Entry> _entries = new List<Entry>{};

    private string _fileName = string.Empty;

    public List<Entry> Entries{
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

        Entry log = new Entry(question, entry, DateTime.Now.ToShortDateString());
        _entries.Add(log);
    }

    public void Save(string fileName){
        //create the file - overwrite if it exists
        //go through entries and write to file
        // save the file to disk

        List<string> logsToWrite = new List<string>{};

        foreach(Entry e in _entries){
            logsToWrite.Add(string.Format("{0}|{1}|{2}", e.LogDate, e.Question, e.Log));
        }

        _fileName = fileName;

        File.WriteAllLines(fileName, logsToWrite);
    }

    public void Load(string fileName){

        

        //grab the name from user
        if (File.Exists(fileName)){

            _fileName = fileName;

            //find the file on the disk
            string[] lines = File.ReadAllLines(fileName);
            _entries.Clear();
            foreach(string line in lines){
                string[] logList = line.Split("|");
                Entry entry = new Entry(logList[1], logList[2], logList[0]);
                _entries.Add(entry);
            }
        }
        else{
            throw new Exception("File not found.");
        }
    }

    public string RandPrompt {
        get {
            var rand = new Random();
            int max = _questions.Count();
            int min = 0;

            return _questions[rand.Next(min, max)];

        }
    }
}
class Entry{
    //Constructor
    public Entry(string question, string logEntry, string logTime){
        _dateTime = logTime;
        _userInput = logEntry;
        _question = question;
    }

    private string _dateTime;

    private string _userInput = string.Empty;

    private string _question = string.Empty;

    public string LogDate{
        get{
            return _dateTime;
        }
    }

    public string Log{
        get{
            return _userInput;
        }
    }

    public string Question{
        get{
            return _question;
        }
    }

}
class Question{
    private List<string> _lcPrompts = new List<string>
    {
        "What is something that made you laugh today? ",
        "What steps did you take today towards a goal you are working on? ",
        "Who made your day better today? How can you pay that feeling forward? ",
        "What made today unique? ",
        "What is one thing you want to remember from today? ",
        "How can you make tomorrow (even) better than today? "
        
    };



    //constuctor
    public Question ()
    {

    }

    //property - Get and Set
    public string RandPrompt {
        get {
            var rand = new Random();
            int max = _lcPrompts.Count();
            int min = 0;

            return _lcPrompts[rand.Next(min, max)];

            }
    }
}
class Fraction{

    //Member Variables
    private int _top;

    private int _bottom;

    //Constructor to set variables equal to one.
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    //Constructor to set top number as a whole number.
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    //Getter and Setter for the top an bottom numbers.
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    //Method to return the number as a fraction.
    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }
    //Method to return the number in decimal form.
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}
public abstract class ParentReciept{

    protected string _LCstoreName;
    protected string _LCPuchaseDate;
    protected int _LCpoints;
    protected int _LCpurchaseTotal;
    public ParentReciept(string LCstoreName, string LCPuchaseDate, int LCpoints, int LCpurchaseTotal){
        _LCstoreName = LCstoreName;
        _LCPuchaseDate = LCPuchaseDate;
        _LCpoints = LCpoints;
        _LCpurchaseTotal = LCpurchaseTotal;
    }
    public abstract double LCAmountofPoints();

    public string LCToString(){
        return $"{_LCstoreName}|{_LCPuchaseDate}|{_LCpoints}|{_LCpurchaseTotal}";
    }

    public string LCGetStringToSave(){
        return $"{_LCstoreName}|{_LCPuchaseDate}|{_LCpoints}|{_LCpurchaseTotal}";
    }
}
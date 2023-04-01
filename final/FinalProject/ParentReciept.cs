public abstract class ParentReciept{

    protected int _LCstoreName;
    protected string _LCPuchaseDate;
    protected int _LCpoints;
    protected int _LCpurchaseTotal;
    public ParentReciept(int LCstoreName, string LCPuchaseDate, int LCpurchaseTotal, int LCpoints){
        _LCstoreName = LCstoreName;
        _LCPuchaseDate = LCPuchaseDate;
        _LCpoints = LCpoints;
        _LCpurchaseTotal = LCpurchaseTotal;
    }
    public abstract double LCAmountofPoints();

    public string LCToString(){
        return $"{_LCstoreName}|{_LCPuchaseDate}|{_LCpurchaseTotal}|{_LCpoints}";
    }

    public string LCGetStringToSave(){
        return $"{_LCstoreName}|{_LCPuchaseDate}|{_LCpurchaseTotal}|{_LCpoints}";
    }
}
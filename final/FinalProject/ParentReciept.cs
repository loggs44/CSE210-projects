public abstract class ParentReciept{

    protected string _LCstoreName;
    protected int _LCPuchaseDate;
    protected int _LCpoints;
    protected int _LCpurchaseTotal;
    public ParentReciept(string LCstoreName, int LCPuchaseDate, int LCpoints, int LCpurchaseTotal){
        _LCstoreName = LCstoreName;
        _LCPuchaseDate = LCPuchaseDate;
        _LCpoints = LCpoints;
        _LCpurchaseTotal = LCpurchaseTotal;
    }

    public abstract string LCToString();

    public abstract double LCAmountofPoints();

    public abstract String LCGetStringToSave();
}
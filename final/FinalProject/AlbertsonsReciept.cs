public class AlbertsonsReciept : ParentReciept
{
    public AlbertsonsReciept(string _LCstoreName, int _LCPuchaseDate, int _LCpoints, int _LCpurchaseTotal) : base(_LCstoreName, _LCPuchaseDate, _LCpoints, _LCpurchaseTotal)
    {

    }

    public override string LCToString()
    {
        return string.Format($"{0} {1} {2} {3}", _LCstoreName, _LCPuchaseDate, _LCpoints, _LCpurchaseTotal);
    }
    public override double LCAmountofPoints()
    {
        if (_LCpurchaseTotal < 50){
            return _LCpoints + 0;
        }
        else {
            return _LCpoints * 2;
        }
    }

    public override string LCGetStringToSave(){
        return string.Format($"{0} {1} {2} {3}", _LCstoreName, _LCPuchaseDate, _LCpoints, _LCpurchaseTotal);
    }
}
public class AlbertsonsReciept : ParentReciept
{
    public AlbertsonsReciept(int _LCstoreName, string _LCPuchaseDate, int _LCpurchaseTotal, int _LCpoints) : base(_LCstoreName, _LCPuchaseDate, _LCpurchaseTotal, _LCpoints)
    {

    }
    public override double LCAmountofPoints()
    {
        if (_LCpurchaseTotal > 500){
            return _LCpoints = _LCpurchaseTotal + 150;
        }
        else {
            return _LCpoints = _LCpurchaseTotal + 0;
        }
    }
}
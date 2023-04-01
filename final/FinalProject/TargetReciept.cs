public class TargetReciept : ParentReciept
{
    public TargetReciept(int _LCstoreName, string _LCPuchaseDate, int _LCpurchaseTotal, int _LCpoints) : base(_LCstoreName, _LCPuchaseDate, _LCpurchaseTotal, _LCpoints)
    {

    }
    public override double LCAmountofPoints()
    {
        if (_LCpurchaseTotal > 150){
            return _LCpoints = _LCpurchaseTotal + 50;
        }
        else {
            return _LCpoints = _LCpurchaseTotal + 0;
        }
    }
}
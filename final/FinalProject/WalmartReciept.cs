public class WalmartReciept : ParentReciept
{
    public WalmartReciept(int _LCstoreName, string _LCPuchaseDate, int _LCpurchaseTotal, int _LCpoints) : base(_LCstoreName, _LCPuchaseDate, _LCpurchaseTotal, _LCpoints)
    {

    }
    public override double LCAmountofPoints()
    {
        if (100 > _LCpurchaseTotal && _LCpurchaseTotal < 200){
            return _LCpoints = _LCpurchaseTotal * 2;
        }
        else {
            return _LCpoints = _LCpurchaseTotal + 0;
        }
    }
}
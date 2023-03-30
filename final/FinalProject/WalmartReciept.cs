public class WalmartReciept : ParentReciept
{
    public WalmartReciept(string _LCstoreName, string _LCPuchaseDate, int _LCpoints, int _LCpurchaseTotal) : base(_LCstoreName, _LCPuchaseDate, _LCpoints, _LCpurchaseTotal)
    {

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
}
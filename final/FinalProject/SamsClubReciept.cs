public class SamsClubReciept : ParentReciept
{
    public SamsClubReciept(string _LCstoreName, string _LCPuchaseDate, int _LCpurchaseTotal, int _LCpoints) : base(_LCstoreName, _LCPuchaseDate, _LCpurchaseTotal, _LCpoints)
    {

    }
    public override double LCAmountofPoints()
    {
        if (_LCpurchaseTotal > 300){
            return _LCpoints = _LCpurchaseTotal + 100;
        }
        else {
            return _LCpoints = _LCpurchaseTotal + 0;
        }
    }
}
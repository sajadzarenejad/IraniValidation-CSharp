namespace IraniValidator
{
    public enum PhoneFormatType
    {
        //example 09198765432
        //this is the default format
        StartWithZero = 1,

        //example 989198765432
        StartWith98 = 2,

        //example 9198765432
        StartWith9 = 3

    }


    /// <summary>
    /// Choose proper oprator
    /// </summary>
    public enum OpratorType{
        AllOpprator=0,
        HamrahAval=1,
        IranCell=2,
        Rightel=3
    }
}
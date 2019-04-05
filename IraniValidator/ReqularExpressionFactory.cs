namespace IraniValidator
{
    internal class ReqularExpressionFactory
    {
        private readonly PhoneFormatType _phoneFormat;

        public ReqularExpressionFactory(PhoneFormatType phoneFormat)
        {
            _phoneFormat = phoneFormat;
        }
        public string HamrahAvalExpressionMaker()
        {
            switch (_phoneFormat)
            {
                default : case PhoneFormatType.StartWithZero :
                    return "09(1[0-9]|90)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith98:
                    return "989(1[0-9]|90)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith9:
                    return "9(1[0-9]|90)-?[0-9]{3}-?[0-9]{4}";

            }
        }

        public string IrancellExpressionMaker()
        {
            switch (_phoneFormat)
            {
                default:
                case PhoneFormatType.StartWithZero:
                    return "09(01|02|03|05|30|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith98:
                    return "989(01|02|03|05|30|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith9:
                    return "9(01|02|03|05|30|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";

            }
        }

        public string RightelExpressionMaker()
        {
            switch (_phoneFormat)
            {
                default:
                case PhoneFormatType.StartWithZero:
                    return "09(20|21|22)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith98:
                    return "989(20|21|22)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith9:
                    return "9(20|21|22)-?[0-9]{3}-?[0-9]{4}";

            }
        }
    }

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
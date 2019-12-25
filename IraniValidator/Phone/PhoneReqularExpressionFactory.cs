namespace IraniValidator
{
    internal class PhoneReqularExpressionFactory
    {
        private readonly PhoneFormatType _phoneFormat;

        public PhoneReqularExpressionFactory(PhoneFormatType phoneFormat)
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
                    return "09(01|02|03|05|30|33|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith98:
                    return "989(01|02|03|05|30|33|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";
                case PhoneFormatType.StartWith9:
                    return "9(01|02|03|05|30|33|35|36|37|38|39)-?[0-9]{3}-?[0-9]{4}";

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
}
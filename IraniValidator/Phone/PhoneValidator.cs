using System;
using System.Text.RegularExpressions;

namespace IraniValidator
{
    public static class PhoneValidator
    {
        public static bool IsValidMobile(this string mobile,OpratorType oprator=OpratorType.AllOpprator,PhoneFormatType type=PhoneFormatType.StartWithZero)
        {
            switch (oprator)
            {
                default:case OpratorType.AllOpprator:
                    return HamrahavalValidation(mobile, type) || IrancellValidation(mobile, type) ||
                           RightelValidation(mobile, type);
                case OpratorType.HamrahAval:
                    return HamrahavalValidation(mobile, type);
                case OpratorType.IranCell:
                    return IrancellValidation(mobile, type);
                case OpratorType.Rightel:
                    return RightelValidation(mobile, type);
            }
        }

        static bool HamrahavalValidation(string mobile,PhoneFormatType type)
        {
            var regexgen = new PhoneReqularExpressionFactory(type);

            var regex = new Regex(regexgen.HamrahAvalExpressionMaker());

            return regex.IsMatch(mobile);
            
        }
        static bool IrancellValidation(string mobile, PhoneFormatType type)
        {
            var regexgen = new PhoneReqularExpressionFactory(type);

            var regex = new Regex(regexgen.IrancellExpressionMaker());

            return regex.IsMatch(mobile);

        }
        static bool RightelValidation(string mobile, PhoneFormatType type)
        {
            var regexgen = new PhoneReqularExpressionFactory(type);

            var regex = new Regex(regexgen.RightelExpressionMaker());

            return regex.IsMatch(mobile);

        }
    }


}

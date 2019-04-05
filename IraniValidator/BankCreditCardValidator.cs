namespace IraniValidator
{
    public static class BankCreditCardValidator
    {
        public static bool IsValidCreditCard(this string cardNumbber)
        {
            var l = cardNumbber.Length;
            if (l < 16 || long.Parse(cardNumbber.Substring(1, 10)) == 0 || long.Parse(cardNumbber.Substring(10, 6)) == 0) return false;
            var c = long.Parse(cardNumbber.Substring(15, 1));
            long s = 0;
            long k, d;
            for (var i = 0; i < 16; i++)
            {
                k = (i % 2 == 0) ? 2 : 1;
                d = long.Parse(cardNumbber.Substring(i, 1)) * k;
                s += (d > 9) ? d - 9 : d;
            }
            return ((s % 10) == 0);
        }
    }
}

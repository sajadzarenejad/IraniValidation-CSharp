
namespace IraniValidator
{
    public static class NationalIdValidator
    {
        public static bool IsValidPersonNationalId(this string nationalId)
        {
            var l = nationalId.Length;

            if (l < 8 || long.Parse(nationalId) == 0) return false;

            nationalId = ("0000" + nationalId).Substring(l + 4 - 10);

            if (int.Parse(nationalId.Substring(3, 6)) == 0) return false;


            var c = long.Parse(nationalId.Substring(9, 1));
            long s = 0;
            for (var i = 0; i < 9; i++)
                s += long.Parse(nationalId.Substring(i, 1)) * (10 - i);
            s = s % 11;
            return (s < 2 && c == s) || (s >= 2 && c == (11 - s));
        }


        public static bool IsValidCompanyNationalId(this string nationalId)
        {
            var l = nationalId.Length;

            if (l < 11 || long.Parse(nationalId) == 0) return false;

            if (long.Parse(nationalId.Substring(3, 6)) == 0) return false;
            var c = long.Parse(nationalId.Substring(10, 1));
            var d = long.Parse(nationalId.Substring(9, 1)) + 2;

            var z = new[]{29, 27, 23, 19, 17};

            long s = 0;
            for (var i = 0; i < 10; i++)
                s += (d + long.Parse(nationalId.Substring(i, 1))) * z[i % 5];
            s = s % 11; if (s == 10) s = 0;
            return (c == s);
        }
    }



}

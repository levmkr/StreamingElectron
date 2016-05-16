namespace Data.Util
{
    public static class ParticipantHelper
    {

        public static string RandomReadableString(int length)
        {
            return "23456789ABCDEFGHJKMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz".RandomString(length);
        }

        public static string RandomString(this string characterSet, int length)
        {
            var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            var random = new byte[length];
            rng.GetBytes(random);

            var buffer = new char[length];
            var usableChars = characterSet.ToCharArray();
            var usableLength = usableChars.Length;

            for (int index = 0; index < length; index++)
            {
                buffer[index] = usableChars[random[index] % usableLength];
            }

            return new string(buffer);
        }
    }
}

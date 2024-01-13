namespace BusManager.Core.Helpers
{
    public class CodeGenerator
    {
        private static readonly Random random = new();
        public static string Generate(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

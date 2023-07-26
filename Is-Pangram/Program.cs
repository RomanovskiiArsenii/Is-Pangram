class Program
{
    /// <summary>
    /// Given a string, detects whether or not it is a pangram
    /// </summary>
    /// <param name="str">input string</param>
    /// <returns>true if the string is the pangram</returns>
    public static bool IsPangram(string str)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";         //все буквы латиницы
        string lower = str.ToLower();                           //приведение к нижнему регистру
        return alphabet.All(c => lower.Contains(c));            //проверяет содержит ли строка все буквы латиницы
    }
    static void Main()
    {
        Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
        Console.WriteLine(IsPangram("test"));
    }
}
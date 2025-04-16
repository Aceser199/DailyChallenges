namespace DailyChallenges
{
    public class ChallengeDay1
    {
        public string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string (chars);
        }
    }
}

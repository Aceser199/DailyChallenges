namespace DailyChallenges
{
    public class ChallengeDay1
    {
        public string ReverseString(string input)
        {
            return string.Join("", input.ToCharArray().Reverse());
        }
    }
}

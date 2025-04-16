namespace DailyChallenges
{
    public class ChallengeDay1
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] reverse = input.ToCharArray();
            for (int i = 0; i < reverse.Length / 2; i++)
            {
                char temp = reverse[i];
                reverse[i] = reverse[reverse.Length - 1 - i];
                reverse[reverse.Length - 1 - i] = temp;

                //reverse[i] = input[input.Length - 1 - i];
            }

            return new string(reverse);
        }

        //public string ReverseString(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return input;
        //    }
        //    char[] reverse = input.ToCharArray();
        //    Array.Reverse(reverse);
        //    return new string(reverse);
        //} // O(n)

        //public string ReverseString(string input)
        //{
        //    return string.Create(input.Length, input, (chars, state) =>
        //    {
        //        state.AsSpan().CopyTo(chars);
        //        chars.Reverse();
        //    });
        //} // O(n)
    }
}

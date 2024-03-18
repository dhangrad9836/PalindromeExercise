namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //create empty variable to reverse the input string
            var reversedWord = "";

            //take input string word and loop backwards
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            //now check if word and reversedWord are equal and return true else return false
            if (word == reversedWord)
            {
                return true;
            }
            return false;
        }
    }
}

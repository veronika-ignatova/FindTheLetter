char[] divider = { ' ', '\t', '\n', '\r', '.', ',', '-', '"' };

List<char> firstLetters = new List<char> ();

string textFile = "text.txt";
string text = File.ReadAllText(textFile);

string[] words = text.Split(divider, StringSplitOptions.RemoveEmptyEntries);

 char FirstUniqueLetter(string word)
{
    Dictionary<char, int> numberOfLetters = new Dictionary<char, int>();

    foreach (char letter in word)
    {
        if (numberOfLetters.ContainsKey(letter))
        {
            numberOfLetters[letter]++;
        }
        else
        {
            numberOfLetters[letter] = 1;
        }
    }

    foreach (char letter in word)
    {
        if (numberOfLetters[letter] == 1)
        {
            return letter;
        }
    }

    return word[word.Length];
}

for (int i = 0; i < words.Length; i++)
{
    firstLetters.Add(FirstUniqueLetter(words[i]));
}

Console.WriteLine("This is your text: " + text);

char result = FirstUniqueLetter(string.Join("", firstLetters));
Console.WriteLine("This is your letter: " + result);


//Console.WriteLine("{0}", string.Join(", ", firstLetters));
//Console.WriteLine("The searched letter is: " + "{0}", string.Join(", ", words));
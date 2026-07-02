// Programmer: Jeremy Frank
// Date: July 1, 2026
// Lab 7 - Pig Latin 


Console.WriteLine("Let's manipulate your phrase!");
Console.WriteLine("This program will turn your message into Pig Latin and then encrypt it.");
Console.WriteLine();

// Ask the user for a message.
Console.Write("Please enter the message: ");
string message = Console.ReadLine() ?? "";

// Split the message into separate words.
string[] words = message.Split(' ');
// Store the finished Pig Latin phrase.
string pigLatinPhrase = "";

// These are the vowels we will check for.
string vowels = "aeiouAEIOU";

// Go through each word in the array.
for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
{
    string word = words[wordIndex];

    // Make sure the word is not empty.
    if (word.Length > 0)
    {
        // Store the Pig Latin version of the current word.
        string pigLatinWord = "";

        // Check if the first letter is a vowel.
        if (vowels.Contains(word[0]))
        {
            pigLatinWord = word + "way";
        }
        else
        {
            // Find where the first vowel is located.
            int firstVowelIndex = 0;

            while (firstVowelIndex < word.Length && !vowels.Contains(word[firstVowelIndex]))
            {
                firstVowelIndex++;
            }

            // Move the beginning consonants to the end and add "ay".
            string beginningConsonants = word.Substring(0, firstVowelIndex);
            string restOfWord = word.Substring(firstVowelIndex);

            pigLatinWord = restOfWord + beginningConsonants + "ay";
        }

        // Add the Pig Latin word to the full phrase.
        pigLatinPhrase = pigLatinPhrase + pigLatinWord + " ";
    }
}

// Display the Pig Latin phrase.
Console.WriteLine("In Pig Latin that's: " + pigLatinPhrase);

// Create a random number generator.
Random rand = new Random();

// Pick a random shift amount between 1 and 25.
int randomOffset = rand.Next(1, 26);
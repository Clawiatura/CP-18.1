string[] forbiddenWord = { "Чебурек", "Шаурма", "Бургер" };
string sentence = "";
while (true)
{
    Console.WriteLine("Введите слово: (Для выхода введите: выход.)");
    string word = Console.ReadLine();
    for (int i = 0;  i < forbiddenWord.Length; i++)
    {
        if (forbiddenWord[i] == word)
        {
            word = "()";
        }
    }
    if (word == "выход")
    {
        break;
    }
    sentence += word + " ";

}
Console.WriteLine(sentence);
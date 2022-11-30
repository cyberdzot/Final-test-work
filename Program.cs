
string[] GetStringSizeLessThan4(string[] array)
{
    int count = 0;
    int len = array.Length;

    for (int i = 0; i < len; i++)
        if (array[i].Length < 4) count++;

    string[] newArray = new string[count];
    count = 0;

    for (int i = 0; i < len; i++)
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            count++;
        }

    return newArray;
}

void ShowArrayString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


string[] setString = new string[] { "hello", "2333", "world", ":-)3" };

ShowArrayString(setString);
string[] arrayResult = GetStringSizeLessThan4(setString);
ShowArrayString(arrayResult);
// Write a method to replace all spaces in a string with '%20'
// Input: "Mr John Smith      ", 13
using System;

class Solution
{
    public static void Main(string[] args)
    {
        string inputString = @"Mr John Smith      ";
        int trueLength = 13;

        // Call URLify method return string
        var result = URLify(inputString, trueLength);

        Console.WriteLine(result);
    }
    static string URLify(string inputString, int trueLength)
    {
        string result = "";
        int spaceCount = 0;

        //string to charArray
        var inputCharArry = inputString.ToCharArray();

        // Get true length
        for (int i = 0; i < trueLength; i++)
        {
            if (inputString[i] == ' ')
            {
                spaceCount++;
            }
        }

        // Replace spaces in true count string
        var index = trueLength + spaceCount * 2;
        if (trueLength < inputString.Length)
        {
            inputCharArry[trueLength] = '\0';
        }

        for (int i = trueLength -1; i >= 0; i--)
        {
            if (inputCharArry[i] == ' ')
            {
                inputCharArry[index - 1] = '0';
                inputCharArry[index - 2] = '2';
                inputCharArry[index - 3] = '%';
                index -= 3;
            }
            else
            {
                inputCharArry[index - 1] = inputCharArry[i];
                index--;
            }
        }

        result = new string(inputCharArry);

        return result;
    }
}
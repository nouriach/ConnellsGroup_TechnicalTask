﻿using NathanOuriach.ConnellsGroup;

List<int> submittedValues = new List<int>();

DisplayAppIntroText();
RunApp(submittedValues);
DisplaySubmittedValuesText();
int totalAverage = CalculateTotalAverage(submittedValues);
DisplayTotalAverageText(totalAverage);

static void RunApp(List<int> submittedValues)
{
    string line;
    while (!HelperClass.HasUserEnteredSubmit(out line))
    {
        Console.WriteLine($"---> User has entered {line}. To submit values enter {BusinessRules.SubmitValue}");
        int submittedValue;
        var isInt = int.TryParse(line, out submittedValue);
        if (isInt && HelperClass.IsValidValue(submittedValue))
        {
            submittedValues.Add(submittedValue);
        }
        else
        {
            Console.WriteLine($"---> {line} is an incorrect value. Please enter values between {BusinessRules.MinimumValue} - {BusinessRules.MaximumValue}");
        }
    }
}

static void DisplayAppIntroText()
{
    Console.WriteLine($"----> Please enter values between {BusinessRules.MinimumValue} - {BusinessRules.MaximumValue}");
    Console.WriteLine("----> To submit your values, enter 's' in the console");
}

static void DisplaySubmittedValuesText()
{
    Console.WriteLine("----> User has submitted their values");
    Console.WriteLine("----> Submitted values can be found below");
}

static int CalculateTotalAverage(List<int> submittedValues)
{
    int average = 0; 
    foreach (var value in submittedValues)
    {
        Console.WriteLine(value);
        average += value;
    }

    Console.WriteLine($"---> Total numbers submitted: {submittedValues.Count}");
    average /= submittedValues.Count;
    return average;
}

static void DisplayTotalAverageText(int totalAverage)
{
    Console.WriteLine($"----> Total Average: {totalAverage}");
}
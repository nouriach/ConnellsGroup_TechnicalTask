List<int> submittedValues = new List<int>();
string line;

Console.WriteLine("----> Please enter values between 4 - 9");
Console.WriteLine("----> To submit your values, enter 's' in the console");


while ((line = Console.ReadLine()) != "s")
{
    Console.WriteLine("User has entered {0}", line);
    if (int.Parse(line) >= 4 && int.Parse(line) <= 9)
    {
        submittedValues.Add(int.Parse(line));
    }
    else
    {
        Console.WriteLine("---> {0} is an incorrect value. Please enter values between 4 - 9", line);
    }
}

Console.WriteLine("----> User has submitted their values");
Console.WriteLine("----> Submitted values can be found below");
int totalAverage = 0;
foreach (var value in submittedValues)
{
    Console.WriteLine(value);
    totalAverage = totalAverage + value;
}

Console.WriteLine("---> Total numbers submitted: {0}", submittedValues.Count);
totalAverage = totalAverage / submittedValues.Count;

Console.WriteLine("----> Calculating average...");
Console.WriteLine("----> Total Average: {0}", totalAverage, 0);
## Brief :briefcase:

This application should allow a set of numbers to be entered by the user which should be between 4 and 9.  
The application should then calculate the average of the numbers entered by the user and the display the 
average value on the screen window before the user closes the window.

## Approach :construction:

The application takes the form of a simple Console App. As encouraged, only 90minutes was spent on this task
and I will cover below any improvements I would make if given more time.

By reviewing the commit history you can see that the app evolved through 3 iterations

### Iteration #1

The purpose Iteration 1 was to simply satisfy the core requirements of the task:

- Allow user to submit values :white_check_mark:
- If value is between 4 - 9, then store the values :white_check_mark:
- Allow use to submit values by entering 's' :white_check_mark:
- Replay all submitted values in the Console :white_check_mark:
- Display average of all values in the Console :white_check_mark:

### Iteration #2

In the second Iteration my aim was to make the code more readable. I also wanted to isolate certain tasks to be in their 
own method and take charge of a single responsibility.

A way to make it more readable was to abstract away some logic into a new static method with a clear method name.

Also, `int.TryParse()` was brought in to better handle any erroneous submissions from the user. Previously, an exception would
have been thrown if an incorrect character was submitted.

- Break out logic into isolated methods :white_check_mark:
- Introduce HelperClass tol hold methods to make code more readable :white_check_mark:
- Introduce some more error handling :white_check_mark:

### Iteration #3

The final iteration sought to remove any magic values into a new class. Moving forward, if the Business Rules changed and the
Min/Max value need to be different, then the change will only need to take place in a single file.

- Create BusinessRules static to hold 'magic' ints and string values  :white_check_mark:
- Ensure ToLower is called incase use enters capital 'S' HasUserEnteredSubmit() :white_check_mark:
- Compound the math formula to reduce code  :white_check_mark:

## Future Improvements :mag:

- All text that appears in the multiple `Console.WriteLine()` entries will be stored in a config. 
- Create a single file that manages all calls that display text rather than having the methods in `Program.cs` and sitting
alongside other methods which it doesn't need to know about.
- Create a single class to Calculate the final, total average which takes `submittedValues` in its constructor
- At the moment `RunApp()` is: checking if the user has enter `s`; checking if the value is an `int`; checking if it is between 
4 - 9 and adding it to the `submittedValues` list. Moving forward this `RunApp()` method will need to be refactored to reduce
its responsibility

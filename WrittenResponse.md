# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

To provide people with inspirational quotes.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can generate a list of inspirational quotes.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program receives a numeric input from the user and then outputs a list containing that many quotes.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> quotes = File.ReadAllLines(filename).ToList();
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
Random generator = new Random();
int index = generator.Next(0, quotes.Count);
return quotes[index];
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "quotes"

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all of the possible quotes that can be generated.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, I would not be able to select a quote by generating a random index. Instead, I would need to write several (400) if / else if statements. This would be unmanagable.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void GetQuotes(int numQuotes)
{
    if (numQuotes < 1)
    {
        throw new ArgumentException("The number of quotes to generate must be at least 1.");
    }

    while (numQuotes > 0)
    {
        string quote = LoadQuote("quotes.txt");
        Console.WriteLine($"{numQuotes}. {quote}");
        numQuotes = numQuotes - 1;
    }
}
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
int numQuotes = int.Parse(userInput);
GetQuotes(numQuotes);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a positive number of quotes to generate, displays a list of quotes. This is the main function of my program.


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Verify that the number of quotes to generate is positive.
2. If it not positive, throw an exception 
3. If we have no quotes left to generate, we are finished, exit the method
4. If there are more quotes to generate:
4 a. Generate a random quote
4 b. Display the random quote
4 c. Decrement the number of quotes left to generate
4 d. Go to step 3

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

GetQuotes(-1);

Second call:

GetQuotes(3);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
I am testing if the number of quotes to generate is less than 1. This will cause the body of the if statement to execute.

Condition(s) tested by the second call:

I am testing if the number of quotes to generate is at least 1. This will skip the body of the if statement.

### 3d iii.

Result of the first call:

The result of calling with a number less than 1 results in an exception being thrown.

Result of the second call:

The result of calling with a number that is at least 1 is to display that many inspirational quotes.
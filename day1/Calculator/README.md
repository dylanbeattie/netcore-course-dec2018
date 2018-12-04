# Exercise: Build a Command Line Calculator

## Specification

Create a .NET Core console application that takes input from the command line and does simple arithmetic calculations.

```
dotnet run 
Please enter a command
multipy 5 8
40

add 3 2
5

subtract 8 3
5

divide 10 3
3.3333333

exit
```

### Suggestions

* Try creating an interface `ICalculateThings`, which exposes a `Calculate` method that takes two parameters.
* Create implementations of your `ICalculateThings` interface for addition, subtraction, etc.
* Use `Console.ReadLine()` to read input from the console, and `String.Split` to break it into tokens
* Use the `switch` statement to decide what kind of calculator to create for this command.
* You will find `Int32.Parse` and `Double.Parse` useful for turning command-line input into numeric variables
* Think about what happens if the user asks you to divide by zero

### Bonus

* Could you extend your calculator to handle compound expressions?

```
add 8 multiply 2 5
80
```



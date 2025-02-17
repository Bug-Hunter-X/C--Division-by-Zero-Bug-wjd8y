# C# Division by Zero Bug

This repository demonstrates a common error in C#: division by zero.  The `Calculate` method in `bug.cs` lacks error handling for the scenario where the denominator is zero, resulting in a `DivideByZeroException`.

The solution, provided in `bugSolution.cs`, addresses this by adding a check to prevent the division by zero.

This example highlights the importance of robust error handling in C# applications.
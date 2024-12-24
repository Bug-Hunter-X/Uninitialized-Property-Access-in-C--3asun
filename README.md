# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been initialized.  This can lead to unexpected behavior, such as accessing a default value (0 for integers, null for references) when a different value was expected, or even runtime exceptions depending on the property type and how it's accessed. The example shows a simple class with a property that might be accessed before being set.

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.cs` file.  You'll likely see unexpected behavior depending on your C# version.
3. Examine the `bugSolution.cs` for a corrected version that demonstrates best practices.

## Solution

Always initialize properties before using them.  Consider using constructors to set initial values or explicitly assign values before accessing them in your methods.
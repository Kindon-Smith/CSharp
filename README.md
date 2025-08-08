# CSharp

Solutions and exercises in C#/.NET 9

Projects
- HelloWorld (console app)
- HelloWorld.Tests (xUnit)

Build and test
```bash
dotnet restore
dotnet build
dotnet test HelloWorld.sln
```

Highlights
- OOP examples (inheritance, interfaces, factory)
- Algorithms (strings, arrays, hash maps)

Next
- Split libraries into class libraries under src/, add CI, improve test coverage.

# CSharp Algorithms & Interview Prep

This repository contains clean, well-documented C# solutions to classic algorithm and data structure problems.  
It’s designed for interview preparation and practical C# learning.

## Features

- Modular algorithm implementations (arrays, strings, hash tables, etc.)
- XML documentation and robust error handling
- Easy to run and extend

## How to Run

1. **Clone the repository:**
   ```sh
   git clone https://github.com/Kindon-Smith/CSharp.git
   cd CSharp/HelloWorld
   ```

2. **Open the project in Visual Studio or VS Code.**

3. **Run the main entry point:**
   - Open `Program.cs` (or `Exercise4.cs` for direct algorithm demos).
   - Press `F5` (Visual Studio) or run:
     ```sh
     dotnet run
     ```
   - Output will display results for each algorithm.

## Example Usage

```csharp
using HelloWorld.E4Lib;

int max = FindMax.Execute(new int[] { 1, 2, 3 });
string reversed = ReverseString.Execute("hello");
int vowels = CountVowels.Execute("interview");
```

## Algorithms Included

- Reverse String
- Find Max in Array
- Count Vowels
- First Non-Repeating Character
- Anagram Check
- Length of Longest Substring Without Repeats
- Remove Duplicates from Sorted Array
- Length of Longest Palindromic Substring
- Group Anagrams

## Contributing

Pull requests and suggestions welcome!

## License

MIT

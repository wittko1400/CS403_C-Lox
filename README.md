# CS403_C-Lox
This Lox interpreter is a C# implementation based on the book [*Crafting Interpreters* by Robert Nystrom](https://craftinginterpreters.com/). 

## Development
Development snapshots after certain chapters are included in the repo to help show the design process and growth of the interpreter as I progressed. (I recommend deleting the chapter snapshots after pulling the github, unless you want to play with a specific development point I was at.)

## Install/Build
Start with installing the [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download), then add it into your system enivronment path variables

It can be added to environment path variables by searching system environment variables in the search bar and then selecting Environment Path and editing the path.

Next install an C# IDE such as [Visual Studio](https://visualstudio.microsoft.com/).

Finally clone the Lox Interpreter repo into where you stored the repos folder of Visual Studio
```
git clone https://github.com/wittko1400/CS403_C-Lox
```
## Usage
Once inside Visual Studio open the solution file Lox_Interpreter, then build and clean

Next Run the Lox_Interpreter.
When run without an argument it operates as a <abbr title="read-eval-print loop">REPL</abbr> prompt which runs until it encounters an exit code. Otherwise, when given a Lox source file it will attempt to execute it and then exit.

## Testing
Tests were taken from Robert Nystroms Tetsing repo to test his lox interpreter.
242/242 Tests were successful proving completion and accuracy of the Lox Interpreter.
Test output can be checked against the test file included in the repo to verify accuracy.

[Test Output](testoutput.md)

# ChatGPT
For this assignment's preparation, the author(s) have utilized ChatGPT, a language model created by OpenAI. 
Within this assignment, the ChatGPT was used for purposes such as brainstorming, grammatical correction, writing paraphrasing, and learning.

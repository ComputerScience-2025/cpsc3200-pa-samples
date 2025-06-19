# CPSC 3200 Programming Assignments Setup

Examples of properly setted up projects for PAs. Though we recommend you to use the *New Projects* functionalities in the IDE to use the latest version of dependencies, this should offer you some ideas to check whether you configured them properly or not, as well as example of properly name these files.
Also the graders will use the same way to create IDE projects on their end and run your code, so this is a good opportunity to ensure your code can be run without issues.

## Important Tips

### C#
You need to create a separate projects for the unit testing files, somehow C# only allow one entrypoint (AKA `Main()`) in a project and the unit testing framework will implicitly add an main method, not doing so will cause *multiple entrypoint error* and won't let you compile the code. Don't forget to add the project of your main codes placed to the dependency of the unit testing project.
But other than that you shouldn't create more than 2 projects for the same PA, each unit testing project can contain as many files as you need it.

### C++
All of the `.cpp` files should be added to `CMakeList.txt` so the compiler can include them for compilation.

## Steps
#### Dotnet CLI

```shell
# To Create the new c# console project using net5.0 framework
> dotnet new console --framework net5.0

# To Run the project
> dotnet run
```

#### File Structure

```
# To generate path file use command:
> tree /f /a

root/
|   .gitignore
|   POC-Interfaces.csproj
|   Program.cs
|   Readme.md
|   tree.doc
|   
+---Interfaces/
|       IDisplay.cs
|       
+---Classes/
|       Book.cs
|       Film.cs
```

#### Output

```text
======= Here is the object's data: ======
Title: War and Peace
Author: Leo Tolstoy
Number of Pages: 1392

======= Here is the object's data: ======
Title: Pulp Fiction
Director: Quentin Tarantino
Release Year: 1994
Runtime (in minutes): 178
```
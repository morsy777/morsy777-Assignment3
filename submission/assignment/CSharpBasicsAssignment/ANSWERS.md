# C# Basics Assignment

## Part G — Project File

### 1. `.csproj` Contents

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

### Four Required Properties 
- `OutputType`: Type: is Exe that's mean the output of the project will be an executable file
- `TargetFramework`: is net9.0 that's mean the project will be compiled using .NET 9.0 framework
- `ImplicitUsings`: is enable that's mean the project will automatically include common namespaces without needing to add `using` statement.
- `Nullable`: is enable that's mean the project will enable nullable reference types, and alert me if I try to assign null to a non-nullable reference type.


---

### 2. `#region` / `#endregion`

**Question:**  
Do `#region` / `#endregion` change the compiled output? Why might you still use them?

**Answer:**  
No, region is used to organize the code into section to be readble.


---

### 3. XML Documentation Comments

**Question:**  
When would you use `///` XML doc comments instead of a plain `//` comment?

**Answer:**  
If I write NuGet package or function that may throw an exception in special case.


---

### 4. Global Variables

**Question:**  
Why does C# have no true global variables, and what's the closest equivalent?

**Answer:**  
C# doesn't have global variable but we can use static variable in a static class to achieve the same effect.





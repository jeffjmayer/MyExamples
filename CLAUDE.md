# CLAUDE.md - AI Assistant Guide for MyExamples Repository

## Repository Overview

**MyExamples** is an educational C# .NET Framework repository containing **8 standalone example projects** that demonstrate fundamental C# language features, design patterns, and programming concepts. This repository serves as a learning resource and reference implementation for various .NET development patterns.

**Repository Type:** Educational/Tutorial Examples
**Language:** C# (100%)
**Framework:** .NET Framework 4.0 and 4.5 (Legacy Desktop)
**Total Projects:** 9 (7 Console Apps, 1 Windows Forms App, 1 Shared Library)
**External Dependencies:** None (uses only .NET Framework built-in libraries)

---

## Directory Structure

```
MyExamples/
├── .git/                                      # Git repository
├── .gitignore                                 # Standard Visual Studio gitignore
│
├── Async-Await/                               # Async callback patterns (pre-async/await)
│   ├── Async-Await.csproj                     # .NET 4.0 Console App
│   ├── Async-Await.sln
│   └── Program.cs                             # HttpWebRequest with callbacks
│
├── LinqFileSystem/                            # LINQ queries on file system
│   ├── LinqFileSystem.csproj                  # .NET 4.0 Console App
│   ├── LinqFileSystem.sln
│   └── Program.cs                             # File enumeration, grouping, custom comparers
│
├── LinqMerge/                                 # LINQ merge operations with generics
│   ├── LinqMerge.csproj                       # .NET 4.0 Console App
│   ├── LinqMerge.sln
│   └── Program.cs                             # Generic merge with yield return
│
├── StreamingAndIterators/                     # Iterator pattern and deferred execution
│   ├── StreamingAndIterators.csproj           # .NET 4.0 Console App
│   ├── StreamingAndIterators.sln
│   ├── StreamingAndIterators.cs               # File streaming with yield return
│   ├── Products.cs                            # Product model
│   ├── Products.txt                           # Sample CSV data (3 products)
│   └── ProductsFixedLength.txt                # Alternative format template
│
├── Polymorphism/                              # Basic polymorphism example
│   ├── Polymorphism.csproj                    # .NET 4.5 Console App
│   ├── Polymorphism.sln
│   └── Program.cs                             # ThumbnailerBase with 3 implementations
│
├── Polymorphism - refactored to real world/   # Advanced polymorphism with shared library
│   ├── Polymorphism.csproj                    # .NET 4.5 Console App
│   ├── Polymorphism.sln
│   ├── Program.cs                             # Uses ThumbnailLib factory
│   │
│   └── FormsApplication/                      # Windows Forms GUI example
│       ├── FormsApplication.csproj            # .NET 4.5 Windows Forms App
│       ├── Form1.cs                           # GUI with dropdown and button
│       ├── Form1.Designer.cs                  # Auto-generated designer code
│       └── Form1.resx                         # Form resources
│
├── ThumbnailLib/                              # Shared reusable library
│   ├── ThumbnailLib.csproj                    # .NET 4.5 Class Library (.DLL)
│   ├── ThumbnailLib.sln
│   ├── ThumbnailerBase.cs                     # Abstract base class
│   ├── ThumbnailerFactory.cs                  # Factory pattern implementation
│   ├── ThumbnailerAudio.cs                    # Audio thumbnail generator
│   ├── ThumbnailerImage.cs                    # Image thumbnail generator
│   ├── ThumbnailerVideo.cs                    # Video thumbnail generator
│   └── MediaInfo.cs                           # Data structure
│
└── TemplateMethodPattern/                     # Template Method design pattern
    ├── TemplateMethodPattern.sln
    │
    ├── TemplateMethodLib/                     # Class library with pattern implementation
    │   ├── TemplateMethodLib.csproj           # .NET 4.0 Class Library
    │   ├── MediaThumbnailerBase.cs            # Abstract template with 4 steps
    │   ├── MediaThumbnailerFactory.cs         # Factory for creating thumbnailers
    │   ├── MediaThumbnailerImage.cs           # Concrete image implementation
    │   ├── MediaThumbnailerVideo.cs           # Concrete video implementation
    │   ├── MediaThumbnailerAudio.cs           # Concrete audio implementation
    │   ├── MediaInfo.cs                       # Media information structure
    │   ├── MediaMetadata.cs                   # Metadata structure
    │   └── MediaType.cs                       # Media type enumeration
    │
    └── TemplateMethodConsoleApplication/      # Console app demonstrating pattern
        ├── TemplateMethodConsoleApplication.csproj  # .NET 4.0 Console App
        └── Program.cs                         # Usage example
```

---

## Project Categories and Learning Objectives

### 1. Design Patterns

#### **Factory Pattern**
- **Projects:** ThumbnailLib, TemplateMethodPattern
- **Files:** `ThumbnailerFactory.cs`, `MediaThumbnailerFactory.cs`
- **Key Concept:** Creating objects without specifying their exact classes
- **Pattern:** Static factory method that returns appropriate concrete implementation based on MIME type

#### **Template Method Pattern**
- **Project:** TemplateMethodPattern
- **File:** `MediaThumbnailerBase.cs:8-16`
- **Key Concept:** Defines skeleton of algorithm with 4 steps:
  1. `ValidateMediaInfo()` - Private validation (line 26)
  2. `EnsureMimTypeIsSupported()` - Virtual validation (line 21)
  3. `ExtractMetadata()` - Abstract method (line 19)
  4. `ExtractThumbnail()` - Abstract method (line 18)
- **Pattern:** Base class controls flow, subclasses implement specific steps

#### **Polymorphism & Inheritance**
- **Projects:** All Polymorphism projects, ThumbnailLib
- **Key Files:** `ThumbnailerBase.cs`, `MediaThumbnailerBase.cs`
- **Key Concept:** Abstract base classes with multiple concrete implementations
- **Implementations:** Audio, Image, Video thumbnailers in each project

### 2. LINQ and Collections

#### **LINQ Queries**
- **Project:** LinqFileSystem
- **File:** `Program.cs`
- **Demonstrates:**
  - File system enumeration with `Directory.EnumerateFiles()`
  - Group-by operations with custom `IEqualityComparer`
  - Case-insensitive file extension grouping
  - Filtering and counting operations

#### **LINQ Merge Operations**
- **Project:** LinqMerge
- **File:** `Program.cs`
- **Demonstrates:**
  - Generic methods with `Func<T,T,TResult>` delegates
  - Iterator pattern with `yield return`
  - Combining sequences with custom logic
  - Example: Merging first names and last names with formatting options

### 3. Async Programming

#### **Legacy Async Patterns (Pre-async/await)**
- **Project:** Async-Await
- **File:** `Program.cs`
- **Demonstrates:**
  - `BeginGetRequestStream()` / `EndGetRequestStream()` pattern
  - `AsyncCallback` delegates
  - `ManualResetEvent` for synchronization
  - Callback-based HTTP requests with `HttpWebRequest`
- **Note:** This shows the OLD async pattern (circa .NET 4.0) before `async`/`await` keywords

### 4. Iterators and Streaming

#### **Iterator Pattern**
- **Projects:** LinqMerge, StreamingAndIterators
- **Demonstrates:**
  - `IEnumerable<T>` with `yield return`
  - Deferred execution / lazy evaluation
  - File streaming (line-by-line reading without loading entire file)
  - CSV parsing with lambda expressions

#### **File I/O**
- **Project:** StreamingAndIterators
- **Files:** `StreamingAndIterators.cs`, `Products.txt`
- **Demonstrates:**
  - Reading large files efficiently
  - Parsing CSV data
  - Using lambda functions for transformation

### 5. GUI Development

#### **Windows Forms**
- **Project:** Polymorphism - refactored to real world/FormsApplication
- **Files:** `Form1.cs`, `Form1.Designer.cs`, `Form1.resx`
- **Demonstrates:**
  - Windows Forms event handling
  - ComboBox for media type selection
  - Button click events
  - Integrating with shared library (ThumbnailLib)

---

## Key Technologies and Patterns

| Technology/Pattern | Projects | Description |
|-------------------|----------|-------------|
| **Abstract Classes** | All Polymorphism, ThumbnailLib, TemplateMethodPattern | Base classes with virtual/abstract methods |
| **Generics** | LinqMerge, ThumbnailLib | Type-safe generic classes and methods `<T>` |
| **Delegates & Lambdas** | LinqMerge, LinqFileSystem, StreamingAndIterators | `Func<>`, `Action<>`, lambda expressions |
| **LINQ** | LinqFileSystem, LinqMerge, StreamingAndIterators | Query syntax, method syntax, custom operators |
| **Iterator Pattern** | LinqMerge, StreamingAndIterators | `yield return`, deferred execution |
| **Factory Pattern** | ThumbnailLib, TemplateMethodPattern | Object creation abstraction |
| **Template Method** | TemplateMethodPattern | Algorithm skeleton in base class |
| **Callback Pattern** | Async-Await | Legacy async with `BeginXxx/EndXxx` |
| **System.Drawing** | ThumbnailLib, TemplateMethodPattern | Image generation with `Graphics`, `Bitmap` |
| **Windows Forms** | FormsApplication | Desktop GUI development |

---

## Development Workflows

### Building Projects

**All projects use MSBuild** (Visual Studio's standard build system).

#### Option 1: Visual Studio IDE
1. Open any `.sln` file in Visual Studio (2010 or later)
2. Select Debug or Release configuration
3. Press F5 to build and run, or Ctrl+Shift+B to build only

#### Option 2: Command Line (MSBuild)
```bash
# Build a specific solution
msbuild "Async-Await/Async-Await.sln" /p:Configuration=Release

# Build a specific project
msbuild "ThumbnailLib/ThumbnailLib.csproj" /p:Configuration=Debug

# Clean and rebuild
msbuild "TemplateMethodPattern/TemplateMethodPattern.sln" /t:Clean,Build
```

#### Option 3: Command Line (dotnet CLI - if available)
```bash
# Note: .NET Framework projects may need dotnet CLI with Windows SDK
dotnet build "Polymorphism/Polymorphism.sln"
```

### Running Projects

#### Console Applications (7 projects)
After building, executables are in `bin/Debug/` or `bin/Release/`:
```bash
# Run console apps directly
./Async-Await/bin/Debug/Async-Await.exe
./LinqFileSystem/bin/Debug/LinqFileSystem.exe
./StreamingAndIterators/bin/Debug/StreamingAndIterators.exe
```

#### Windows Forms Application
```bash
# Run the GUI app
./"Polymorphism - refactored to real world"/FormsApplication/bin/Debug/FormsApplication.exe
```

#### Library Projects (2 projects)
- **ThumbnailLib** and **TemplateMethodLib** are class libraries (DLLs)
- Cannot run directly; referenced by other projects
- Build produces `.dll` files in `bin/` directories

### Project Dependencies

**Internal Project References:**
- `FormsApplication` → depends on → `ThumbnailLib`
- `Polymorphism (refactored)` console → depends on → `ThumbnailLib`
- `TemplateMethodConsoleApplication` → depends on → `TemplateMethodLib`

**Build Order:** Build library projects first, then dependent projects:
```bash
# Build libraries first
msbuild "ThumbnailLib/ThumbnailLib.csproj"
msbuild "TemplateMethodPattern/TemplateMethodLib/TemplateMethodLib.csproj"

# Then build dependent projects
msbuild "Polymorphism - refactored to real world/Polymorphism.sln"
```

---

## Git Workflow

### Current Branch
**Active Branch:** `claude/claude-md-mj1uithzetx3r78k-01VscvH19N98cpktoVeqXL6Z`

This is a Claude Code development branch. All development and commits should be made here.

### Git History Context
The repository has 5 commits:
1. `7ee1dac` - "added solutions and ran all projects to make sure they worked" (Latest)
2. `70a5d84` - "git ignore file reduction"
3. `94baa4f` - "removed files"
4. `f12fccf` - "added gitignore"
5. `d98706a` - "First Commit"

### Gitignore Configuration
Uses standard Visual Studio `.gitignore` from GitHub's gitignore repository.

**Ignored items:**
- Build artifacts: `bin/`, `obj/`, `.vs/`
- User-specific files: `*.suo`, `*.user`, `*.userprefs`
- Compiled outputs: `*.dll`, `*.exe`, `*.pdb` (in build directories)
- NuGet packages: `packages/`, `*.nupkg`
- Test results: `TestResult.xml`, `*.coverage`
- IDE settings: `.vs/` folder

**Committed items:**
- All source code (`.cs` files)
- Project files (`.csproj`, `.sln`)
- Configuration files (`App.config`)
- Assembly metadata (`Properties/AssemblyInfo.cs`)
- Data files (`Products.txt`)
- Windows Forms resources (`.resx`, `.Designer.cs`)

### Making Changes
1. Make changes on the current branch
2. Test by building and running affected projects
3. Commit with descriptive messages
4. Push to the branch: `git push -u origin <branch-name>`

---

## Key Conventions for AI Assistants

### Code Style and Patterns

1. **Namespace Conventions**
   - Each project has its own namespace (e.g., `ThumbnailLib`, `TemplateMethodLib`)
   - Namespaces match assembly names
   - No nested namespaces in these simple examples

2. **Class Naming**
   - Abstract base classes: `*Base` suffix (e.g., `ThumbnailerBase`, `MediaThumbnailerBase`)
   - Factory classes: `*Factory` suffix (e.g., `ThumbnailerFactory`)
   - Concrete implementations: Descriptive names (e.g., `ThumbnailerImage`, `MediaThumbnailerVideo`)

3. **Method Naming**
   - Public methods: PascalCase (e.g., `CreateThumbnailer`, `GenerateThumbnail`)
   - Abstract methods: Descriptive verbs (e.g., `ExtractMetadata`, `ExtractThumbnail`)
   - Protected methods: Often with "Ensure" prefix for validation (e.g., `EnsureMimTypeIsSupported`)

4. **File Organization**
   - One class per file (standard C# convention followed)
   - File name matches class name exactly
   - `Properties/AssemblyInfo.cs` in each project for assembly metadata

5. **Design Pattern Implementation**
   - **Factory Pattern:** Static class with static method returning base class type
   - **Template Method:** Public non-virtual method orchestrates protected/abstract methods
   - **Polymorphism:** Abstract base class with `abstract` methods that must be overridden

### Framework Specifics

1. **.NET Framework 4.0 Projects**
   - No async/await keywords (use callbacks instead)
   - LINQ fully supported
   - No modern C# features (no string interpolation, no null-coalescing assignment)

2. **.NET Framework 4.5 Projects**
   - async/await available (but not used in these examples)
   - All .NET 4.0 features plus enhancements

3. **System.Drawing Usage**
   - Used for image generation in ThumbnailLib and TemplateMethodPattern
   - Pattern: Create `Bitmap` → Get `Graphics` → Draw → Return/Dispose
   - Always dispose graphics resources properly (using statements)

### When Modifying Code

1. **Maintain Existing Patterns**
   - Don't introduce modern C# features (C# 6+ syntax) unless upgrading framework
   - Keep abstract classes abstract; don't convert to interfaces
   - Maintain factory pattern structure if adding new types

2. **Adding New Media Types**
   - Create new concrete class inheriting from base
   - Add case to factory switch statement
   - Implement all abstract methods
   - Follow naming convention: `*Image`, `*Video`, `*Audio`, etc.

3. **Build Considerations**
   - If modifying ThumbnailLib, rebuild dependent projects
   - If adding files, ensure they're included in `.csproj` (or use Visual Studio to add)
   - Test by running the actual executable, not just building

4. **Don't Over-Engineer**
   - These are **educational examples**, not production code
   - Keep implementations simple and focused on the concept being demonstrated
   - Don't add error handling, logging, or features beyond the example's scope
   - Maintain the tutorial nature of the code

### Understanding Project Purpose

Each project has a **single learning objective**:

- **Async-Await:** Shows how async worked BEFORE async/await keywords (historical)
- **LinqFileSystem:** LINQ queries on real data (file system)
- **LinqMerge:** Generic methods and iterator pattern
- **StreamingAndIterators:** Deferred execution and streaming
- **Polymorphism:** Basic OOP inheritance and polymorphism
- **Polymorphism (refactored):** Shared library usage and factory pattern
- **ThumbnailLib:** Reusable library design
- **TemplateMethodPattern:** Template Method pattern implementation
- **FormsApplication:** GUI integration with shared library

**Don't mix concepts.** If working on LinqFileSystem, don't add async patterns. If working on Polymorphism, don't add complex LINQ queries.

### Testing and Validation

**No Unit Tests:** This repository has no formal test framework (xUnit, NUnit, MSTest).

**Manual Testing:**
1. Build the project
2. Run the executable
3. Verify console output matches expected behavior
4. For FormsApplication, test GUI interactions manually

**Before Committing:**
1. Ensure all solutions build without errors
2. Run affected console applications to verify behavior
3. Check that no unintended files are being committed (check against `.gitignore`)

### Common Tasks

#### Adding a New Example Project
1. Create project using Visual Studio or MSBuild
2. Add to root directory (not nested)
3. Follow naming conventions (PascalCase directory names)
4. Create standalone `.sln` file for the project
5. Add appropriate `.gitignore` patterns if needed (usually covered by existing)
6. Update this CLAUDE.md file with project description

#### Modifying Shared Libraries (ThumbnailLib, TemplateMethodLib)
1. Make changes to library code
2. Rebuild the library project
3. Rebuild ALL dependent projects:
   - For ThumbnailLib: Rebuild Polymorphism (refactored) console + FormsApplication
   - For TemplateMethodLib: Rebuild TemplateMethodConsoleApplication
4. Test each dependent application

#### Understanding a Project
1. Read the relevant section in this CLAUDE.md first
2. Open the `.sln` file to see project structure
3. Start with `Program.cs` (entry point for console apps)
4. For patterns, read base class first, then concrete implementations
5. Look for `Main()` method to understand execution flow

---

## Reference Information

### .NET Framework Assemblies Used

**Common References (all projects):**
- `System` - Core functionality
- `System.Core` - LINQ, modern collections
- `System.Xml.Linq` - XML processing (included by default)
- `System.Data` - ADO.NET (included by default)
- `System.Data.DataSetExtensions` - DataSet LINQ support

**Specialized References:**
- `System.Drawing` - Image/graphics (ThumbnailLib, TemplateMethodPattern)
- `System.Windows.Forms` - GUI framework (FormsApplication only)
- `Microsoft.CSharp` - Dynamic C# features

### MIME Types Used

The factory patterns recognize these MIME types:
- **Audio:** `audio/mp3`
- **Image:** `image/jpeg`
- **Video:** `video/mp4`

When adding support for new media types, add MIME type to factory switch statement.

### File Extensions (LinqFileSystem Example)

The LinqFileSystem project groups video files by extension:
- `.wmv` - Windows Media Video
- `.mp4` - MPEG-4 Video
- `.flv` - Flash Video
- `.mpeg` - MPEG Video
- `.mov` - QuickTime Movie
- `.ogg` - Ogg Video

### Data Files

**Products.txt** (StreamingAndIterators project):
- Format: CSV (comma-separated values)
- Fields: ID, ITA ID, Short Description, Long Description, Cost, Is Active
- Records: 3 sample products
- Used to demonstrate: File streaming, CSV parsing, deferred execution

---

## Common AI Assistant Tasks

### 1. Explaining a Project
```
Task: "Explain how the TemplateMethodPattern works"
Approach:
1. Read TemplateMethodPattern/TemplateMethodLib/MediaThumbnailerBase.cs
2. Identify the template method (GenerateThumbnail)
3. Note the 4 steps in the algorithm
4. Explain which methods are abstract vs virtual vs private
5. Show how concrete implementations override abstract methods
6. Reference specific line numbers in your explanation
```

### 2. Adding a New Media Type
```
Task: "Add support for PDF files to ThumbnailLib"
Approach:
1. Read ThumbnailLib/ThumbnailerBase.cs to understand interface
2. Create ThumbnailLib/ThumbnailerPdf.cs inheriting from ThumbnailerBase
3. Implement required methods (CreateThumbnail, etc.)
4. Add case "application/pdf" to ThumbnailerFactory.cs:9-19
5. Rebuild ThumbnailLib project
6. Rebuild dependent projects (Polymorphism console, FormsApplication)
7. Test with console app or GUI
```

### 3. Running All Examples
```
Task: "Run all example projects to verify they work"
Approach:
1. Build each .sln file in this order:
   - ThumbnailLib.sln (library dependency)
   - TemplateMethodPattern.sln (library + app)
   - All other .sln files (independent)
2. Run each .exe file (7 console apps + 1 GUI app)
3. Verify console output is reasonable
4. Test FormsApplication GUI interactions
5. Report any build errors or runtime exceptions
```

### 4. Understanding Code Flow
```
Task: "How does the Polymorphism refactored example work?"
Approach:
1. Start with Polymorphism - refactored to real world/Program.cs
2. Find Main() method (entry point)
3. Trace through factory call: ThumbnailerFactory.CreateThumbnailer()
4. Follow to ThumbnailLib/ThumbnailerFactory.cs
5. See which concrete class is instantiated
6. Examine concrete implementation (e.g., ThumbnailerImage.cs)
7. Explain the polymorphic call chain with line number references
```

### 5. Comparing Implementations
```
Task: "What's the difference between basic Polymorphism and TemplateMethodPattern?"
Approach:
1. Read Polymorphism/Program.cs (all code in one file)
2. Read TemplateMethodPattern/TemplateMethodLib/MediaThumbnailerBase.cs
3. Key differences:
   - Polymorphism: Simple override of abstract methods
   - Template Method: Multi-step algorithm with abstract, virtual, and private methods
   - Template Method: More structure, enforces specific execution order
   - Polymorphism: More flexibility, each class implements full behavior
4. Explain with specific code examples and line numbers
```

---

## Troubleshooting

### Build Issues

**Problem:** Project won't build - "The type or namespace name could not be found"
**Solution:**
- Check if you're building a dependent project before its library
- Build order: ThumbnailLib → Polymorphism (refactored)
- Build order: TemplateMethodLib → TemplateMethodConsoleApplication

**Problem:** MSBuild not found
**Solution:**
- Install Visual Studio (Community edition is free)
- Or install Visual Studio Build Tools
- Or use Visual Studio Developer Command Prompt

**Problem:** .NET Framework 4.0/4.5 not installed
**Solution:**
- Install .NET Framework 4.5 (includes 4.0)
- Download from Microsoft's website
- Or install Visual Studio which includes required frameworks

### Runtime Issues

**Problem:** Console app closes immediately
**Solution:**
- Run from command line, not by double-clicking
- Or add `Console.ReadKey()` at end of Main() method
- Or run with debugger (F5 in Visual Studio)

**Problem:** FormsApplication doesn't show UI
**Solution:**
- Ensure System.Windows.Forms reference is present
- Check that `[STAThread]` attribute is on Main() method
- Verify `Application.Run(new Form1())` is called

**Problem:** File not found (Products.txt)
**Solution:**
- StreamingAndIterators expects Products.txt in same directory as .exe
- Copy from source directory to bin/Debug/ or bin/Release/
- Or run from Visual Studio which handles this automatically

### Understanding Issues

**Problem:** Don't understand what a project demonstrates
**Solution:**
- Read the project description in this CLAUDE.md
- Look at the "Key Technologies and Patterns" section
- Examine the Main() method to see what's being called
- Read inline comments in the code

**Problem:** Code doesn't follow modern C# best practices
**Solution:**
- This is intentional - examples are educational, not production-ready
- .NET Framework 4.0/4.5 doesn't support modern C# features
- Examples deliberately keep things simple to focus on one concept
- Don't refactor unless specifically asked

---

## Quick Reference Card

| Task | Command |
|------|---------|
| Build a solution | `msbuild "ProjectName/ProjectName.sln"` |
| Build in Release mode | `msbuild "ProjectName/ProjectName.sln" /p:Configuration=Release` |
| Clean build | `msbuild "ProjectName/ProjectName.sln" /t:Clean,Build` |
| Run console app | `./ProjectName/bin/Debug/ProjectName.exe` |
| Check git status | `git status` |
| List project files | `ls -la Polymorphism/` |
| Find all .sln files | `find . -name "*.sln"` |
| Find all Program.cs files | `find . -name "Program.cs"` |
| Check .NET version | Look at `<TargetFrameworkVersion>` in `.csproj` file |

---

## Version History

| Date | Version | Changes |
|------|---------|---------|
| 2025-12-11 | 1.0 | Initial CLAUDE.md creation - comprehensive documentation of repository structure, patterns, and conventions |

---

## Additional Notes

- **No External Documentation:** This CLAUDE.md serves as the primary documentation for AI assistants
- **Self-Contained Examples:** Each project is independent (except shared library dependencies)
- **Educational Focus:** Code prioritizes clarity and demonstrating concepts over production best practices
- **Legacy Framework:** .NET Framework 4.0/4.5 is legacy but still supported and used in many enterprises
- **No Web Projects:** All projects are desktop/console applications (no ASP.NET, no web APIs)
- **No Database:** No database connections or Entity Framework usage
- **Windows-Only:** .NET Framework is Windows-specific (not cross-platform like .NET Core/.NET 5+)

---

## For AI Assistants: Key Takeaways

1. **This is an educational repository** - prioritize clarity over optimization
2. **Each project demonstrates ONE concept** - don't mix patterns across projects
3. **Build libraries before dependent projects** - respect the dependency chain
4. **Test by running executables** - these are runnable demos, not just code to read
5. **Don't modernize the code** - keep .NET Framework 4.0/4.5 compatibility
6. **Reference line numbers** - when explaining code, cite specific lines (e.g., `Program.cs:25`)
7. **Understand the pattern first** - read base classes before concrete implementations
8. **Follow existing conventions** - maintain naming patterns and code style
9. **Keep it simple** - match the simplicity level of existing examples
10. **Update this document** - if you add new projects or make significant changes, update CLAUDE.md

---

*This document was created to help AI assistants effectively understand and work with the MyExamples repository. For questions or clarifications about this codebase, refer to the specific project sections above.*

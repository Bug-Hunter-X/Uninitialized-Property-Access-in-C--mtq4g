# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been initialized.  Uninitialized properties will have default values (0 for integers, null for reference types, etc.), which may not be what your code expects.

**bug.cs** shows the problematic code.  **bugSolution.cs** shows how to fix it by initializing the property or checking for a null value before use.

This issue can lead to unexpected program behavior and difficult-to-debug errors.  Proper initialization is crucial for robust code.
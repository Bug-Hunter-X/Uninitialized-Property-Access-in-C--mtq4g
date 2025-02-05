public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize MyProperty to 0

    public void MyMethod() {
        // Initialize MyProperty before using it.
        //or use a null check if you have a reference type
        Console.WriteLine(MyProperty);
    }
}
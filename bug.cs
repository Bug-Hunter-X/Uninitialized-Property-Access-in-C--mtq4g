public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); // Accessing MyProperty before setting it
    }
}
public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        int value = MyProperty; //potential error if MyProperty is not set before this line
    }
}
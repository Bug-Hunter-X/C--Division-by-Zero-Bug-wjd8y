public class ExampleClass
{
    public int Calculate(int a, int b)
    {
        //Check for division by zero
        if (b == 0)
        {
            //Handle the error appropriately.  Options include:
            //1. Throw a custom exception:
            //throw new ArgumentException("Denominator cannot be zero.");
            //2. Return a default value:
            return 0; 
            //3. Log an error and return a default value
            //log.Error("Division by zero attempted");
            //return 0;
        }
        return a / b;
    }
}
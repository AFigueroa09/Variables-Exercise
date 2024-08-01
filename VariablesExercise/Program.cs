namespace VariablesExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string dogName = "Mara";
            int dogAge = 10;
            char grade = 'A';
            bool isFriendly = true;
            decimal toyPrice = 5.99m;
            double weight = 49.3245;
            string friendlyVal = isFriendly? "is" : "is not";
             
            Console.WriteLine("My dog's name is "+ dogName + ", She is " + dogAge + " years old. She weights " + weight + " pounds. She " + friendlyVal+ " friendly. Her favorite toy is a rope and it costs $" + toyPrice + ". She got an " + grade + " on her behaviour training.");
        }
    }
}

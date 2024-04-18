namespace Playground.Classes
{
    public class Door
    {
        private int invocationsCount = 0;
        
        // int height = 100;
        int width = 50;
        string material = "wood";
        double discount = 0.1;

        /*
         * // 10 years ago
        //Get
        public int GetHeight()
        {
            return this.height;
        }
        //Set
        public void SetHeight(int newHeight)
        {
            this.height = newHeight;
        }
        */

       /* 
         // 7 years ago
        public int Height
        {
            get => this.height;
            set => this.height = value;
        }
       */

        // 5  years ago
        public int Height { get; set; }

        public void Print()
        {
            this.invocationsCount++;
            Console.WriteLine("Hello, world! This is the door class.");
            Console.WriteLine($"This method was called {invocationsCount} time(s)");
        }
    }
}

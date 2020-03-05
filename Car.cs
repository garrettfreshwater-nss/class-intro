namespace ClassIntro
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Model} {Make}";
            }
        }

    }
}
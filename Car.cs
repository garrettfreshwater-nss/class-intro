namespace ClassIntro
{
    public class Car
    {
        private int _milesDriven;
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public bool NeedsMaintenance { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Model} {Make}";
            }
        }

        public void Drive (int miles)
        {
            _milesDriven += miles;

            if (_milesDriven > 10000)
            {
                NeedsMaintenance = true;
            }
        }

    }
}
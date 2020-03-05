namespace ClassIntro
{
    public class Car
    {
        //! Field
        //* Fields don't have a get; set; and are typically private
        private int _milesDriven = 0;

        //! Properties
        //* Properties have a aget; set; and are typically public
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public bool NeedsMaintenance { get; set; } = false;

        public bool IsClean { get; set; } = false;

        public string Description
        {
            get
            {
                return $"{Year} {Model} {Make}";
            }
        }

        public void Drive(int miles)
        {
            _milesDriven += miles;

            if (_milesDriven > 10000)
            {
                NeedsMaintenance = true;
            }
        }

        public void Service()
        {
            NeedsMaintenance = false;
        }

        public void Service(bool addCleaningService) // method overloading
        {
            NeedsMaintenance = false;

            if (addCleaningService)
            {
                IsClean = true;
            }
        }

        // This is a constructor. It doesn't have a return type
        // and the name of the method is the same as the name of the class
        public Car(int milesDriven)
        {
            _milesDriven = milesDriven;
        }

        public Car(int milesDriven, string make, string model, int year)
        {
            _milesDriven = milesDriven;
            Make = make;
            Model = model;
            Year = year;
        }

    }
}
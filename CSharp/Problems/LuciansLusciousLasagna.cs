namespace CSharp.Problems
{
    /**
     * Lucian's Luscious Lasagna
     * 
     * The lasagna is a classic dish that requires careful preparation and cooking. 
     * In this exercise, you will implement a class that helps Lucian keep track of the cooking time for his lasagna.
     */
    class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int actualMinutes)
        {
            return ExpectedMinutesInOven() - actualMinutes;
        }

        public int PreparationTimeInMinutes(int numberOfLayers)
        {
            return numberOfLayers * 2;
        }

        public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
        {
            return PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
        }
    }

}


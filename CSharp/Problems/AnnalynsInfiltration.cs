namespace CSharp.Problems
{
    class AnnalynsInfiltration
    {
        public bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }

        public bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        public bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            return prisonerIsAwake && !archerIsAwake;
        }

        public bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            return ((knightIsAwake && petDogIsPresent) || (prisonerIsAwake && !knightIsAwake) || petDogIsPresent) && !archerIsAwake;
        }
    }

};


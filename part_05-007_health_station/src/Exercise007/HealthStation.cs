namespace Exercise007
{
    public class HealthStation
    {
        public int weighings { get; private set; }

        // Create a constructor here, if needed

        public int Weigh(Person person)
        {
            // return the weight of the person passed as the parameter
            this.weighings++;
            return person.weight;
        }

        public void Feed(Person person)
        {
            person.weight++;
        }


    }
}
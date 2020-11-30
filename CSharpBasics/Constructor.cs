namespace LearningClasses
{
    public class Country
    {
        public string Name {get;set;}

        public int Population {get; set; }

        public static readonly bool isOnEarth;

        // Default constructor - parameter less
        public Country()
        {
            
        }

        public Country(string name,int population)
        {
            Name = name;
            Population = population;
        }
        static Country()
        {
            isOnEarth = true;
        }

        
    }

    public class Demo
    {
        void DoSomething()
        {

            Country country1 = new Country();
            var x = Country.isOnEarth;
            // Country country2 = new Country("Nepal");
            
        }
        
    }
}
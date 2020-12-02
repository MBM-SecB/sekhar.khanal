namespace LearningClasses
{

    public class Country
    {
        public string Name { get; set; }
        public int Popultion { get; set; }

        public static bool isOnEarth;

        //Instance constructor
        //Default constructor - parameterless
        public Country()
        {

        }
        //  constructer with parameters
        public Country(string name, int population)
        {
            Name = name;
            Popultion = population;
        }

        //static constructor
        static Country()
        {

        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal", 123456);
            var a = country2.Name;

            // static members can be called with class name itself
            var x = Country.isOnEarth;


        }
    }
}
class Person
{
    public int age = 23;
    internal string name = "Azyt";


    public string Name {get;set;}

    public string Address {get;}

    public int Age
     {
        get
        {
            return age;
        }
        set
        {
            if(value>20 && value <30)
            {
                age = value;
            }
        }
        }

}
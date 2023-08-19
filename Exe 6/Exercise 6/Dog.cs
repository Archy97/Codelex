public class Dog
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public Dog Mother;
    public Dog Father;

    public Dog(string name, string gender)
    {
        Name = name;
        Gender = gender;
    }

    public string FathersName()
    {
        return (Father != null) ? Father.Name : "Unknown";
    }

    public bool HasSameMotherAs(Dog otherDog)
    {
        return Mother.Name == otherDog.Mother.Name;
    }
}

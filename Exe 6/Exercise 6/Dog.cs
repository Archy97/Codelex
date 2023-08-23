public class Dog
{
    private string _name;
    private string _gender;
    public Dog Mother { get; set; }
    public Dog Father { get; set; }

    public Dog(string name, string gender)
    {
        _name = name;
        _gender = gender;
    }

    public string FathersName()
    {
        return Father != null ? Father.FathersName() : "Unknown";
    }

    public bool HasSameMotherAs(Dog otherDog)
    {
        return Mother?._name == otherDog.Mother?._name;
    }
}

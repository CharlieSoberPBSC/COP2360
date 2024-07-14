Person p = new Person("Alice", "Jones");
p.Print(); // Alice Jones

Relative r = new Relative("Alice", "Jones", "Cousin");
r.PrintRelationship(); // Alice Jones is a Cousin

class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Print()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
//inherits from 'person', adds 'RelationshipType'
class Relative : Person
{
    public string RelationshipType { get; }

    public Relative(string firstName, string lastName, string relationshipType)
          //calls 'Person' constructor
        : base(firstName, lastName)
    {
        RelationshipType = relationshipType;
    }
    //prints persons's name along with relationship type
    public void PrintRelationship()
    {
        Console.WriteLine($"{FirstName} {LastName} is a {RelationshipType}");
    }
}

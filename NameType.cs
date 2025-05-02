// Record Type ; aka Struct 
public struct NameType
{
    public string FirstName; 
    public string LastName; 
    
    public NameType(string takeOneName) {
        FirstName = takeOneName;
        LastName = "";
    }    
    
    public NameType(string takeFirstName, string takeLastName) {
        FirstName = takeFirstName;
        LastName = takeLastName;
    }

    public override string ToString() {
        return string.IsNullOrWhiteSpace(LastName) ? FirstName : $"{FirstName} {LastName}";
    }
}
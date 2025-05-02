// Derived Class: EBook
// Notes on C# Structure: 
// syntax: <scope> <type> <name> 
// Product info display is done in Product. Static variables are usually only existing in Product (base class)

public class EBook : BookProduct {

    // Protected Variables - use BookProduct Variables

    // Default Constructor - skips need for initialization and make default values 
    public EBook() : base() {
        // in Book product
    }

    // Custom Constructor - takes parameters for validation
    public EBook(string aProdName, double aPrice, NameType anAuthor, int pageNum) : base(aProdName, aPrice, anAuthor, pageNum) {
        // in Book product
    }

    // Getters / Accessors - retrieve private/protected variables (syntax: public get() => corresponding var)
    // Setters / Mutators - modify or set variables
   

    // Abstract / Virtual Functions - child classes can implement OR override these
    public override string getProdTypeStr() {
        return "EBook"; 
    } // Since Book is abstract, the title should be provided by the derived classes


/*    public override void displayContentsInfo(){
        System.Console.WriteLine($"Author Name: {author}");
        System.Console.WriteLine($"Pages: {pages}");
    } */
}

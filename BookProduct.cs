// Derived Class: BookProduct
// Notes on C# Structure: 
// syntax: <scope> <type> <name> 
// Product info display is done in Product. Static variables are usually only existing in Product (base class)

public abstract class BookProduct : Product {

    // Protected Variables - means accessible to any class that inherits Product
    private NameType author; 
    private int pages; 
    
    // Default Constructor - skips need for initialization and make default values 
    public BookProduct() : base() {
        author = new NameType("Unknown", "Author");
        pages = 0;
    }

    // Custom Constructor - takes parameters for validation
    public BookProduct(string aProdName, double aPrice, NameType anAuthor, int pageNum) : base(aProdName, aPrice) {
        author = anAuthor;
        pages = pageNum;
    }

    // Getters / Accessors - retrieve private/protected variables (syntax: public get() => corresponding var)
    public NameType getAuthor() => author;
    public int getPages() => pages; 

    // Setters / Mutators - modify or set variables
    public void setAuthor(NameType anAuthor) => author = anAuthor;
    public void setPages(int aPage) => pages = aPage;

    // Abstract / Virtual Functions - child classes can implement OR override these
    /* public override string getProdTypeStr() {
        return "Book"; 
    }*/ // Since Book is abstract, the title should be provided by the derived classes
    public override void displayContentsInfo(){
        System.Console.WriteLine($"Author Name: {author}");
        System.Console.WriteLine($"Pages: {pages}");
    }
}

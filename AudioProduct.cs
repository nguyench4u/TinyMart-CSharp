// Derived Class: AudioProduct
// Notes on C# Structure: 
// syntax: <scope> <type> <name> 
// Product info display is done in Product. Static variables are usually only existing in Product (base class)

public class AudioProduct : Product {

    // Protected Variables - means accessible to any class that inherits Product
    private NameType singer; 
    private GenreType genre; 
    
    // Default Constructor - skips need for initialization and make default values 
    public AudioProduct() : base() {
        singer = new NameType("Unknown", "Singer");
        genre = GenreType.Pop; // default from the enum list 
    }

    // Custom Constructor - takes parameters for validation
    public AudioProduct(string aProdName, double aPrice, NameType aSinger) : base(aProdName, aPrice) {
        singer = aSinger;
        genre = GenreType.Pop;
    }

    // Getters / Accessors - retrieve private/protected variables (syntax: public get() => corresponding var)
    public NameType getSinger() => singer;
    public GenreType getGenre() => genre;  

    // Setters / Mutators - modify or set variables
    public void setSinger(NameType aSinger) => singer = aSinger;
    public void setGenre(GenreType aGenre) => genre = aGenre; 

    // Abstract / Virtual Functions - child classes can implement OR override these
    public override string getProdTypeStr() {
        return "Music";
    }
    public override void displayContentsInfo(){
        System.Console.WriteLine($"Singer Name: {singer}");
        System.Console.WriteLine($"Genre: {genre}");
    }
}
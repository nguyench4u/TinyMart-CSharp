// Derived Class: VideoProduct
// Notes on C# Structure: 
// syntax: <scope> <type> <name> 
// Product info display is done in Product. Static variables are usually only existing in Product (base class)

public class VideoProduct : Product {

    // Protected Variables - means accessible to any class that inherits Product
    private NameType director; 
    private FilmRateType filmRate;
    private int releaseYear; 
    private int runTime;
    
    // Default Constructor - skips need for initialization and make default values 
    public VideoProduct() {
        director = new NameType("Unknown", "Director");
        filmRate = FilmRateType.NotRated;
        releaseYear = 0;
        runTime = 0; 
    }

    // Custom Constructor - takes parameters for validation
    public VideoProduct(string aProdName, double aPrice, NameType aDirectorName, int aReleaseYear, int aRunTime) : base(aProdName, aPrice) {
        director = aDirectorName;
        filmRate = FilmRateType.NotRated;
        releaseYear = aReleaseYear; 
        runTime = aRunTime;

    }

    // Getters / Accessors - retrieve private/protected variables (syntax: public get() => corresponding var)
    public NameType getDirector() => director; 
    public FilmRateType getFilmRate() => filmRate; 
    public int getReleaseYear() => releaseYear;
    public int getRunTime() => runTime; 

    // Setters / Mutators - modify or set variables
    public void setDirector(NameType aDirector) => director = aDirector;
    public void setFilmRate(FilmRateType aFilmRate) => filmRate = aFilmRate;
    public void setReleaseYear(int aReleaseYear) => releaseYear = aReleaseYear;
    public void setRunTime(int aRunTime) => runTime = aRunTime;

    // Bool Method for Is New
    public bool isNewRelease(int theYear) {
        return releaseYear >= theYear;
    }
    
    // Abstract / Virtual Functions - child classes can implement OR override these
    public override string getProdTypeStr() {
        return "Movie";
    }

    public override void displayContentsInfo(){
        System.Console.WriteLine($"Release Year: {releaseYear}");
        System.Console.WriteLine($"Film Rating: {filmRate}");
        System.Console.WriteLine($"Runtime: {runTime}");
        System.Console.WriteLine($"Director Name: {director}");
    }
}

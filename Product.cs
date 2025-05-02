// Parent Class 
// Notes on C# Structure: 
// syntax: <scope> <type> <name> 
// public Class { include private member variables, public class with variables, public class with parameters & same variables, public getters/setters, public display functions }
// abstract to indicate base class that multiple classes can share 
// Static methods/variables are usually initialized here only and then inherited 
public abstract class Product {
    
    // Protected Variables - means accessible to any class that inherits Product
    private static int nextID = 1; // static variable unique only to class
    protected int productID;
    protected string productName;
    protected double price; 
    protected float reviewRate;


    // Default Constructor - skips need for initialization and make default values 
    public Product() {
        productID = CreateNewID(); 
        productName = "!No Name Product!";
        price = 0.0; 
        reviewRate = 0.0f; 
    }

    // Custom Constructor - takes parameters for validation
    public Product(string aProdName, double aPrice) {
        productID = CreateNewID(); 
        productName = string.IsNullOrWhiteSpace(aProdName) ? "!No Name Product!" : aProdName; // Checks if aProdName is empty
        price = (aPrice > 0 && aPrice < 1000) ? aPrice : 0.0; 
        reviewRate = 0.0f; 
    }

    // Getters / Accessors - retrieve private/protected variables (syntax: public get() => corresponding var)
    public int getProdID() => productID; 
    public string getProdName() => productName; 
    public double getPrice() => price; 
    public float getReviewRate() => reviewRate; 

    // Setters / Mutators - modify or set variables
    public void setProdID(int theID) => productID = theID;
    public void setProdName(string theName) => productName = theName; 
    public void setPrice(double thePrice) => price = thePrice; 
    public void setReviewRate(float theRate) => reviewRate = theRate; 

    // Abstract / Virtual Functions - child classes can implement OR override these
    // Abstract forces a design contract and MUST be overriden, and Virtual allows overriding and has method body
    public abstract string getProdTypeStr(); 
    public abstract void displayContentsInfo();
    public virtual void displayProdInfo(){
        System.Console.WriteLine($"\n[{getProdTypeStr()}]");
        System.Console.WriteLine($"Product ID: {productID}\t Product Name: {productName}");
        System.Console.WriteLine($"Price: {price}\t Product Review Rate: {reviewRate}");

        displayContentsInfo(); 
    }

    // Static Method to generate unique method only to class (unique product ID)
    private static int CreateNewID() {
        return nextID++; 
    }
}

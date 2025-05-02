// Holds Product Objects using Inheritance and Polymorphism  
// Notes on C# Structure: 
// $ before quotations sets up some template to display a variable
// EXTRA CREDIT AT THE BOTTOM

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

// Protected Variables - means accessible to any class that inherits Cart
public class Cart {
    private const int MAX_ITEMS = 7;
    //private int itemNum;
    private NameType owner; 
    private List<Product> purchasedItems; // not a list of strings, but Products!


    // Default Constructor - skips need for initialization and make default values 
    public Cart() {
        owner = new NameType("Unnamed", "Owner");
        purchasedItems = new List<Product>(); 
    }

    // Custom Constructor - takes parameters for validation 
    public Cart(NameType theOwner) {
        owner = theOwner;
        purchasedItems = new List<Product>(); 
    }

    // Public Functions to add products into the Cart
    public bool addItem(Product theProduct) {
        if(isCartFull()) return false; 
        purchasedItems.Add(theProduct);
        return true;
    }

    public bool removeItem(int theProductID) {
        Product? match = purchasedItems.Find(p => p.getProdID() == theProductID); // '?' allows null and handles it safely
        if (match != null) {
            purchasedItems.Remove(match);
            return true; 
        }
        return false; 
    }

    public void displayCart() {
        System.Console.WriteLine("\nMyCart\n======\n");
        System.Console.WriteLine($"Cart Owner: {owner}");

        double total = 0.0;

        foreach (Product product in purchasedItems) {
            product.displayProdInfo();
            System.Console.WriteLine(); 
            total += product.getPrice();
        }

        System.Console.WriteLine("\n===== Summary of Purchase ====="); 
        System.Console.WriteLine($"Total number of purchases: {purchasedItems.Count}"); 
        System.Console.WriteLine($"Total purchasing amount: ${total:F2}"); 
        System.Console.WriteLine($"Average Cost: ${(purchasedItems.Count > 0 ? total/purchasedItems.Count : 0):F2}"); 
    }

    private bool isCartFull() {
        return purchasedItems.Count >= MAX_ITEMS; 
    }


    // EXTRA CREDIT Search Product by Name
    public Product? SearchProduct(string prodName) {
        return purchasedItems.Find(p => p.getProdName().Equals(prodName, StringComparison.OrdinalIgnoreCase));
    }


    // EXTRA CREDIT SaveCart Method
    public bool SaveCart(string fileName) {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Product p in purchasedItems)
                {
                    if (p is AudioProduct audio)
                    {
                        writer.WriteLine($"Audio,{audio.getProdName()},{audio.getPrice()},{audio.getSinger()},{audio.getGenre()},{audio.getReviewRate()}");
                    }
                    else if (p is VideoProduct video)
                    {
                        writer.WriteLine($"Video,{video.getProdName()},{video.getPrice()},{video.getDirector()},{video.getReleaseYear()},{video.getRunTime()},{video.getFilmRate()},{video.getReviewRate()}");
                    }
                    else if (p is EBook ebook)
                    {
                        writer.WriteLine($"EBook,{ebook.getProdName()},{ebook.getPrice()},{ebook.getAuthor()},{ebook.getPages()},{ebook.getReviewRate()}");
                    }
                    else if (p is PaperBook paper)
                    {
                        writer.WriteLine($"PaperBook,{paper.getProdName()},{paper.getPrice()},{paper.getAuthor()},{paper.getPages()},{paper.getReviewRate()}");
                    }
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }


}
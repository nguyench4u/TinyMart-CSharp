// Reminders for OOP! 
// static is called by runtime
// void is a function that does not return anything
// EXTRA CREDIT AT THE BOTTOM
class Program {
    static void Main(string[] args){ // any number of arguments 
        // Body here (We want 3 Audio products, 2 video products, 1 Ebook, 1 Paperbook, 1 extra, and 1 cart.)
        
        // 3 Audio Products
        AudioProduct song1 = new AudioProduct("Yesterday", 16.5, new NameType("Beetles"));
        song1.setGenre(GenreType.Pop);
        song1.setReviewRate(9.8f);

        AudioProduct song2 = new AudioProduct("We are the World", 13.75, new NameType("Michael", "Jackson"));
        song2.setGenre(GenreType.Country);
        song2.setReviewRate(9.1f);

        AudioProduct song3 = new AudioProduct("Gangnam Style", 10.5, new NameType("PSY"));
        song3.setGenre(GenreType.Pop);
        song3.setReviewRate(9.5f);


        // 2 Video Products
        VideoProduct movie1 = new VideoProduct("Sound of Music", 22.0, new NameType("Robert", "Wise"), 1965, 175);
        movie1.setFilmRate(FilmRateType.G);
        movie1.setReviewRate(9.2f);

        VideoProduct movie2 = new VideoProduct("Star Wars", 22.0, new NameType("George", "Lucas"), 1977, 120);
        movie2.setFilmRate(FilmRateType.PG);
        movie2.setReviewRate(8.5f);

        
        // 1 Ebook
        EBook ebook = new EBook("The Old Man and the Sea", 8.3, new NameType("Ernest", "Hemmingway"), 127);
        ebook.setReviewRate(9.5f);

        // 1 Paperbook 
        PaperBook manga = new PaperBook("Attack on Titan", 7.5, new NameType("Hajime", "Isayama"), 210);
        manga.setReviewRate(9.9f);

        // 1 extra
        VideoProduct movieExtra = new VideoProduct("A Minecraft Movie", 37.0, new NameType("Jared", "Hess"), 2025, 101);
        movieExtra.setFilmRate(FilmRateType.PG13);
        movieExtra.setReviewRate(5.9f);

        // CreateCart
        Cart myCart = new Cart(new NameType("Chau", "Nguyen"));
        myCart.addItem(song1);
        myCart.addItem(song2);
        myCart.addItem(song3);
        myCart.addItem(movie1);
        myCart.addItem(movie2);
        myCart.addItem(ebook);
        myCart.addItem(manga);
        myCart.addItem(movieExtra);

        // Remove 2 Items
        myCart.removeItem(movie1.getProdID());
        myCart.removeItem(ebook.getProdID());

        // Display the cart
        myCart.displayCart();


        // EXTRA CREDIT: Search for a product by name
        System.Console.WriteLine("\n[EXTRA CREDIT] Enter the product name to search for:");
        string? userInput = System.Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userInput)) {
            Product? foundProduct = myCart.SearchProduct(userInput);

            if (foundProduct != null) {
                System.Console.WriteLine("\n[Search Result]");
                foundProduct.displayProdInfo();
            }
            else {
                System.Console.WriteLine("\nProduct not found.");
            }
        }
        else {
            System.Console.WriteLine("\nInvalid input. Please enter a product name.");
        }
        // EXTRA CREDIT: Save cart contents
        bool success = myCart.SaveCart("cart_output.txt");
        System.Console.WriteLine(success ? "\n[EXTRA CREDIT] Cart is now saved to file." : "\nFailed to save cart.");


    }

    

}
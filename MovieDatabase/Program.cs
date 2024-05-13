

using MovieDatabase;
using StaticClass;
using System.ComponentModel;

List<Movie> queerMovies = new List<Movie>
{
    new Movie("Wendell & Wild", "animated", 2022),
    new Movie("Tokyo Godfathers", "animated", 2003),
    new Movie("Nimona", "animated", 2023),
    new Movie("Flee", "animated", 2021),
    new Movie("Blue Jean", "drama", 2022),
    new Movie("The Miseducation of Cameron Post", "drama", 2018),
    new Movie("But I'm a Cheerleader", "drama", 1999),
    new Movie("We're All Going to the World's Fair", "horror", 2021),
    new Movie("They/Them", "horror", 2022),
    new Movie("Jennifer's Body", "horror", 2009),
    new Movie("Thelma", "horror", 2017),
    new Movie("Rocky Horror", "scifi", 1975),
    new Movie("Credence", "scifi", 2015),
};

do
{
    //maincode
    Console.WriteLine("Welcome to the Queer Movie Database!");
    Console.WriteLine($"There are {queerMovies.Count()} in this list.");
        
    
    
    while(true) {
        Console.WriteLine("What category would you like to see?");
        string input = Console.ReadLine().Trim().ToLower();

        //saw this on linkedin and wanted to try it
        if (input is "animated" or "drama" or "horror" or "scifi")
        {
            List<Movie> result = queerMovies.Where(m => m.Category == input).OrderBy(m => m.Title).ToList();
            foreach (Movie r in result)
            {
                Console.WriteLine($"Title: { r.Title} Year: {r.Year}");
            }
            break;


        }
        else
        {
            Console.WriteLine("Invalid Input, please try again");
        }
    }
    


} while (Validator.GetContinue());



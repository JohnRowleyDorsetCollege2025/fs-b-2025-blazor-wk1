public static class MovieRepository
{
    public static List<Movie> GetMovies()
    {
        return new List<Movie>
        {
            new Movie { Id = 1, Title = "The Great Escape", Genre = "Adventure", ReleaseYear = 1963, Director = "John Sturges", Rating = 8.2 },
            new Movie { Id = 2, Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Director = "Christopher Nolan", Rating = 8.8 },
            new Movie { Id = 3, Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972, Director = "Francis Ford Coppola", Rating = 9.2 },
            new Movie { Id = 4, Title = "Pulp Fiction", Genre = "Crime", ReleaseYear = 1994, Director = "Quentin Tarantino", Rating = 8.9 },
            new Movie { Id = 5, Title = "Spirited Away", Genre = "Animation", ReleaseYear = 2001, Director = "Hayao Miyazaki", Rating = 8.6 },
            new Movie { Id = 6, Title = "Parasite", Genre = "Thriller", ReleaseYear = 2019, Director = "Bong Joon-ho", Rating = 8.6 },
            new Movie { Id = 7, Title = "The Matrix", Genre = "Sci-Fi", ReleaseYear = 1999, Director = "The Wachowskis", Rating = 8.7 },
            new Movie { Id = 8, Title = "Casablanca", Genre = "Romance", ReleaseYear = 1942, Director = "Michael Curtiz", Rating = 8.5 },
            new Movie { Id = 9, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994, Director = "Frank Darabont", Rating = 9.3 },
            new Movie { Id = 10, Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015, Director = "George Miller", Rating = 8.1 }
        };
    }
}
using dm_cinema;

Film monfilm = new Film();

Cinema monCinema = new Cinema();

// Ajout des acteurs
Acteur acteur1 = new Acteur("Ford", "Harisson", 1942,1);
Acteur acteur2 = new Acteur("Hanks", "Tom", 1956,2);

monCinema.SetActeur(acteur1);
monCinema.SetActeur(acteur2);

// Ajout des films
Film film1 = new Film("Blade Runner", 1982, "Science-Fiction", 1,
    "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).");

Film film2 = new Film("Toy Story", 1992, "Animation", 2,
    "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.");

monCinema.SetFilm(film1);
monCinema.SetFilm(film2);


Console.WriteLine("Caractéristiques des films :");
foreach (Film film in monCinema.NbFilms())
{
    Console.WriteLine(film.ToString());
    Console.WriteLine();
}

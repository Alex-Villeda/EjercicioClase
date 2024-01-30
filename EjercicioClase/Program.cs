

//Superpoder
using EjercicioClase;

Superpoder Millonario = new Superpoder("Super Millonario", "Dinero de sobra", 8);
Superpoder Genio = new Superpoder("Super Genio", "Armadura de combate", 10);
Superpoder Aracnidos = new Superpoder("Poderes aracnidos", "Lanza Telaraña", 9);


//SuperHeroes
SuperHeroe Batman = new SuperHeroe("Batman", "Bruce Wayne", "Gotica", false, Millonario);
SuperHeroe Ironman = new SuperHeroe("Ironman", "Tony Stark", "New York", true, Genio);
SuperHeroe Spiderman = new SuperHeroe("Spiderman", "Piter Parker", "Queens", false, Aracnidos);

//Imprimir
Batman.Imprimir();
Ironman.Imprimir();
Spiderman.Imprimir();



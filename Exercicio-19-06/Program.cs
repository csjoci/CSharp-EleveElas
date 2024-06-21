using Exercicio_19_06;
using Zoologico.Domain;

Anfibio animalAnfibio = new Anfibio();
animalAnfibio.Descer(10);
animalAnfibio.Subir(10);

Mamifero animalMamifero = new Mamifero();
animalMamifero.Descer(10);
animalMamifero.Subir(10);

Aves animalAve = new Aves();
animalAve.LevantarVoo();
animalAve.Pousar();


AnfibioNadador animal = new AnfibioNadador();
animal.LimiteProfundidade = 150;

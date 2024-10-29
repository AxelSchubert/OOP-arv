namespace OOP_arv;
// Tänk dig att du ska skapa en grund för ett program som hanterar djur på ett zoo.
//
// - [x]  Det ska finnas en basklass som heter `Animal`
// - [x]  Klassen ska ha minst fem egenskaper som alla djur delar med varandra.
// - [x]  Klassen ska också ha minst tre metoder som alla djur delar med varandra.
// - [x]  Du ska skapa minst tre olika djur som ärver från klassen Animal.
// - [x]  Dessa djur ska implementera minst en ny egenskap vardera och minst en ny metod vardera.
// - [x]  Dessa djur ska också ha defaultvärden för egenskaperna, både de som sätts i klassen och de som sätts i basklassen.
// - [x]  Alla djur måste ha en metod som heter `makeSound()` och som ska skriva ut djurets läte i konsollen.
// - [x]  Det ska finnas en konstruktor som kan användas för att skapa nya djur.
// - [x]  Ett av djuren du skapat ovan ska du sedan dela upp i två nya klasser som ärver från det djuret.
// - [x]  Exempelvis kanske du har hund och då kan du skapa Bulldog och Chihuahua. Resultatet blir arv i två nivåer.
// - [x]  Dessa djurvarianter ska också implementera någon unik egenskap och någon unik metod eller i alla fall en överlagring som gör dem unika.
// - [ ]  I din Main-metod ska du initiera ett flertal olika djur och se till att de gör sina ljud så det syns i konsollen att djuren har låtit.

class Program
{
    static void Main(string[] args)
    {   
        var lion = new Lion("Simba", 9, "Orange", "Hane");
        var dog = new Dog("Pricken", 3, "Svart", "Hane", "Erik");
        var bird = new Bird("Coco", 2, "Blå och grön", "Hona", true);
        var chihuaha = new Chihuahua("Smulan", 5, "Vit", "Hona", "Linda");
        var bulldog = new Bulldog("Kajsa", 5, "Brun", "Hane", "Johan");
        lion.MakeSound();
        dog.MakeSound();
        bird.MakeSound();
        chihuaha.MakeSound(); 
        bulldog.MakeSound();
    }
}
namespace OOP_arv;

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
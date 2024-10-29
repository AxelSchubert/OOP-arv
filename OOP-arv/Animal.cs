using System.Drawing;

namespace OOP_arv;

public class Animal
{
    protected string Name;
    protected int Age;
    protected string Species;
    protected string Color;
    protected string Sex;
    public virtual void Eat()
    {
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Species}\n{Name}\n{Age}\n{Color}");
    }
    public virtual void MakeSound()
    {
    }
    //Här använder jag en parameterlös konstruktor utöver min andra konstruktor för att man ska kunna skapa en instans med defaultvärden.
    public Animal()
    {
        Name = "Okänd";
        Age = 0;
        Species = "Djur";
        Color = "Okänd";
        Sex = "Hane";
    }
    public Animal(string name, int age, string color, string sex)
    {
        Name = name;
        Age = age;
        Color = color;
        Sex = sex;
    }
}

public class Lion : Animal
{
    public bool HasMane;

    public Lion() : base()
    {
        Species = "Lejon";
        if (Sex == "Hane")
        {
            HasMane = true;
        }
        else
        {
            HasMane = false;
        }   
    }
    public Lion(string name, int age, string color, string sex) : base(name, age,  color,
        sex)
    {
        Species = "Lejon";
        //Eftersom lejon bara har man om dom är hanar så sätter jag HasMane utefter Sex-variabeln.
        if (sex == "Hane")
        {
            HasMane = true;
        }
        else
        {
            HasMane = false;
        }
    }

    public override void Eat()
    {
        Console.WriteLine($"Lejonet {Name} äter.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine(HasMane ? "Lejonet har en man." : "Lejonet har inte en man.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"Lejonet {Name} ryter!");
    }

    public void Hunt()
    {
        Console.WriteLine($"Lejonet {Name} jagar antiloper på savannen.");
    }
}

public class Dog : Animal
{
    public string Owner;
    public Dog() : base()                                                                                                             
    {   
        Owner = "Okänd ägare";
        Species = "Hund";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
    }                                                                                                                                  
    public Dog(string name, int age, string color, string sex, string owner) : base(name, age,  color,                                              
        sex)                                                                                                                           
    {       
        owner = Owner;
        Species = "Hund";                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    }                                                                                                                                  
                                                                                                                                       
    public override void Eat()                                                                                                         
    {                                                                                                                                  
        Console.WriteLine($"Hunden {Name} äter.");                                                                                    
    }                                                                                                                                  
                                                                                                                                       
    public override void DisplayInfo()                                                                                                 
    {                                                                                                                                  
        base.DisplayInfo();
        Console.WriteLine($"Ägare: {Owner}");                                          
    }                                                                                                                                  
    public override void MakeSound()                                                                                                   
    {                                                                                                                                  
        Console.WriteLine($"Hunden {Name} skäller!");                                                                                   
    }       
    public void Fetch()                                                                                                                
    {                                                                                                                                  
        Console.WriteLine($"Hunden {Name} leker apport!");                                                                             
    }
}

public class Bird : Animal                                                                                                     
{                                                                                                                             
    public bool CanFly;                                                                                                      
    public Bird() : base()                                                                                                     
    {                                                                                                                         
        Species = "Fågel";                                                                                              
        CanFly = true;                                                                                          
    }                                                                                                                         
    public Bird(string name, int age, string color, string sex, bool canFly) : base(name, age,  color,                        
        sex)                                                                                                     
    {                                                                                                                         
        canFly = CanFly;                                                                                                       
        Species = "Fågel";                                                                                                    
    }                                                                                                                         
                                                                                                                              
    public override void Eat()                                                                                                
    {                                                                                                                         
        Console.WriteLine($"Lejonet {Name} äter.");                                                                           
    }                                                                                                                         
                                                                                                                              
    public override void DisplayInfo()                                                                                        
    {                                                                                                                         
        base.DisplayInfo();
        if (CanFly)
        {
            Console.WriteLine("Fågeln kan flyga!");
        }
        else
        {
            Console.WriteLine("Fågeln kan inte flyga!");
        }
    }                                                                                                                         
    public override void MakeSound()                                                                                          
    {                                                                                                                         
        Console.WriteLine($"Fågeln {Name} kvittrar!");                                                                         
    }                                                                                                                         
    public void BuildNest()                                                                                                    
    {                                                                                                                         
        Console.WriteLine($"Fågeln {Name} bygger ett bo för sina ägg!");                                                                     
    }                                                    
}

public class Chihuahua : Dog
{
    public Chihuahua(string name, int age, string color, string sex, string owner) : base(name, age,  color,                                              
        sex, owner)                                                                                                                           
    {       
    }   
    //unik överlagring jämfört med Dog-klassen, annars är dom likadana
    public override void MakeSound()
    {
        Console.WriteLine($"Chihuahuan {Name} skäller ynkligt!");
    }
}

public class Bulldog : Dog
{
    public Bulldog(string name, int age, string color, string sex, string owner) : base(name, age,  color,                                              
        sex, owner)                                                                                                                           
    {       
    }   
    //unik överlagring jämfört med Dog-klassen, annars är dom likadana
    public override void MakeSound()
    {
        Console.WriteLine($"Bulldogen {Name} morrar hotfullt!");
    }
}
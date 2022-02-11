using System;
using System.Collections.Generic;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            //That's the idea of this method. The ConcreteCreators tell the AbstractCreator which ConcreteProduct to use!!!
            var NewYorkPizzaStore = new NewYorkPizzaStore();
            var pizza = NewYorkPizzaStore.OrderPizza(PizzaType.Veggie);
            Console.WriteLine($"Richard ordered a {pizza.Name}\n");

            var NapoliPizzaStore = new NaplesPizzaStore();
            pizza = NapoliPizzaStore.OrderPizza(PizzaType.Veggie);
            // what if this store only did 1 type of pizza? // nullable enum?
            Console.WriteLine($"Richard ordered a {pizza.Name}\n");

            //var nyStore = new NewYorkPizzaStore();
            //var chicagoStore = new ChicagoPizzaStore();

            //var pizza = nyStore.OrderPizza(PizzaType.Cheese);
            //Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            //pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            //Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            //pizza = nyStore.OrderPizza(PizzaType.Peperoni);
            //Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            //pizza = chicagoStore.OrderPizza(PizzaType.Peperoni);
            //Console.WriteLine($"Joel ordered a {pizza.Name}\n");

            //pizza = nyStore.OrderPizza(PizzaType.Veggie);
            //Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

            //pizza = chicagoStore.OrderPizza(PizzaType.Veggie);
            //Console.WriteLine($"Joel ordered a {pizza.Name}\n");
        }
    }
}


//    Guys! Please read this comment until the end, I know it is long but it will be worth your time if you really want to learn.I love these videos but this video is WRONG!


//    This is a MISINTERPRETATION of the Factory Method pattern.This is NOT the purpose of the pattern, this is a very common misunderstanding.
//    Be careful. I'm telling you this because I'm reading it from the Gang of Four Design Pattern book, I have it in my hand right now. 


//    Where did this video go wrong?
    
//1. When it said that the problem this pattern solves is isolating the complexity of the creation. This is NOT the purpose.Isolating the creation of the objects is the responsibility of the Abstract Factory, not Factory Method.
    
//2. When he said that a factory method can return several types of Products. No!! The factory method should return a SINGLE Product type (this is a little lie, but bear with me) 

//The problem that is solved by this pattern is that the Abstract Creator can't know which Concrete Products should be used by each Concrete Creator, so it let's the Concrete Creators define the type of Concrete Product to be used via a factory method, which is an abstract method(Java).


public abstract class Zoo
{
    protected abstract Animal GetAnimal();
}
//Let's say I have a Zoo class (Abstract Creator)
//and I have multiple types of Zoo: DogZoo and CatZoo (Concrete Creators).
public class DogZoo : Zoo
{
    public List<Animal> animals = new();

    protected override Animal GetAnimal()
    {
        throw new NotImplementedException();
    }
}
public class CatZoo : Zoo
{
    protected override Animal GetAnimal()
    {
        throw new NotImplementedException();
    }
}
//That's the idea of this method. The ConcreteCreators tell the AbstractCreator which ConcreteProduct to use!!!

public abstract class Animal
{

}

//I also have the class Animal (Abstract Product) and the classes Dog and Cat (Concrete Products).
//Also, the Zoo has a List of Animals. 

//OK, so let's say the Zoo has a method SpawnAnimal() that creates a new animal and adds it to the Animal List. But... Wait... Zoo doesn't know which type of animal it should add to the list! Does it add a cat? a dog? a parrot? Zoo can't know!
//So Zoo says "OK I will define a factory method createAnimal() so that my subclasses can tell me which type of Animal they want to use when I spawn an animal".

//So the DogZoo will return a dog in that createAnimal() method.The CatZoo will return a cat.
//Then when the Zoo calls the SpawnAnimal it creates the new animal with its createAnimal function.

//That's the idea of this method. The ConcreteCreators tell the AbstractCreator which ConcreteProduct to use!!!

//That's why the definition says "let subclasses define the ConcreteProduct".
//The purpose is NOT about isolating the creation in a separate Factory class!!! The purpose is NOT to allow switching factories on runtime to change from one behavior to another!!!

//Now that I have your attention.I lied when I said that the factory method can only return a single type of Concrete Product.
//There is actually a variation called the "Parameterized Factory Method" but it requires a parameter to tell the Factory Method which type of object
//to return in case a Concrete Creator is compatible with multiple Concrete Products.

//Going back to my example it would be something like FarmZoo and CityZoo.The farm zoo is compatible with Dog, Pig and Sheep.The CityZoo is compatible with Lion, Zebra, Hippo and Giraffe.
//The createAnimal() would now be createAnimal(type).
//That's it.
//So now when Zoo wants to spawn a new Animal you can tell it which type of animal to Spawn. But it won't let you spawn an animal that is not allowed.

//Now about the isolation. The Abstract Factory pattern DOES isolate the creation logic, thus, the clients create the factory and expect the factory to return a desired object to them.In the factory method there  is NO client that consumes a factory expecting an object to be returned. In the factory method pattern the client of the factory method is the Abstract Creator!! The abstract creator is literally the class that "consumes" the factory method implemented by the subclasses.

//In other words, Christopher has created an Abstract Factory in which the Concrete Factories have a single Factory Method.Keep in mind that Abstract Factory can be implemented as a collection of Factory Methods OR as a collection of Prototypes.

//Please, Guys, I hope you understood this because this is a HUGE misunderstanding in the industry and most Juniors think they understand Factory Method but they really don't, they constantly confuse it with Abstract Factory because even smart teachers get it mixed up. 


//I hope this was clear :) If you didn't understand, my advice is to go and read the Design Patterns: Elements of Reusable Object-Oriented Software book.}

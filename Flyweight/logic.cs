using Newtonsoft.Json;
using System.Collections.Generic;
public class Cliente
{
    public void Main()
    {
        // Se crea un objeto inicial que sera el reutilizado en los demas objetos
        BasePizza basePizza = new();
        var factory = new FlyweightFactory(basePizza);
        List<IPizza> pizzas = new();

        //Creamos 100000 objetos del objeto con Flyweight el cual usando las herramientas de diagnostico de Visual Studio vemos que pesa 4.8mb(en mi equipo validalo en el tuyo)
        for (int i = 0; i < 100000; i++)
        {
            var pizza = new PizzaCarnes()
            {
                Jamon = "Se agrego jamon",
                Pepperoni = "Se agrego Pepperoni",
                Salami = "Se agrego Salami",
                basePizza = factory.GetFlyweight(basePizza)
            };
            pizzas.Add(pizza);
        }
        //Imprimimos la respuesta para validar que se genera el mismo resultado en ambos casos
        Console.WriteLine($"Objeto con Flyweight  {pizzas.LastOrDefault().armarPizza()}");
        List<IPizza> pizzas2 = new();

        //Creamos 100000 objetos del objeto sin Flyweight el cual usando las herramientas de diagnostico de Visual Studio vemos que pesa 6.8mb(en mi equipo validalo en el tuyo)
        for (int i = 0; i < 100000; i++)
        {
            var pizza = new PizzaCarnesCompleta()
            {
                Jamon = "Se agrego jamon",
                Pepperoni = "Se agrego Pepperoni",
                Salami = "Se agrego Salami",
                Masa = "Se agrego masa",
                Queso = "Se agrego Queso",
                Salsa = "Se agrego Salsa"
            };
            pizzas2.Add(pizza);
        }
        //Imprimimos la respuesta para validar que se genera el mismo resultado en ambos casos
        Console.WriteLine($"Objeto sin Flyweight  {pizzas2.LastOrDefault()!.armarPizza()}");

        //Debemos tener en cuenta que todos los objetos estan compartiendo el mismo objeto Flyweight si lo modificamos esto se vera reflejado en todos los objetos asociados
        basePizza.Masa = "ups lo cambie";
        Console.WriteLine($"Ojo con los cambios en el objeto Flyweight {pizzas.LastOrDefault()!.armarPizza()}");

        //Podemos agregar mas tipos base gracias a que el manejador de Flyweight si no la encuntra la almacena y luego la usa asi el cliente es agnostico 
        //Como este objeto usa otro tipo de base no se ve afectado por el cambio anterior
        BasePizzaVegetariana basePizzaVeggy = new();
        var pizzaVeggy = new PizzaCarnes()
        {
            Jamon = "Se agrego jamon",
            Pepperoni = "Se agrego Pepperoni",
            Salami = "Se agrego Salami",
            basePizza = factory.GetFlyweight(basePizzaVeggy)
        };
        pizzas.Add(pizzaVeggy);



    }


}
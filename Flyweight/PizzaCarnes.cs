//Se crea un objeto con el principio de Flyweight tiene todo  los comportamientos extrínsecos dentro de si mismo y por ende solo se hara cargo de estos 
//delega los comportamientos intrínsecos a la propieda del tipo Flyweight  
public class PizzaCarnes : IPizza
{
    public string Jamon { get; set; }
    public string Salami { get; set; }
    public string Pepperoni { get; set; }
    //Propiedad Flyweight
    public IBasePizza basePizza { get; set; }

    public string armarPizza()
    {
        return $"{basePizza.ArmarBase()} {Jamon} {Pepperoni} {Salami} , Se armo la pizza Carnes";
    }
}

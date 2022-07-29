using System.Text;
//Se crea un objeto sin el principio de Flyweight tiene todo  los comportamientos  dentro de si mismo y por ende siempre se creara una instancia de su comportamiento 
//tanto el intrínseco como el extrínseco 
public class PizzaCarnesCompleta : IPizza
{
    public string Jamon { get; set; }
    public string Salami { get; set; }
    public string Pepperoni { get; set; }
    public string Masa { get; set; }
    public string Queso { get; set; }
    public string Salsa { get; set; }
    public string ArmarBase()
    {
        StringBuilder armado = new();
        armado.Append(Masa);
        armado.Append(Queso);
        armado.Append(Salsa);
        armado.Append(" ");
        armado.Append(Jamon);
        armado.Append(" ");
        armado.Append(Salami);
        armado.Append(" ");
        armado.Append(Pepperoni);

        return armado.ToString();
    }

    public string armarPizza()
    {
        return $"{ArmarBase()}, Se armo la pizza Carnes";
    }
}

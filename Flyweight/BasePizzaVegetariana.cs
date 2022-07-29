using System.Text;
//Se crea una clase que almacena la parte  que no cambiara(intrinseca) para no crear una instancia por cada objeto sino un unico que se reutilizara en cada objeto
public class BasePizzaVegetariana : IBasePizza, IMasa, ISalsa
{
    public string Tipo { get; } = "Vegetariana";
    public string Masa { get; } = $"Se agrego Masa ";
    public string Salsa { get; } = "Se agrego Salsa";

    public string ArmarBase()
    {
        StringBuilder armado = new();
        armado.Append(Masa);
        armado.Append(Salsa);

        return armado.ToString();
    }
}

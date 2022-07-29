using System.Text;
//Se crea una clase que almacena la parte  que no cambiara(intrinseca)  para no crear una instancia por cada objeto sino un unico que se reutilizara en cada objeto
public class BasePizza : IBasePizza, IMasa, IQueso, ISalsa
{
    public string Tipo { get; } = "Clasica";
    public string Masa { get; set; } = "Se agrego masa ";
    public string Queso { get; } = "Se agrego Queso ";
    public string Salsa { get; } = "Se agrego Salsa ";
    public string ArmarBase()
    {
        StringBuilder armado = new();
        armado.Append(Masa);
        armado.Append(Queso);
        armado.Append(Salsa);

        return armado.ToString();
    }

}

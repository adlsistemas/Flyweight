
//Usamos interfaces para descoplar un poco el codigo
public interface IBasePizza
{
    string Tipo { get; }
    string ArmarBase();
}

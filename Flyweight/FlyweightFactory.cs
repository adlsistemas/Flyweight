
//Se crea una clase que va a ser la que administrara los objetos como peso ligero esta administraa el objeto que requieran las clases que la consuman
//teniendo la unica instancia y regresandola a las clases que la consuma o sino existe la agrega para su administracion
public class FlyweightFactory
{
    private List<IBasePizza> flyweights = new List<IBasePizza>();

    public FlyweightFactory(BasePizza _base)
    {
        flyweights.Add(_base);
    }

    //Si aun no existe la instancia la agrega para ser administrada de lo contraria regresa la 
    public IBasePizza GetFlyweight(IBasePizza estadoCompartido)
    {

        if (flyweights.Where(t => t.Tipo == estadoCompartido.Tipo).Count() == 0)
            flyweights.Add(estadoCompartido);

        return flyweights.FirstOrDefault(t => t.Tipo == estadoCompartido.Tipo)!;
    } 
}

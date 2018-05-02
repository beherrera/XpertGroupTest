using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    using Dominio;

    public class ClasificadorPesebreraService: IClasificadorPesebreraService
    {
        public List<Bovino> FiltrarBovinos(List<Animal> animales)
        {
           return animales.AsEnumerable().OfType<Bovino>().ToList();
        }

        public List<Equino> FiltrarEquinos(List<Animal> animales)
        {
            return animales.AsEnumerable().OfType<Equino>().ToList();
        }
    }
}

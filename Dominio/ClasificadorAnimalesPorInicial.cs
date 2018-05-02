using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    class ClasificadorAnimalesPorInicial: IClasificadorAnimales
    {
        public Animal Clasificar(string nombreAnimal)
        {
            if(nombreAnimal != null && nombreAnimal.StartsWith("B")) return new Bovino(nombreAnimal);
            return new Equino(nombreAnimal);
        }

        public List<Animal> ClasificarEnLote(List<string> nombresAnimales)
        {
          return nombresAnimales.AsEnumerable().Select(this.Clasificar).ToList();
        }

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

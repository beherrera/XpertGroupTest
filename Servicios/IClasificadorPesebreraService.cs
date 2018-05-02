using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    using Dominio;

    interface IClasificadorPesebreraService
    {
        List<Bovino> FiltrarBovinos(List<Animal> animales);

        List<Equino> FiltrarEquinos(List<Animal> animales);
    }
}

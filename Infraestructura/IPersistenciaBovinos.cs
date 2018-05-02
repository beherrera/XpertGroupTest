using System;
using System.Collections.Generic;

namespace Infraestructura
{
    interface IPersistenciaBovinos
    {
        /// <summary>
        /// Objeto que tiene el método de persistencia
        /// </summary>
        IPersistencia Persistencia { get;}

        /// <summary>
        /// Lee bovinos desde persistencia.
        /// </summary>
        /// <returns>
        /// La lista de bovinos <see cref="List"/>.
        /// </returns>
        List<String> leerBovinos();

        /// <summary>
        /// Persiste bovinos.
        /// </summary>
        void escribirBovinos(List<String> lista);
    }
}

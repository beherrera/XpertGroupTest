using System;
using System.Collections.Generic;

namespace Infraestructura
{
    interface IPersistenciaEquinos
    {
        /// <summary>
        /// Objeto que tiene el método de persistencia
        /// </summary>
        IPersistencia Persistencia { get;}

        /// <summary>
        /// Lee equinos.
        /// </summary>
        /// <returns>
        /// Retorna lista de equinos <see cref="List"/>.
        /// </returns>
        List<String> leerEquinos();

        /// <summary>
        /// Persiste equinos.
        /// </summary>
        void escribirEquinos(List<String> lista);
    }
}

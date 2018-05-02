using System;
using System.Collections.Generic;

namespace Infraestructura
{
    public interface IPersistencia
    {
        /// <summary>
        /// Lee la lista de datos.
        /// </summary>
        /// <returns>
        /// Una lista de datos <see cref="List"/>.
        /// </returns>
        List<String> LeerLista();

        /// <summary>
        /// Escribe una lista de datos.
        /// </summary>
        /// <param name="list">
        /// La lista de datos a escribir.
        /// </param>
        void EscribirLista(List<String> list);
    }
}

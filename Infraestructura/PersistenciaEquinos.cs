using System;
using System.Collections.Generic;

namespace Infraestructura
{
    public class PersistenciaEquinos: IPersistenciaEquinos
    {
        public PersistenciaEquinos(IPersistencia persistencia)
        {
            this.Persistencia = persistencia;
        }

        public IPersistencia Persistencia { get; }

        public List<string> leerEquinos()
        {
           return Persistencia.LeerLista();
        }

        public void escribirEquinos(List<String> lista)
        {
            Persistencia.EscribirLista(lista);
        }
    }
}

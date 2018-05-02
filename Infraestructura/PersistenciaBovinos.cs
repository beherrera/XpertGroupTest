using System;
using System.Collections.Generic;

namespace Infraestructura
{
    public class PersistenciaBovinos: IPersistenciaBovinos
    {
        public PersistenciaBovinos(IPersistencia persistencia)
        {
            this.Persistencia = persistencia;
        }

        public IPersistencia Persistencia { get; }

        public List<string> leerBovinos()
        {
           return Persistencia.LeerLista();
        }

        public void escribirBovinos(List<String> lista)
        {
            Persistencia.EscribirLista(lista);
        }
    }
}

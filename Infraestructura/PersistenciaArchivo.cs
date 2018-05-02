using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Infraestructura
{
    class PersistenciaArchivo: IPersistencia
    {
        public string RutaArchivo { get; }

        public PersistenciaArchivo(string rutaArchivo)
        {
            this.RutaArchivo = rutaArchivo;
        }

        public List<string> LeerLista()
        {
           return File.ReadLines(this.RutaArchivo).ToList();
        }

        public void EscribirLista(List<string> list)
        {
            File.WriteAllText(this.RutaArchivo, string.Join("\n", list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColegio.capaNegocio
{
    public class gestionMaterias
    {
        public bool AgregarNuevaMateria(string nombreMateria, string gestion)
        {
            BaseDeDatos db = new BaseDeDatos();
            if (!db.MateriaExiste(nombreMateria))
            {
                return db.AgregarMateria(nombreMateria, gestion);
            }
            else
            {
                return false;
            }
        }

        public bool EditarMateria(int idMateria, string nombreMateria, string gestion)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ActualizarMateria(idMateria, nombreMateria, gestion);
        }

        public bool EliminarMateria(int idMateria)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.EliminarMateria(idMateria);
        }

        public DataTable ObtenerTodasLasMaterias()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ObtenerMaterias();
        }

    }
}

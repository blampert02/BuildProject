using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RTCONSTRUCCIONES.AccesoADatos
{
    public class TipoEmpleado_DAO
    {
        ConstructoraEntities db = new ConstructoraEntities();

        public bool agregar(TipoEmpleado AtipoEmpleado)
        {
            db.TipoEmpleadoes.Add(AtipoEmpleado);
            return db.SaveChanges() > 0 ?  true:false;
        }

        public bool modificar(TipoEmpleado AtipoEmpleado)
        {
            db.Entry(AtipoEmpleado).State = System.Data.EntityState.Modified;
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool eliminar(TipoEmpleado AtipoEmpleado)
        {
            db.TipoEmpleadoes.Remove(AtipoEmpleado);
            return db.SaveChanges() > 0 ? true : false;
        }

        public TipoEmpleado buscar(string ECodigo)
        {
            TipoEmpleado AtipoEmpleado;
            AtipoEmpleado = db.TipoEmpleadoes.DefaultIfEmpty(null).FirstOrDefault(tc => tc.IdTipo.ToString() == ECodigo.ToString());
            return (AtipoEmpleado);
        }

        public List<TipoEmpleado> listar()
        {
            return (db.TipoEmpleadoes.ToList());
        }
    }
}

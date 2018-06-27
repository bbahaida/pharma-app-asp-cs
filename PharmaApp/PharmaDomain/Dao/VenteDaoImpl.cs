using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class VenteDaoImpl : IVenteDao
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentDaoImpl));
        PharmaEntities context = new PharmaEntities();
        public Vente AddVente(Vente v)
        {
            
            try
            {
                context.Ventes.Add(v);
                context.SaveChanges();
                return v;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public Vente DeleteVente(Vente del)
        {
            
            try
            {
                context.Ventes.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public Vente EditVente(Vente v)
        {
            try
            {
                context.Ventes.Attach(v);
                context.Entry(v).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return v;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public IEnumerable<Vente> GetAll()
        {
            return context.Ventes;
        }

        public Vente GetOneVenteById(int id)
        {
            return context.Ventes.FirstOrDefault(e => e.NumVente == id);
        }

        public IEnumerable<Vente> GetVenteByDate(DateTime date)
        {
            return context.Ventes.Where(e => e.DateVente.Equals(date));
        }
    }
}

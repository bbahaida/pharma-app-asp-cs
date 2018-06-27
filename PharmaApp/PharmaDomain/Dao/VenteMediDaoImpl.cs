using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class VenteMediDaoImpl : IVenteMediDao
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentDaoImpl));
        PharmaEntities context = new PharmaEntities();
        public VenteMedi AddVenteMedi(VenteMedi vm)
        {
            try
            {
                context.VenteMedis.Add(vm);
                context.SaveChanges();
                return vm;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public VenteMedi DeleteVenteMedi(VenteMedi del)
        {
            try
            {
                context.VenteMedis.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public VenteMedi EditVenteMedi(VenteMedi vm)
        {
            
            try
            {
                context.VenteMedis.Attach(vm);
                context.Entry(vm).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return vm;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<VenteMedi> GetAll()
        {
            return context.VenteMedis;
        }

        public VenteMedi GetOneVenteMediById(int idv, int idm)
        {
            return context.VenteMedis.FirstOrDefault(e => e.CodeMedicament == idm && e.NumVente == idv);
        }

        public IEnumerable<VenteMedi> GetVenteMediByMedicament(Medicament m)
        {
            return context.VenteMedis.Where(e => e.CodeMedicament == m.CodeMedicament);
        }

        public IEnumerable<VenteMedi> GetVenteMediByVente(Vente v)
        {
            return context.VenteMedis.Where(e => e.NumVente == v.NumVente);
        }
    }
}

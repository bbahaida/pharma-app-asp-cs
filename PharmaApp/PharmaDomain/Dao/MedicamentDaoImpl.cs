using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class MedicamentDaoImpl : IMedicamentDao
    {
        ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentDaoImpl));
        PharmaEntities context = new PharmaEntities();
        public Medicament AddMedicament(Medicament m)
        {
            
            try
            {
                context.Medicaments.Add(m);
                context.SaveChanges();
                return m;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public Medicament DeleteMedicament(Medicament del)
        {
            
            try
            {
                context.Medicaments.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public Medicament EditMedicament(Medicament m)
        {
            
            try
            {
                context.Medicaments.Attach(m);
                context.Entry(m).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return m;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<Medicament> GetAll()
        {
            return context.Medicaments;
        }

        public IEnumerable<Medicament> GetMedicamentByFamille(Famille f)
        {
            return context.Medicaments.Where(e=>e.CodeFamille == f.CodeFamille);
        }
        public IEnumerable<Medicament> GetMedicamentByMC(string mc)
        {
            return context.Medicaments.Where(e => e.LibelleMedicament.ToUpper().StartsWith(mc.ToUpper()));
        }
        public Medicament GetMedicamentByLibelle(string l)
        {
            try
            {
                return context.Medicaments.FirstOrDefault(e => e.LibelleMedicament.Equals(l));
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public Medicament GetOneMedicamentById(int id)
        {
            try
            {
                return context.Medicaments.FirstOrDefault(e => e.CodeMedicament == id);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }
    }
}

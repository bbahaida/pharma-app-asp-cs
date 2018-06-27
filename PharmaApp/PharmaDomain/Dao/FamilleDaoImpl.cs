using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class FamilleDaoImpl : IFamilleDao
    {
        PharmaEntities context = new PharmaEntities();
        ILog logger = Log4NetHelper.GetLogger(typeof(FamilleDaoImpl));
        public Famille AddFamille(Famille f)
        {
            try
            {
                context.Familles.Add(f);
                context.SaveChanges();
                return f;
            }catch(Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public Famille DeleteFamille(Famille del)
        {
            
            try
            {
                context.Familles.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public Famille EditFamille(Famille f)
        {
            
            try
            {
                context.Familles.Attach(f);
                context.Entry(f).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return f;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<Famille> GetAll()
        {
            return context.Familles;
        }

        public IEnumerable<Famille> GetFamilleByMC(string mc)
        {
            return context.Familles.Where(e=>e.Designation.ToUpper().StartsWith(mc.ToUpper()));
        }

        public Famille GetOneFamilleByDesignation(string d)
        {
            try
            {
                return context.Familles.FirstOrDefault(e => e.Designation.ToUpper().Equals(d.ToUpper()));
            }catch(Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public Famille GetOneFamilleById(int id)
        {
            try
            {
                return context.Familles.FirstOrDefault(e => e.CodeFamille == id);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }
    }
}

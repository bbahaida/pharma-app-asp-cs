using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class StockMediDaoImpl : IStockMediDao
    {
        log4net.ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentDaoImpl));
        PharmaEntities context = new PharmaEntities();
        public StockMedi AddStockMedi(StockMedi sm)
        {
            try
            {
                context.StockMedis.Add(sm);
                context.SaveChanges();
                return sm;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public StockMedi DeleteStockMedi(StockMedi del)
        {
            try
            {
                context.StockMedis.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public StockMedi EditStockMedi(StockMedi sm)
        {
            
            try
            {
                context.StockMedis.Attach(sm);
                context.Entry(sm).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return sm;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<StockMedi> GetAll()
        {
            return context.StockMedis;
        }

        public StockMedi GetOneStockMediById(int ids,int idm)
        {
            try
            {
                return context.StockMedis.FirstOrDefault(e => e.CodeMedicament == idm && e.NumStock == ids);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }

        public IEnumerable<StockMedi> GetStockMediByMedicament(Medicament m)
        {
            return context.StockMedis.Where(e => e.CodeMedicament == m.CodeMedicament);
        }

        public IEnumerable<StockMedi> GetStockMediByStock(Stock s)
        {
            return context.StockMedis.Where(e => e.NumStock == s.NumStock);
        }

       
    }
}

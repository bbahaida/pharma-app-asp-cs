using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaDomain.Dao
{
    public class StockDaoImpl : IStockDao
    {
        ILog logger = Log4NetHelper.GetLogger(typeof(MedicamentDaoImpl));
        PharmaEntities context = new PharmaEntities();
        public Stock AddStock(Stock s)
        {
            
            try
            {
                context.Stocks.Add(s);
                context.SaveChanges();
                return s;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public Stock DeleteStock(Stock del)
        {
            
            try
            {
                context.Stocks.Remove(del);
                context.SaveChanges();
                return null;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return del;
            }
        }

        public Stock EditStock(Stock s)
        {
            
            try
            {
                context.Stocks.Attach(s);
                context.Entry(s).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return s;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
        }

        public IEnumerable<Stock> GetAll()
        {
            return context.Stocks;
        }

        public Stock GetOneStockById(int id)
        {
            try
            {
                return context.Stocks.FirstOrDefault(e => e.NumStock == id);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return null;
            }
            
        }
    }
}

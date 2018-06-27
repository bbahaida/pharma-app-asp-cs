using PharmaDomain;
using PharmaDomain.Dao;
using PharmaDomain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaWeb
{
    public class InstanceResolver
    {
        

        private static InstanceResolver _instance;
        private IFamilleService _famille;
        private IMedicamentService _medicament;
        private IStockService _stock;
        private IStockMediService _stockMedi;
        private IVenteService _vente;
        private IVenteMediService _venteMedi;
        private IUserService _user;
        public InstanceResolver()
        {
            _familleDao = new FamilleDaoImpl();
            _medicamentDao = new MedicamentDaoImpl();
            _stockDao = new StockDaoImpl();
            _stockMediDao = new StockMediDaoImpl();
            _venteDao = new VenteDaoImpl();
            _venteMediDao = new VenteMediDaoImpl();
            _userDao = new UserDaoImpl();
        }
        private IFamilleDao _familleDao;
        private IMedicamentDao _medicamentDao;
        private IStockDao _stockDao;
        private IStockMediDao _stockMediDao;
        private IVenteDao _venteDao;
        private IVenteMediDao _venteMediDao;
        private IUserDao _userDao;

        
       
        public static InstanceResolver Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InstanceResolver();
                return _instance;
            }
        }
        public IFamilleService Famille
        {
            get
            {
                if (_famille == null)
                    _famille = new FamilleServiceImpl(_familleDao, _medicamentDao);
                return _famille;
            }
        }
        public IMedicamentService Medicament
        {
            get
            {
                if (_medicament == null)
                    _medicament = new MedicamentServiceImpl(_medicamentDao, _venteMediDao, _stockMediDao);
                return _medicament;
            }
        }
        public IStockService Stock
        {
            get
            {
                if (_stock == null)
                    _stock = new StockServiceImpl(_stockDao, _stockMediDao);
                return _stock;
            }
        }
        public IVenteMediService VenteMedi
        {
            get
            {
                if (_venteMedi == null)
                    _venteMedi = new VenteMediServiceImpl(_venteMediDao, _venteDao, _medicamentDao, _stockMediDao, _stockDao);
                return _venteMedi;
            }
        }
        public IVenteService Vente
        {
            get
            {
                if (_vente == null)
                    _vente = new VenteServiceImpl(_venteDao, _venteMediDao);
                return _vente;
            }
        }
        public IUserService User
        {
            get
            {
                if (_user == null)
                    _user = new UserServiceImpl(_userDao);
                return _user;
            }
        }
        public IStockMediService StockMedi
        {
            get
            {
                if (_stockMedi == null)
                    _stockMedi = new StockMediServiceImpl(_stockMediDao, _stockDao, _medicamentDao);
                return _stockMedi;
            }
        }
    }
}
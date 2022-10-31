using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSln.Service.CarCompanyService
{
    public class CarCompanyService: ICarCompanyService
    {
        private Car_SContext _context;
        public CarCompanyService(Car_SContext context)
        {
            _context = context;
        }
        public List<CarCompany> GetCarCompanyList()
        {
            List<CarCompany> CarCompanyList;
            try
            {
                CarCompanyList = _context.Set<CarCompany>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return (List<CarCompany>)CarCompanyList;
        }
        public CarCompany GetCarCompanyId(int CarCompanyId)
        {
            CarCompany car;
            try
            {
                car = _context.Find<CarCompany>(CarCompanyId);
            }
            catch (Exception)
            {
                throw;
            }
            return car;
        }
        public ResponseModel SaveCarCompany(CarCompanylist CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarCompany _CarList = new CarCompany();
                _CarList.Company = CarListModel.Company;
                _CarList.Notes = CarListModel.Notes;



                _context.Add<CarCompany>(_CarList);


                _context.SaveChanges();
                model.Messsage = "CarList Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel updateCarCompany(CarCompanylist CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarCompany _CarCompany = GetCarCompanyId(CarListModel.CompanyId);
                if (_CarCompany != null)
                {
                    _CarCompany.Company = CarListModel.Company;
                    _CarCompany.Notes = CarListModel.Notes;




                    _context.Update<CarCompany>(_CarCompany);

                    model.Messsage = "CarCompany Update Successfully";
                }
                else
                {
                    _context.Add<CarCompany>(_CarCompany);
                    model.Messsage = "CarCompany Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel DeleteCarCompany(int CarCompanyId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarCompany _CarCompany = GetCarCompanyId(CarCompanyId);
                if (_CarCompany != null)
                {
                    _context.Remove<CarCompany>(_CarCompany);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "CarCompany Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "CarCompany Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }







        public class CarCompanylist
        {
            public int CompanyId { get; set; }
            public string Company { get; set; }
            public string Notes { get; set; }

        }

























    }
}

using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSln.Service.CarInfoService
{
    public class CarInfoService : ICarInfoService
    {
        private Car_SContext _context;
        public CarInfoService(Car_SContext context)
        {
            _context = context;
        }
        public List<CarInfo> GetCarInfoList()
        {
            List<CarInfo> CarInfoList;
            try
            {
                CarInfoList = _context.Set<CarInfo>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return (List<CarInfo>)CarInfoList;
        }
        public CarInfo GetCarInfoById(int CarInfoId)
        {
            CarInfo car;
            try
            {
                car = _context.Find<CarInfo>(CarInfoId);
            }
            catch (Exception)
            {
                throw;
            }
            return car;
        }

        public List<CarInfo> SaveCarInfo(CarList CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarInfo _CarInfo = new CarInfo();
                _CarInfo.Code =CarListModel.Code;
                _CarInfo.ModelId = CarListModel.ModelId;
           
                _CarInfo.Photo = CarListModel.Photo;
                _CarInfo.ChaseNo = CarListModel.ChaseNo;
                _CarInfo.InsuranceId = CarListModel.InsuranceId;
                _CarInfo.MotorsNo = CarListModel.MotorsNo;
                _CarInfo.CapMotors = CarListModel.CapMotors;
          
                _CarInfo.PeriodOfInsurance = CarListModel.PeriodOfInsurance;
                _CarInfo.DateBuy = CarListModel.DateBuy;
                _CarInfo.ColorId= CarListModel.ColorId;
                _CarInfo.DateEndInsurance = CarListModel.DateEndInsurance;
                _CarInfo.LicenseNo = CarListModel.LicenseNo;
                _CarInfo.DateEndLicens = CarListModel.DateEndLicens;
                _CarInfo.CodeGps = CarListModel.CodeGps;
                _CarInfo.LinkGps = CarListModel.LinkGps;
                _CarInfo.Notes = CarListModel.Notes;
                _CarInfo.Status = CarListModel.Status;
                _CarInfo.Bestcar = CarListModel.Bestcar;
                


                _context.Add<CarInfo>(_CarInfo);


                _context.SaveChanges();
                model.Messsage = "EduSubject Inserted Successfully";
                model.IsSuccess = true;

                var items = (List<CarInfo>)
                   (from a in _context.CarInfos where a.CarId == _CarInfo.CarId select a).ToList();

                return items;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return null;
            
        }

        public List<CarInfo> updateCarInfo(CarList CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarInfo _CarInfo = GetCarInfoById(CarListModel.CarId);
                if (_CarInfo != null)
                {

                    _CarInfo.Code = CarListModel.Code;
                    _CarInfo.ModelId = CarListModel.ModelId;
        
                    _CarInfo.Photo = CarListModel.Photo;
                    _CarInfo.ChaseNo = CarListModel.ChaseNo;
                    _CarInfo.InsuranceId = CarListModel.InsuranceId;
                    _CarInfo.MotorsNo = CarListModel.MotorsNo;
                    _CarInfo.CapMotors = CarListModel.CapMotors;
                    
                    _CarInfo.PeriodOfInsurance = CarListModel.PeriodOfInsurance;
                    _CarInfo.DateBuy = CarListModel.DateBuy;
                    _CarInfo.ColorId = CarListModel.ColorId;
                    _CarInfo.DateEndInsurance = CarListModel.DateEndInsurance;
                    _CarInfo.LicenseNo = CarListModel.LicenseNo;
                    _CarInfo.DateEndLicens = CarListModel.DateEndLicens;
                    _CarInfo.CodeGps = CarListModel.CodeGps;
                    _CarInfo.LinkGps = CarListModel.LinkGps;
                    _CarInfo.Notes = CarListModel.Notes;
                    _CarInfo.Status = CarListModel.Status;
                    _CarInfo.Bestcar = CarListModel.Bestcar;

                    _context.Update<CarInfo>(_CarInfo);

                    model.Messsage = "EduSubject Update Successfully";
                }
                else
                {
                    _context.Add<CarInfo>(_CarInfo);
                    model.Messsage = "EduSubject Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
                var items = (List<CarInfo>)
                 (from a in _context.CarInfos where a.CarId == _CarInfo.CarId select a).ToList();

                return items;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return null;
        }

        public ResponseModel DeleteCarInfo(int CarInfoId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarInfo _CarInfo = GetCarInfoById(CarInfoId);
                if (_CarInfo != null)
                {
                    _context.Remove<CarInfo>(_CarInfo);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "CarInfo Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "CarInfo Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }






        public class CarList
        {
            public int CarId { get; set; }
            public string Code { get; set; }
            public int ModelId { get; set; }
            public int? TypeId { get; set; }
            public string Photo { get; set; }
            public string ChaseNo { get; set; }
            public int? InsuranceId { get; set; }
            public int ColorId { get; set; }
            public string MotorsNo { get; set; }
            public string CapMotors { get; set; }
            public int CompanyId { get; set; }
            public DateTime DateBuy { get; set; }
            public string PeriodOfInsurance { get; set; }
            public DateTime? DateEndInsurance { get; set; }
            public string LicenseNo { get; set; }
            public DateTime DateEndLicens { get; set; }
            public string CodeGps { get; set; }
            public string LinkGps { get; set; }
            public string Notes { get; set; }
            public byte Status { get; set; }
            public int? Bestcar { get; set; }
            public virtual CarColor Color { get; set; }
            public virtual CarInsuranceComp Insurance { get; set; }
            public virtual CarModel Model { get; set; }
        
    }







    }
}

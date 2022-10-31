using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSln.Service.CarComponentService
{
    public class CarComponentService : ICarComponentService
    {
        private Car_SContext _context;
        public CarComponentService(Car_SContext context)
        {
            _context = context;
        }


        public List<CarComponent> GetCarComponentList()
        {
            List<CarComponent> CarComponenList;
            try
            {
                CarComponenList = _context.Set<CarComponent>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return (List<CarComponent>)CarComponenList;
        }
        public CarComponent GetCarComponentId(int ComponentId)
        {
            CarComponent car;
            try
            {
                car = _context.Find<CarComponent>(ComponentId);
            }
            catch (Exception)
            {
                throw;
            }
            return car;
        }
        public ResponseModel SaveCarComponent(CarComponentList CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarComponent _CarComponent = new CarComponent();
                _CarComponent.Name = CarListModel.Name;
                _CarComponent.Notes = CarListModel.Notes;
                _CarComponent.Type = CarListModel.Type;



                _context.Add<CarComponent>(_CarComponent);


                _context.SaveChanges();
                model.Messsage = "CarComponent Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel updateCarComponent(CarComponentList CarListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarComponent _CarComponent = GetCarComponentId(CarListModel.ComponentId);
                if (_CarComponent != null)
                {
                    _CarComponent.Name = CarListModel.Name;
                    _CarComponent.Notes = CarListModel.Notes;
                    _CarComponent.Type = CarListModel.Type;



                    _context.Update<CarComponent>(_CarComponent);

                    model.Messsage = "_CarComponent Update Successfully";
                }
                else
                {
                    _context.Add<CarComponent>(_CarComponent);
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

        public ResponseModel DeleteCarComponent(int ComponentId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarComponent _CarComponent = GetCarComponentId(ComponentId);
                if (_CarComponent != null)
                {
                    _context.Remove<CarComponent>(_CarComponent);
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








        public class CarComponentList
        {
            public int ComponentId { get; set; }
            public string Name { get; set; }
            public string Notes { get; set; }
            public byte Type { get; set; }
        }
    }
}

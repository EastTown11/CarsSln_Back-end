using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSln.Service.CarModelsService
{
    public class CarModelsService : ICarModelServices
    {
        private readonly Car_SContext _context;
        public CarModelsService(Car_SContext context)
        {
            _context = context;
        }
        public List<CarModel> GeTAll()
        {
            List<CarModel> models;
            try
            {
                models = _context.Set<CarModel>().ToList(); 
            }
            catch (Exception)
            {

                throw;
            }
            return models;
        }
        public CarModel CarModelByID(int ModelId)
        {
            CarModel model;
            try
            {
                model = _context.Find<CarModel>(ModelId);
            }
            catch (Exception)
            {

                throw;
            }
            return model;

        }

      public List<CarModel>PostModel(ModelsList _models)
       {
            ResponseModel modeleeee = new ResponseModel();
            try
            {
                CarModel carModel = new CarModel();
                carModel.Model = _models.Model;
                carModel.Notes = _models.Notes; 
                _context.Add<CarModel>(carModel);
                _context.SaveChanges();
                modeleeee.Messsage = "Car Model Inserted Successfully";
                modeleeee.IsSuccess = true;

                var items = (List<CarModel>)(from c in _context.CarModels where c.ModelId == carModel.ModelId select c).ToList();
                return items;
            }
            catch (Exception ex)
            {

                modeleeee.IsSuccess = false;
                modeleeee.Messsage = "Error : " + ex.Message;
            }
            return null;
        } 
        public List<CarModel> UpdateModel(ModelsList modelsList)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarModel carModel = CarModelByID(modelsList.ModelId);
                if (carModel is not null)
                {
                    carModel.Model = modelsList.Model;
                    carModel.Notes = modelsList.Notes;
                    _context.Update<CarModel>(carModel);
                    _context.SaveChanges();
                    var items = (List<CarModel>)(from a in _context.CarModels where a.ModelId == carModel.ModelId select a).ToList();
                    model.IsSuccess = true;
                    return items;

                }

            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }


        public ResponseModel DeleteCarModel(int ModelId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarModel carModel = CarModelByID(ModelId);
                if (carModel is not null)
                {
                    _context.Remove<CarModel>(carModel);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Car Model Deleted Successfully";

                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = " Not Found";
                }
            }
            catch (Exception ex)
            {

                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public class ModelsList
        {
            public int ModelId { get; set; }
            public string Model { get; set; }
            public int? TypeId { get; set; }
            public int? CompanyId { get; set; }
            public string Notes { get; set; }

            public virtual CarCompany Company { get; set; }
            public virtual CarType Type { get; set; }
        }

    }
}

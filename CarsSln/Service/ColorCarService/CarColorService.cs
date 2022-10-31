

using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsSln.Service.ColorCarService
{
    public class CarColorService: ICarColorService
    {
        private Car_SContext _context;
        public CarColorService(Car_SContext context)
        {
            _context = context;
        }




        public List<CarColor> GetCarColorList()
        {
            List<CarColor> CarColorList;
            try
            {
                CarColorList = _context.Set<CarColor>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return CarColorList;
        }
        public CarColor GetcolorByid(int colorid)
        {
            CarColor carColor;
            try
            {

                carColor = _context.Find<CarColor>(colorid);
            }
            catch (Exception ex)
            {
                throw;
               
            }
            return carColor;



        }
      

        public List<CarColor> PostColor(ListColor _color)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarColor carColor = new CarColor();
                carColor.Color = _color.Color;
                carColor.Notes = _color.Notes;
                _context.Add<CarColor>(carColor);
                _context.SaveChanges();
                model.Messsage = "CarType Inserted Successfully";
                model.IsSuccess = true;
                var items = (List<CarColor>)(from c in _context.CarColors where c.ColorId == carColor.ColorId select c).ToList();
                return items;

            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return null;
        }
        public List<CarColor> UpdateColor(ListColor _color)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarColor carColor = GetcolorByid(_color.ColorId);
                if (carColor is not null)
                {
                    carColor.Color = _color.Color;
                    carColor.Notes = _color.Notes;
                    _context.Update<CarColor>(carColor);
                    
                    model.Messsage = "Car Color Update Successfully";
                }
                _context.SaveChanges();
                var items = (List<CarColor>)(from a in _context.CarColors where a.ColorId == carColor.ColorId select a).ToList();
                model.IsSuccess = true;

                return items;

            }
            catch (Exception ex)
            {

                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return null;
        }
        public ResponseModel DeleteColor(int colorid)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                CarColor carColor = GetcolorByid(colorid);
                if (carColor is not null )
                {

                    _context.Remove<CarColor>(carColor);
                    _context.SaveChanges(); 
                    model.IsSuccess = true;
                    model.Messsage = "Car Color Deleted Successfully";
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
        public class ListColor
        {
            public int ColorId { get; set; }
            public string Color { get; set; }
            public string Notes { get; set; }

        }


    }
}

using CarsSln.Model;
using CarsSln.Service.CarTypeService;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CarTypeService : ICarTypeService
{
    private readonly Car_SContext _context; 



    public CarTypeService(Car_SContext context)
    {
        _context = context;
    }
    //GetAll
    public List<CarType> GetAll()
    {
        List<CarType> types;
        try
        {
            types = _context.Set<CarType>().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return types;
    }
    //GetTypeByid
    public CarType GetTypeByid(int TypeId)
    {
        CarType type;
        try
        {
            type = _context.CarTypes.Find(TypeId);
        }
        catch (Exception)
        {

            throw;
        }
        return type;
    }
    //PostCarType
    public List<CarType> PostCarType(ListCartype _cartype)
    {
        ResponseModel model = new ResponseModel();
        try
        {
            CarType type = new CarType();
            type.Notes = _cartype.Notes;
            type.Type = _cartype.Type;
            _context.Add<CarType>(type);
            _context.SaveChanges();
            model.Messsage = "CarType Inserted Successfully";
            model.IsSuccess = true;
            var items = (List<CarType>)(from a in _context.CarTypes where a.TypeId == type.TypeId select a).ToList();
            return items;

        }
        catch (Exception ex )
        {
            model.IsSuccess = false;
            model.Messsage = "Error : " + ex.Message;
        }
        return null;
    }
    //Update CarType
    public List<CarType> UpdateCartype(ListCartype _cartype)
    {
        ResponseModel model = new ResponseModel();
        try
        {
            CarType type = GetTypeByid(_cartype.TypeId);
            if (type is not null)
            {
                type.Type = _cartype.Type;
                type.Notes = _cartype.Notes;
                _context.Update<CarType>(type);
                model.Messsage = "Car Type Update Successfully";
                

            }
            _context.SaveChanges();
            var items = (List<CarType>)(from a in _context.CarTypes where a.TypeId == type.TypeId select a).ToList();
            return items;
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
    //Delete Car Type
    public ResponseModel DeleteCarType(int TypeId)
    {
        ResponseModel model = new ResponseModel();
        try
        {
            CarType carType = GetTypeByid(TypeId);
            if (carType is not null )
            {
                _context.Remove<CarType>(carType);
                _context.SaveChanges();
                model.IsSuccess = true;
                model.Messsage = "CarType Deleted Successfully";


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
    public class ListCartype
    {
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
    }
}
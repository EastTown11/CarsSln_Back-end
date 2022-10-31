using CarsSln.Model;
using CarsSln.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarsSln.Service.ColorCarService.CarColorService;

namespace CarsSln.Service.ColorCarService
{
    public interface ICarColorService
    {
        List<CarColor> GetCarColorList();
        CarColor GetcolorByid(int colorid);
        List<CarColor> PostColor(ListColor _color);
        List<CarColor> UpdateColor(ListColor _color);
        ResponseModel DeleteColor(int colorid);







    }
}

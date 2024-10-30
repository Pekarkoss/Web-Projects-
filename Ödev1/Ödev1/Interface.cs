using Microsoft.AspNetCore.Mvc;

namespace Ödev1
{
    public interface IValuesService
    {
        Response<List<Point>> GetAll();
        Response<string> AddPoint(Point point);
        Response<string> RemovePoint(long id);
        Response<Point> GetbyId(long id);
        Response<Point> Update(long id, string newName, double newPointX, double newPointY);
    }                                            
}


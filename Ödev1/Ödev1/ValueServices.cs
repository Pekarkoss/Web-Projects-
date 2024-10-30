namespace Ödev1
{
    namespace Ödev1
    {
        public class ValuesService : IValuesService
        {
            private static List<Point> _points = new List<Point>();
            private long _id = 1;

            public Response<List<Point>> GetAll()
            {
                return new Response<List<Point>>
                {
                    Success = true,
                    Data = _points
                };
            }

            public Response<string> AddPoint(Point point)
            {
                point.Id = _id++;
                _points.Add(point);
                return new Response<string>
                {
                    Success = true,
                    Message = "Point added successfully."
                };
            }

            public Response<string> RemovePoint(long id)
            {
                var point = _points.FirstOrDefault(p => p.Id == id);
                if (point != null)
                {
                    _points.Remove(point);
                    return new Response<string>
                    {
                        Success = true,
                        Message = "Point removed successfully."
                    };
                }
                return new Response<string>
                {
                    Success = false,
                    Message = "Point not found."
                };
            }

            public Response<Point> GetbyId(long id)
            {
                var point = _points.FirstOrDefault(p => p.Id == id);
                if (point != null)
                {
                    return new Response<Point>
                    {
                        Success = true,
                        Data = point
                    };
                }
                return new Response<Point>
                {
                    Success = false,
                    Message = "Point not found."
                };
            }

            public Response<Point> Update(long id, string newName, double newPointX, double newPointY)
            {//point //Point ekle
                //new Response<Point>
                var point = _points.FirstOrDefault(p => p.Id == id);
               
              
                if (point != null)
                {
                    point.Name = newName;
                    point.Pointx = newPointX;
                    point.Pointy = newPointY;
                    return new Response<Point>
                    {
                        Success = true,
                        Data = point
                    };
                }
                return new Response<Point>
                {
                    Success = false,
                    Message = "Point not found."
                };
            }
        }
    }
}

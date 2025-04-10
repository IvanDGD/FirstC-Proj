using System.Text.Json;
using FirstC_Proj.Serialize;
using FirstC_Proj.SOLID;
using FirstC_Proj.SOLID.IInterface;

namespace FirstC_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Task 1
            //AppConfig config = AppConfig.GetInstance();

            //config.SetSetting("Theme", "Dark");
            //config.SetSetting("Language", "Ukrainian");

            //Console.WriteLine(config.GetSetting("Theme"));
            //Console.WriteLine(config.GetSetting("Language"));
            #endregion
            #region Task 2
            //ShapeFactory circleFactory = new CircleFactory();
            //IShape circle = circleFactory.CreateShape();
            //circle.Draw();

            //ShapeFactory rectangleFactory = new RectangleFactory();
            //IShape rectangle = rectangleFactory.CreateShape();
            //rectangle.Draw();
            #endregion
            #region Task 3
            GeoLocation geoLocation = new GeoLocation();
            ICoordinatesService coordinatesService = new GeoLocationAdapter(geoLocation);

            var coordinates = coordinatesService.GetCoordinates();
            Console.WriteLine($"Latitude: {coordinates.Latitude}\nLongitude: {coordinates.Longitude}");
            #endregion
        }
    }
}
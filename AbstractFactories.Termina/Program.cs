using AbstractFactories.Factories;
using AbstractFactories.Factories.Base;
using AbstractFactories.Factories.RoomFactory.Base;
using AbstractFactories.Tools;

namespace AbstractFactories.Termina
{
    internal class Program
    {
        private static IFactory _factory = new RoomCreationFactory(null);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var lines = ReadRoomsTool.ReadRooms("C:\\TempRooms\\rooms.txt");

            List<RoomBase> roomList = new List<RoomBase>();

            if( lines != null && lines.Length > 0 )
            {
                foreach (var item in lines)
                {
                    if( !item.Contains("...")) // todo: add validator definition
                    {// info: will breake on ...
                        try
                        {
                           var room = _factory.Create(item);
                            if( room != null )
                                roomList.Add(_factory.Create(item));
                        }catch(Exception)
                        {
                            Console.WriteLine("Parse error"); //todo: after implementation of validator this will be not needed
                        }
 

                    } else
                    {
                        Console.WriteLine("Nie można stworzyć obiektu dla kodu: {0}",item);
                    }
                }

                foreach (var item in roomList)
                {
                    Console.WriteLine(item.State());
                }
            }

        }
    }
}

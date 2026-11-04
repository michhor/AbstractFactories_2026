using AbstractFactories.Factories.RoomFactory.Base;

namespace AbstractFactories.Factories.Base;

public interface IFactory
{
    //add methods
    RoomBase Create(string input);
    bool Validate(string input);
}
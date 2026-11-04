using AbstractFactories.Factories.Base;
using AbstractFactories.Factories.RoomFactory;
using AbstractFactories.Factories.RoomFactory.Base;
using System.Diagnostics;

namespace AbstractFactories.Factories;

public class RoomCreationFactory: IFactory
{
    private readonly IValidate _validator;

    public RoomCreationFactory(IValidate validator)
    {
        _validator = validator;
    }

    public RoomBase Create(string input)
    {
        //101Wa
        var numberString = input.Substring(0, 3);
        var type = input.Substring(3, 1);
        string addons = null;

        var level = int.Parse(input.Substring(0, 1)) % 5;

        if( input.Length > 4)
        {
            addons = input.Substring(4);
        }
        RoomBase room = null;
        switch(type.ToLower())
        {
            case "L":
                room = new LaboratoryRoom
                {
                    NumberString = numberString,
                    Level = level,
                    Type = type,
                    Addon = addons,
                    DoorIsOpen = false,
                    LightsOn = false,
                    ComputersOn = false
                };
                break;
            default:
                Debug.WriteLine("Fabryka: Brak tego kodu!");
                break;
        }
        return room;
    }

    public bool Validate(string input)
    {
        return _validator.Validate(input);
    }
}
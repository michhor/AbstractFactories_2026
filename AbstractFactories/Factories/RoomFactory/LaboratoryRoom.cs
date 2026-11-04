using AbstractFactories.Factories.RoomFactory.Base;

namespace AbstractFactories.Factories.RoomFactory;

public class LaboratoryRoom: RoomBase
{
    public bool ComputersOn { get; set; }

    public override void Init()
    {
        base.Init();
        ComputersOn = true;
    }

    public override string State()
    {
        return $"{base.State()}\n\r{nameof(ComputersOn)}: {ComputersOn}";
    }

    public override void Open()
    {
        base.Open();
    }

    public override void Close()
    {
        base.Close();
        ComputersOn = false;
    }
}
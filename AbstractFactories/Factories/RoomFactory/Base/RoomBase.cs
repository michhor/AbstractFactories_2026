using System.Text;

namespace AbstractFactories.Factories.RoomFactory.Base;

public abstract class RoomBase
{
    public string NumberString { get; set; }
    public int Level { get; set; }
    public string Type { get; set; } //todo: define and use enum
    public string Addon { get; set; }
    public bool DoorIsOpen { get; set; }
    public bool LightsOn { get; set; }



    public virtual string State()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("NumberString: ").AppendLine(NumberString);
        sb.Append("Level: ").AppendLine(Level.ToString());
        sb.Append("Type: ").AppendLine(Type);
        sb.Append("Addon: ").AppendLine(Addon);
        return sb.ToString();
    }
    public virtual void Init()
    {
        DoorIsOpen = true;
        LightsOn = true;

    }
    public virtual void Open()
    {
        DoorIsOpen = true;
    }
    public virtual void Close()
    {
        DoorIsOpen = false;
        LightsOn = false;
    }

}
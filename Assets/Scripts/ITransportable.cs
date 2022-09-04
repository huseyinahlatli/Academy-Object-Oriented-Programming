public interface ITransportable
{
    public void Transport(string target);
}

public interface IConvertable
{
    public void Convert(bool isClosed);
}

public interface IFlyable
{
    public void Fly(int altitude);
}

public interface IFloatable
{
    public void Swim(int depth);
}
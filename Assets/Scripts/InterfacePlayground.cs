using System.Collections.Generic;
using UnityEngine;

public class InterfacePlayground : MonoBehaviour
{
    private List<ITransportable> _transportables;
    private List<IFlyable> _flyables;
    private List<IConvertable> _convertables;
    private List<IFloatable> _floatables;
    
    private void Start()
    {
        InitializeLists();
        ExecuteLists();
    }

    private void ExecuteLists()
    {
        foreach (var transportable in _transportables)
        {
            transportable.Transport(transportable.GetType() == typeof(IFlyable) ? "Airport" : "Techno Park");
        }

        foreach (var flyable in _flyables)
        {
            flyable.Fly(5000);
        }

        foreach (var convertable in _convertables)
        {
            convertable.Convert(false);
        }

        foreach (var floatable in _floatables)
        {
            floatable.Swim(300);
        }
    }

    private void InitializeLists()
    {
        _transportables = new List<ITransportable>();
        _flyables = new List<IFlyable>();
        _convertables = new List<IConvertable>();
        _floatables = new List<IFloatable>();
    }
}

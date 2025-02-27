using Microsoft.AspNetCore.Components.Web;
using UnitFirst.Landing.Interfaces;

namespace UnitFirst.Landing.Services;

public class MouseService : IMouseService
{
    public event EventHandler<MouseEventArgs>? OnMove;
    public event EventHandler<MouseEventArgs>? OnUp;
    public event EventHandler<MouseEventArgs>? OnLeave;

    public void FireMove(object obj, MouseEventArgs evt)
    {
        OnMove?.Invoke(obj, evt);
    }

    public void FireUp(object obj, MouseEventArgs evt)
    {
        OnUp?.Invoke(obj, evt);
    }

    public void FireLeave(object obj, MouseEventArgs evt)
    {
        OnLeave?.Invoke(obj, evt);
    }
}
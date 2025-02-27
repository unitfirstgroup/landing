using Microsoft.AspNetCore.Components.Web;

namespace UnitFirst.Landing.Interfaces;

public interface IMouseService
{
    event EventHandler<MouseEventArgs>? OnMove;
    event EventHandler<MouseEventArgs>? OnUp;
    event EventHandler<MouseEventArgs>? OnLeave;

    void FireMove(object obj, MouseEventArgs evt);
    void FireUp(object obj, MouseEventArgs evt);
    void FireLeave(object obj, MouseEventArgs evt);
}
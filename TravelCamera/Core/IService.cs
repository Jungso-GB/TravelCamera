//Made by Brio repo
using System;

namespace TravelCamera.Core;

public interface IService : IDisposable
{
    void AssignInstance();
    void ClearInstance();
    void Start();
    void Tick(float delta);
    void Stop();
}

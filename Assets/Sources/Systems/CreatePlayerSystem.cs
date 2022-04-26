using Entitas;
using System.Collections.Generic;

public class CreatePlayerSystem : IInitializeSystem
{
    readonly Contexts _contexts;

    public CreatePlayerSystem(Contexts contexts) {
      _contexts = contexts;
    }

    public void Initialize() {
      var e = _contexts.game.CreateEntity();
      e.AddHealth(100);
    }
}

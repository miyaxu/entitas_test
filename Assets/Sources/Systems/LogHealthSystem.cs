using Entitas;
using System.Collections.Generic;

public class LogHealthSystem : ReactiveSystem<GameEntity>
{
    public LogHealthSystem(Contexts contexts) : base(contexts.game) {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
      return context.CreateCollector(GameMatcher.Health);
    }

    protected override bool Filter(GameEntity entity) {
      return true;
    }

    protected override void Execute(List<GameEntity> entities) {
      foreach(var e in entities) {
        var health = e.health.value;
        UnityEngine.Debug.Log("..........." + health);
      }
    }

    // readonly IGroup<GameEntity> _eneities;

    // public LogHealthSystem(Contexts contexts) {
    //   _eneities = contexts.game.GetGroup(GameMatcher.Health);
    // }

    // public void Execute() {
    //   foreach (var e in _eneities) {
    //     var health = e.health.value;
    //     UnityEngine.Debug.Log(health);
    //   }
    // }
}

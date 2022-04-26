using UnityEngine;

public class GameController : MonoBehaviour
{
    RootSystem _systems;
    void Start()
    {
       var contexts = Contexts.sharedInstance;
       _systems = new RootSystem(contexts);

       _systems.Initialize();
    }

    private void Update() {
       _systems.Execute();
    }
}

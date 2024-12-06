using UnityEngine;
using Entitas;

public class PlayerHealthController : MonoBehaviour
{
    private Systems _systems;

    void Start()
    {
        var contexts = Contexts.sharedInstance;

        _systems = new PlayerHealthFeature(contexts);

        _systems.Initialize();
    }

    void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}

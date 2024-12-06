using Entitas;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _healthEntities;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _healthEntities = contexts.game.GetGroup(GameMatcher.PlayerHealth);
    }

    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (var entity in _healthEntities.GetEntities())
            {
                entity.isPlayerDamaged = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            foreach (var entity in _healthEntities.GetEntities())
            {
                entity.isPlayerHealed = true;
            }
        }
    }
}

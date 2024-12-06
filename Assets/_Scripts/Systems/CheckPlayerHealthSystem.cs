using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _healthEntities;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _healthEntities = contexts.game.GetGroup(GameMatcher.PlayerHealth);
    }

    public void Execute()
    {
        foreach (var entity in _healthEntities.GetEntities())
        {
            if (entity.hasPlayerDamaged)
            {
                entity.ReplacePlayerHealth(Mathf.Max(0, entity.playerHealth.Value - 10));
                entity.RemovePlayerDamaged();
            }

            if (entity.hasPlayerHealed)
            {
                entity.ReplacePlayerHealth(Mathf.Min(100, entity.playerHealth.Value + 10));
                entity.RemovePlayerHealed();
            }
        }
    }
}



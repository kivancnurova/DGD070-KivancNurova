//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameEntity : Entitas.Entity {
public bool hasPlayerDamaged { get { return HasComponent(GameComponentsLookup.PlayerDamaged); } }
public bool hasPlayerHealed { get { return HasComponent(GameComponentsLookup.PlayerHealed); } }
public void RemovePlayerDamaged() { RemoveComponent(GameComponentsLookup.PlayerDamaged); }
public void RemovePlayerHealed() { RemoveComponent(GameComponentsLookup.PlayerHealed); }

}

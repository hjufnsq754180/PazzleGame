using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PazzleInstaller : MonoInstaller
{
    public PazzleList pazzleList;
    public LevelCompleted levelCompleted;
    public GameOver gameOver;
    public PlaceSound placeSound;
    public override void InstallBindings()
    {
        Container.Bind<PazzleList>().FromInstance(pazzleList).AsSingle().NonLazy();
        Container.Bind<LevelCompleted>().FromInstance(levelCompleted).AsSingle().NonLazy();
        Container.Bind<GameOver>().FromInstance(gameOver).AsSingle().NonLazy();
        Container.Bind<PlaceSound>().FromInstance(placeSound).AsSingle().NonLazy();
    }
}
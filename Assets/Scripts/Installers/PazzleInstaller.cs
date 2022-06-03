using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PazzleInstaller : MonoInstaller
{
    public PazzleList pazzleList;
    public LevelCompleted levelCompleted;
    public override void InstallBindings()
    {
        Container.Bind<PazzleList>().FromInstance(pazzleList).AsSingle().NonLazy();
        Container.Bind<LevelCompleted>().FromInstance(levelCompleted).AsSingle().NonLazy();
    }
}
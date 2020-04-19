using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        // here is where we are going to install and bind our objects.
        
        Debug.Log("Installer.InstallBindings()");
    }
}
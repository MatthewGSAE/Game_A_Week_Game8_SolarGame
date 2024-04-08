using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissleTurret() 
    {
        Debug.Log("Missle turret Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
}
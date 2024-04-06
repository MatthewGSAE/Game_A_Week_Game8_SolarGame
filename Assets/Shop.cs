using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("StandardturretSelected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }
    public void PurchaseAnotherTurret()
    {
        Debug.Log("AnotherturretSelected");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}

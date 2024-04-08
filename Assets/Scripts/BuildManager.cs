using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("no instance");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missleLauncherPrefab;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild {  get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {

        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough energy to build");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;


        //build a turret
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret built. Energy left: " + PlayerStats.Money);
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
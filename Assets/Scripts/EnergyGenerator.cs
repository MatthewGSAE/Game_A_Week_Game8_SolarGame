using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyGenerator : MonoBehaviour
{
    public int energyValue = 50;
    public int productionInterval = 6;

    private void Start()
    {
        InvokeRepeating("ProduceEnergy", productionInterval, productionInterval);
    }

    private void ProduceEnergy()
    {
        PlayerStats.Money += energyValue;
    }
}
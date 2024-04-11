using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public WaveSpawner waveSpawner;

    public GameObject tutorialUI;

    private void Start()
    {
        waveSpawner.isTutorialDone = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorialUI.SetActive(false);
            waveSpawner.isTutorialDone = true;
        }
    }
}

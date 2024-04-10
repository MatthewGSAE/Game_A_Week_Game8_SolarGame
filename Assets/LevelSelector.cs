using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public FadeMaster fadeMaster;

    public void Select(string levelName)
    {
        fadeMaster.FadeTo(levelName);
    }
}
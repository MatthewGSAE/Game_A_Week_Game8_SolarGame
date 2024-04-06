using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    private void Start()
    {
        // get the original colour of the node as well as the new colour
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        // a turret is already there
        if (turret != null)
        {
            Debug.Log("Can't Build There");
            return;
        }

        //build a turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    private void OnMouseEnter()
    {
        // make the colour different when hovering over it
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        // colour goes back to normal after mouse leaves the node
        rend.material.color = startColor;
    }
}

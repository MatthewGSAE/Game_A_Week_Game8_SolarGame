using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MainMenuBullet : MonoBehaviour
{

    public float speed;
    // Update is called once per frame

    private void Start()
    {
        Destroy(gameObject, 3f);
    }
    void Update()
    {
        // Move the object forward based on its own local forward direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

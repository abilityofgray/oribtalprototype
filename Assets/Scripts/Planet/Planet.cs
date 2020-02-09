using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public float PlanetSpeed = 6.5f;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * PlanetSpeed * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceStation : MonoBehaviour
{
    public float SpaceStationSpeed = 5.2f;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.up * SpaceStationSpeed * Time.deltaTime);

    }
}

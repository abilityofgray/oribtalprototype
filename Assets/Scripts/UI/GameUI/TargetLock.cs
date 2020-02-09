using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.LookAt(Camera.main.transform);
        //dont work in one update, separate to two Coroutine
        transform.Rotate(Vector3.forward * 9f * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceStationDetail : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody _rigidBody;

    void Start()
    {

        _rigidBody = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {

        
            _rigidBody.isKinematic = false;
            collision.gameObject.transform.parent = null;

        

    }


}

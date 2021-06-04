using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "colorKey") {
            Destroy(gameObject);
        }
    }
}

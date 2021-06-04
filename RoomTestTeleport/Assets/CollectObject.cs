using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    // Update is called once per frame

    //void Update()
    //{
    //    transform.Rotate(90 * Time.deltaTime, 0, 0);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "colorLock")
        {
            Destroy(gameObject);
        }
    }

}

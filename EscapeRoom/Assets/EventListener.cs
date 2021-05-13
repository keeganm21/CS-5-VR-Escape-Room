using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer _renderer;
    private Color originalColor;
    //public Transform theDest;

    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
        //defines the original color of the material
        originalColor = _renderer.material.color;
    }
    public void OnEnter()
    {
    //sets color to white when pointer enters
        _renderer.material.color = Color.white;
    }
    public void OnExit()
    {
    //sets color red once pointer leaves
      _renderer.material.color = originalColor;
    }

    public void OnGrab()
    {
      //GetComponent<MeshCollider>().enabled = false;
      //GetComponent<Rigidbody>().useGravity = false;
      //this.transform.position = theDest.position;
      //this.transform.parent = GameObject.Find("GvrControllerPointer").transform;


      Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
      //leaves in position it was in
      transform.SetParent (pointerTransform, true);
    }

    public void OnRelease()
    {
      //this.transform.parent = null;
      //GetComponent<Rigidbody>().useGravity = true;

      transform.SetParent (null, true);
    }


}


////Sources:
//Setting to original color: https://answers.unity.com/questions/233970/need-materialcolor-to-revert.html
//EventListener overall script: https://www.youtube.com/watch?v=xz5cP2JdxTM

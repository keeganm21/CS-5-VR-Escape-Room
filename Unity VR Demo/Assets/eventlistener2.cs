using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventlistener2 : MonoBehaviour
{
    private Renderer _renderer;
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer> ();
    }

    public void onEnter()
	{
		_renderer.material.color = Color.green;
	}
	
	public void onExit()
	{
		_renderer.material.color = Color.white;
	}
	
	public void onGrab()
	{
		Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
		transform.SetParent(pointerTransform, true);
	}
	
	public void onRelease()
	{
		transform.SetParent (null, true);
	}
}


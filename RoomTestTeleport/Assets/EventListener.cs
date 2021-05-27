using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private Renderer _renderer;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
        originalColor = _renderer.material.color;

    }

    public void OnEnter()
    {
      _renderer.material.color = Color.white;
    }

    public void OnExit()
    {
      _renderer.material.color = originalColor;
    }

    public void OnGrab()
    {
      Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
      transform.SetParent (pointerTransform, true);
    }

    public void OnRelease()
    {
      transform.SetParent (null, true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer _renderer;
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
    }
    public void OnEnter()
    {
        _renderer.material.color = Color.blue;
    }
    public void OnExit()
    {
      _renderer.material.color = Color.red;
    }

}

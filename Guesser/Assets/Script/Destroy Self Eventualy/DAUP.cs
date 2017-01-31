using UnityEngine;
using System.Collections;

public class DAUP : MonoBehaviour {//Destroy After Un-Pause

    public Escape _Escape;

    void Start () {
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();

    }

    void Update()
    {
        if (!_Escape.escaped)
        {
            _Escape.SO = !_Escape.SO;
            Object.Destroy(gameObject);
        }
    }

}
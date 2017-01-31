using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public Running _Running;
    public Escape _Escape;
    public WordSpawner _WordSpawner;

    void Start()
    {
        _Running = GameObject.Find("Main Camera").GetComponent<Running>();
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
        _WordSpawner = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();
    }

    void Update()
    {
        if (!_Escape.escaped)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
            {
                _Running.Started = true;
                Object.Destroy(gameObject);//get rid of start button
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class NotQuit : MonoBehaviour {

    public WordSpawner _WS;
    public Options _Options;
    public camera _camera;
    public Escape _Escape;

    void Start()
    {
        _WS = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();
        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
        _Options = GameObject.Find("Main Camera").GetComponent<Options>();
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
    }
    void OnMouseDown()
    {
        GameObject[] gameObjects1 = GameObject.FindGameObjectsWithTag("Yes");
        foreach (GameObject target in gameObjects1)
        {
            GameObject.Destroy(target);
        }
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag("No");
        foreach (GameObject target in gameObjects2)
        {
            GameObject.Destroy(target);
        }//destroy options
        _camera.RECL = 0;
        _Options.OS = 0;
        _Options.LO = 0;
        _Options.RSTN = 0;
        _Escape.SSO = true;
        _Escape.Quit = false;
    }
}

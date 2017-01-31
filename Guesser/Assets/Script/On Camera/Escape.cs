using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour
{

    public bool escaped = false;
    public bool SO = false; //Spawn Once
    public bool SSO = false; //spawn sprites once
    public WordSpawner _WS;
    public Options _Options;
    public camera _camera;
    public GameObject PauseBackground;
    public GameObject PBC;//PauseBackground Clone

    public bool Quit = false;

    void Start()
    {
        _WS = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();
        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
        _Options = GameObject.Find("Main Camera").GetComponent<Options>();
    }

    void Update()
    {
        if (_camera.RECL == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 0f)
                {
                    escaped = false;
                    Time.timeScale = 1f;
                }
                else
                {
                    escaped = true;
                    Time.timeScale = 0f;
                }
            }
            if (escaped && !SO)
            {
                PBC = Instantiate(PauseBackground, new Vector3(0, 0, 0), transform.rotation) as GameObject;
                SO = true;
            }
            else if (!escaped)
            {
                SO = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Resolution");
                foreach (GameObject target in gameObjects)
                {
                    GameObject.Destroy(target);
                }
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
                SSO = true;
                Quit = false;
            }
        }
    }
}

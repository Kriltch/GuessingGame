using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{
    public RSCS _RSCS;
    public Escape _Escape;
    public int RECL = 0;//Resolution Clicked
    public bool RESP = false;//resolution spawned

    void Start()
    {
        this.gameObject.GetComponent<Camera>().orthographicSize = (720 / 100f / 2.0f);//set size
        Screen.SetResolution(960, 720, true);//set resolution
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
    }
    void Update()
    {
        if (RESP == true && _Escape.escaped == true)
        {
            _RSCS = GameObject.FindWithTag("Resolution").GetComponent<RSCS>();
            if (RECL > 1)
            {
                Debug.Log("clicked2");
                RESP = false;
                switch (RECL)
                {
                    case 2:
                        Debug.Log("clicked3");
                        Screen.SetResolution(800, 600, true);
                        break;
                    case 3:
                        Screen.SetResolution(960, 720, true);//set resolution
                        break;
                    case 4:
                        Screen.SetResolution(1440, 1080, true);//set resolution
                        break;
                }
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

    public Escape _Escape;
    public camera _camera;
    public int EL = 0; //English or Lald
    public OSCS _OSCS;
    public int RSTN = 0;


    public float LO = 0; //Layer Option (for positioning Y)
    public int OS = 0; //Option Select
    public GameObject[] O; //options
    public GameObject OC; //Options Clone

    


    void Start () {
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
    }


    void Update()
    {
        if (_camera.RECL == 0)
        {
            if (_Escape.escaped || _Escape.SSO == true)
            {
                if (OS < 4)
                {
                    OC = Instantiate(O[EL], new Vector3(0, (1.5f - LO), 1f), transform.rotation) as GameObject;
                    OS++;
                    LO++;
                }
            }
            if (!_Escape.escaped)
            {
                _Escape.SSO = false;
                if (OS >= 4)
                {
                    LO = 0;
                    OS = 0;
                    RSTN = 0;
                }
            }
        }

    }
}

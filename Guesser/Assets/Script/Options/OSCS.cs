using UnityEngine;
using System.Collections;

public class OSCS : MonoBehaviour {//Option select C S

    private bool clicked;
    public Options _Options;
    public Escape _Escape;
    private camera _camera;
    public Sprite[] WordSprite;//for animation frames
    private SpriteRenderer SR;
    private int WO; //Which One was spawned

    public float LR; //Layer Resolution
    public int RS; //ResolutionSelection
    public GameObject RE; //Resolution
    public GameObject RC; //ResolutionEnglishClone

    public float LQ;// layer quit
    public int QS;//quit selection
    public GameObject QY;//quit yes
    public GameObject QN;//quit no
    public GameObject QC;//quit clone
    

    

    void Start()
    {
        _Options = GameObject.Find("Main Camera").GetComponent<Options>();
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
        SR = GetComponent<SpriteRenderer>();
        SR.sprite = WordSprite[(_Options.OS-1)];
        switch (_Options.OS)
        {
            case 1:
                WO = 1;
                break;
            case 2:
                WO = 2;
                break;
            case 3:
                WO = 3;
                break;
            case 4:
                WO = 4;
                break;
        }
    }

    void Update()
    {
        if (clicked)
        {
            switch (WO)
            {
                case 1:
                    clicked = false;
                    for (RS = 0; RS < 3; RS++)
                    {
                        RC = Instantiate(RE, new Vector3(0, (1.5f - LR), 1f), transform.rotation) as GameObject;
                        LR++;
                        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
                        _camera.RESP = true;
                        _camera.RECL = 1;
                    } 
                    
                    if (RS >= 3)
                    {
                        GameObject[] gameObjects5 = GameObject.FindGameObjectsWithTag("Option");
                        foreach (GameObject target in gameObjects5)
                        {
                            GameObject.Destroy(target);
                        }
                    }
                    break;
                case 2:
                    clicked = false;

                    //destroy self and others with tag "option"
                    Debug.Log("Key Binding");
                    break;
                case 3:
                    clicked = false;
                    if (_Options.EL == 0)
                    {
                        _Options.EL = 1;
                    }
                    else if (_Options.EL == 1)
                    {
                        _Options.EL = 0;
                    }
                    GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Option");
                    foreach (GameObject target in gameObjects)
                    {
                        GameObject.Destroy(target);
                    }
                    _camera.RECL = 0;
                    _Options.OS = 0;
                    _Options.LO = 0;
                    _Options.RSTN = 0;
                    _Escape.SSO = true;
                    break;
                case 4:
                    clicked = false;
                    QC = Instantiate(QY, new Vector3((-.5f + LQ), -1f, 1f), transform.rotation) as GameObject;
                    LQ = +1;
                    QC = Instantiate(QN, new Vector3((-.5f + LQ), -1f, 1f), transform.rotation) as GameObject;
                    _camera = GameObject.Find("Main Camera").GetComponent<camera>();
                    _camera.RESP = true;
                    _camera.RECL = 1;
                    GameObject[] gameObjects4 = GameObject.FindGameObjectsWithTag("Option");
                    foreach (GameObject target in gameObjects4)
                    {
                        GameObject.Destroy(target);
                    }
                    _Escape.Quit = true;
                    break;
            }
        }
    }

    void OnMouseDown()
    {
        clicked = true;
    }
}

using UnityEngine;
using System.Collections;

public class RSCS : MonoBehaviour {//Resolutino Select C S

    public Options _Options;
    public camera _camera;
    public Sprite[] WordSprite;//for animation frames
    private SpriteRenderer SR;
    private int RO = 0; //Resolution Option
    private bool clicked;
    


    void Start () {
        _camera = GameObject.Find("Main Camera").GetComponent<camera>();
        _Options = GameObject.Find("Main Camera").GetComponent<Options>();
        SR = GetComponent<SpriteRenderer>();
        _Options.RSTN += 1;
        SR.sprite = WordSprite[(_Options.RSTN - 1)];
        switch (_Options.RSTN)
        {
            case 1:
                RO = 1;
                break;
            case 2:
                RO = 2;
                break;
            case 3:
                RO = 3;
                break;
        }
    }
	
	void Update () {
        if (clicked)
        {
            switch (RO)
            {
                case 1:
                    _camera.RESP = true;
                    _camera.RECL = 2;                   
                    clicked = false;
                    Debug.Log("clicked1");
                    break;
                case 2:
                    _camera.RESP = true;
                    _camera.RECL = 3;                   
                    clicked = false;
                    break;
                case 3:
                    _camera.RESP = true;
                    _camera.RECL = 4;
                    clicked = false;
                    break;
            }
        }
    }

    void OnMouseDown()
    {
        clicked = true;
    }
}

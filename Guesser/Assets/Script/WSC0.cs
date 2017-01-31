using UnityEngine;
using System.Collections;

public class WSC0 : MonoBehaviour {

    //word sprite choser 0
    public WordSpawner _Spawner;//get spawner script
    public Sprite[] WordSprite;//for animation frames
    private SpriteRenderer SR;

    void Start()
    {
        _Spawner = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();//get RNGR
        SR = GetComponent<SpriteRenderer>();
        SR.sprite = WordSprite[_Spawner.RNGW];//change to random sprite
    }
}


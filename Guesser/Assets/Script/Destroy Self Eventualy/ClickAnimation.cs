using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour {

    public Sprite[] WordSprite;//for animation frames
    private SpriteRenderer SR;
    public WordSpawner _WS;
    public Animation Anim;

    void Start() {
        SR = GetComponent<SpriteRenderer>();
        _WS = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();
        Anim = GetComponent<Animation>();
    }

    void Update()
    {
        /*if (_WS.AP == true)
        {*/
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Anim.Stop();
            //Anim.Stop("BilAnimation");
            //Anim.Play("BilAnimation");
            SR.sprite = WordSprite[3];
        }
        /*}*/
        /*else
        {
            //gameObject.GetComponent<Animation>().Stop();
            SR.sprite = WordSprite[14];
        }*/
    }
    public void AnimateReln()
    {
    
    }
}

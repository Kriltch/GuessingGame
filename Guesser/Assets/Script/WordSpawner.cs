using UnityEngine;
using System.Collections;

public class WordSpawner : MonoBehaviour {

    public Running _Running;//only do things when game is started
    public Escape _Escape;
    public Transform[] WordsSpawn;//where to spawn the words
    public GameObject[] WordsPrefab;//getting prefab
    public GameObject WordsClone;//spawned word

    public GameObject Wrong;
    public GameObject WrongClone;
    public GameObject Letter;
    public GameObject LetterClone;
    public GameObject Late;
    public GameObject LateClone;
    public GameObject Right;
    public GameObject RightClone;

    public int RNGR; //randomNumGenReln
    public int RNGW; //randomNumGenWord
    public int EnterNumber;
    public int Score;
    public float Times;//10 second timer for input
    public bool Spawn = false;
    public bool Pressed = false;//stop people from spamming buttons
    public bool timerStop = false;//stop timer from continuing when choice is chosen
    public bool AP = false;

    void Start()
    {
        _Running = GameObject.Find("Main Camera").GetComponent<Running>();
        _Escape = GameObject.Find("Main Camera").GetComponent<Escape>();
    }
    void Update()
    {
        if (_Running.Started && !_Escape.escaped)
        {
            if (!Spawn)
            {
                RNGR = Random.Range(0, 5);
                RNGW = Random.Range(0, 30);
                WordsClone = Instantiate(WordsPrefab[RNGR], WordsSpawn[0].transform.position, transform.rotation) as GameObject;
                timerStop = false;
                StartCoroutine(Timer());
                Spawn = true;
            }

            ButtonPress();
            if (Times == 10)
            {
                Pressed = true;
                Score -= 100;
                timerStop = true;
                Times = 0;
                LateClone = Instantiate(Late, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
            }
        }
    }

    public void ButtonPress()
    {
        
        if (Input.GetKeyDown(KeyCode.Q) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 1;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 0;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 5;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 2;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 3;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                //display "wrong" in Kald
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) && Pressed == false)
        {
            Pressed = true;
            EnterNumber = 4;
            if (EnterNumber != RNGR && Times < 10)
            {
                Score -= 300;
                WrongClone = Instantiate(Wrong, new Vector2(0, -0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times < 1)
            {
                Score += 500;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times >= 1 && Times <= 3)
            {
                Score += 100;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
            else if (EnterNumber == RNGR && Times > 3 && Times <= 5)
            {
                Score += 50;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;

            }
            else if (EnterNumber == RNGR && Times > 5 && Times < 10)
            {
                Score += 10;
                RightClone = Instantiate(Right, new Vector2(0, 0.75f), transform.rotation) as GameObject;
                Destroy(WordsClone, 1);
                StartCoroutine(Respawn());
                timerStop = true;
                StopCoroutine(Timer());
                Times = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
        }
        else if (Input.anyKeyDown && Times > 1f && Pressed == false)// wrong key is pressed
        {
            Score -= 300;
            Pressed = true;
            StartCoroutine(WrongLetter());
            LetterClone = Instantiate(Letter, new Vector2(0.3f, -0.75f), transform.rotation) as GameObject;
            WrongClone = Instantiate(Wrong, new Vector2(-0.3f, -0.75f), transform.rotation) as GameObject;
        }
    }

    public IEnumerator WrongLetter()
    {
        yield return new WaitForSeconds(2f);
        Pressed = false;
    }

    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2f);
        Spawn = false;
        Pressed = false;
        timerStop = true;
        Times = 0;
        StopCoroutine(Respawn());
    }

    public IEnumerator Timer()
    {
        /*while (_Escape.escaped)
        {
            yield return null;
        }*/
        while (Times < 10 && !timerStop /*&& !_Escape.escaped*/)
        {
            yield return new WaitForSeconds(1f);
            Times++;
        }
        if (Times >= 10)
        {
            timerStop = true;
            StopCoroutine(Timer());
        }
    }
}

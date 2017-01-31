using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public WordSpawner _Spawner;
    public Running _Runn;
    public Text scoreText;  // public if you want to drag your text object in there manually
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        _Spawner = GameObject.Find("WordSpawner").GetComponent<WordSpawner>();
        _Runn = GameObject.Find("Main Camera").GetComponent<Running>();
        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
    }

    void Update()
    {
        if (_Runn.Started)
        {
            scoreText.text = "Score: " + _Spawner.Score.ToString();  // make it a string to output to the Text object
        }
        else if (!_Runn.Started)
        {
            scoreText.text = " ";
        }
    }
}

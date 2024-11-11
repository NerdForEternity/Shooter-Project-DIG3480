using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    public TMP_Text lives;
    public GameObject Player;
    private Player lifeValue;
    private string lifeCount;
    // Start is called before the first frame update
    void Start()
    {
        lifeValue = Player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        lifeCount = "Lives: " + lifeValue.lives;
        // this stupid "lifeValue.lives" bit is whats breaking everything, I have absolutely no idea how to reference a variable in another script but this was my best attempt.
        // You'll need the Unity Documentation, but also the TextMeshPro Documentation to get it to actually display in Unity
        lives.text = lifeCount;
    }
}

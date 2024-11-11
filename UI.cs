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
       
        lives.text = lifeCount;
    }
}

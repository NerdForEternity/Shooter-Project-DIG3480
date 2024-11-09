using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int timer = 120;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;

        if(timer == 0)
        {
            Destroy(this.gameObject);
        }
    }
}

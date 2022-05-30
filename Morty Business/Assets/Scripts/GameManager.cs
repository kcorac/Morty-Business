using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int coffinsCount = 2;
    public bool gameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coffinsCount == 0)
        {
            gameWon = true;
        }
        if (gameWon == true)
        {
            SceneManager.LoadScene("Winning Screen");
        }
    }
}

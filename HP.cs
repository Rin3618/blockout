using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{

    public GameObject LostMenu;


    static public int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        LostMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (hp == 0)
        {
            Lost();
        }

    }

    void Lost()
    {
        LostMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GoToResult()
    {
        SceneManager.LoadScene("Result");
    }
}

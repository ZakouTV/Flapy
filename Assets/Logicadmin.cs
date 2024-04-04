using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logicadmin : MonoBehaviour
{
    public int score;
    public Text test;
    public GameObject scene;
    [ContextMenu("increase level")]
    public void levels(int numberofscore)
    {
        score = score + numberofscore;
        test.text = score.ToString();
    }
    public void restartfunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void newscene()
    {
        scene.SetActive(true);
    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectior : MonoBehaviour
{
    public string level;
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = level;
    }

    public void OpenScene()
    {
        SceneManager.LoadScene(level);
    }
}

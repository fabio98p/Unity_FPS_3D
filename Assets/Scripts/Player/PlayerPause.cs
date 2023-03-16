using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerPause : MonoBehaviour
{
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.onFoot.Exit.triggered)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void OpenScene()
    {
        SceneManager.LoadScene("Menu");
    }
}

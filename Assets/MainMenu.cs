using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    // Update is called once per frame  
    void Update()
    {
        //  if (Input.GetKey ("escape")) {
            //   Debug.Log("Quit");
                //  Application.Quit();
        // }
    }
}

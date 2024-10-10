using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void openRules(){
        SceneManager.LoadScene("RulesScreen");
    }

    public void openControls(){
        SceneManager.LoadScene("ControlsScreen");
    }

    public void quitGame(){
        Application.Quit();
    }

   /* // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}

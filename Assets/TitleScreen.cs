using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    public void openRules(){
        SceneManager.LoadScene("Assets/Scenes/RulesScreen.unity");
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

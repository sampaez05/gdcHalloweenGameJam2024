using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDialogue : MonoBehaviour
{
   public void openDialogue1(){
        SceneManager.LoadScene("Dialogue1");
    }

    public void openDialogue2(){
        SceneManager.LoadScene("Dialogue2");
    }

    public void openDialogue3(){
        SceneManager.LoadScene("Dialogue3");
    }

    public void openDialogue4(){
        SceneManager.LoadScene("Dialogue4");
    }
}

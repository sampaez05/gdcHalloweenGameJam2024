using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CandySelectionScreen : MonoBehaviour
{
    public int selectedCandy = 0;
    [SerializeField] public selectedCandies selectedCandies;

   public void selectMnMs(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "M&Ms";
            selectedCandy++;
        }
    }
    public void selectSourPatchKids(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Sour Patch Kids";
            selectedCandy++;
        }
    }
    public void selectSwish(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Swedish Fish";
            selectedCandy++;
        }
    }
    public void selectMilkyWay(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Milky Way";
            selectedCandy++;
        }
    }
    public void selectReeses(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Reese's Peanut Butter Cup";
            selectedCandy++;
        }
    }
    public void selectHershey(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Hershey";
            selectedCandy++;
        }
    }
    public void selectNerds(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Nerds";
            selectedCandy++;
        }
    }
    public void selectSkittles(){
        if (selectedCandy<3){
            selectedCandies.favCandies[selectedCandy] = "Skittles";
            selectedCandy++;
        }
    }

    public void startGameButton(){
        SceneManager.LoadScene("Street_1");
    }
    
}

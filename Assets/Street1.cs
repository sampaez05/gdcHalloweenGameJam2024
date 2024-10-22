using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Street1 : MonoBehaviour
{
    [SerializeField] public collectedCandies recievedCandies;

    public void openHouse1(){
        SceneManager.LoadScene("Dialogue1");
    }
}

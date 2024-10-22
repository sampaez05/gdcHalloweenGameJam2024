using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] public collectedCandies recievedCandies;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator animator;

    private Queue<string> sentences;

    private float textSpeed = .15f;
    private int index = 0;

    // Start is called before the first frame update
    void Start() {
        sentences = new Queue <string>();
    }

    public void StartDialogue (Dialogue dialogue) {
        Debug.Log(sentences.Count);
        animator.SetBool("IsOpen",true);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        Debug.Log(sentences.Count);
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }
        else {
            string nextSentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(nextSentence));
        }
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void EndDialogue() {
        SceneManager.LoadScene("Street_1");
        animator.SetBool("IsOpen",false);
        Debug.Log("End of Conversation");
        recievedCandies.addCandies();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    //thx to Brackey's yt tutorial for the dialogue scripts
    private Queue<string> sentences;

    public GameObject dialogueBox;
    public Text talk;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        dialogueBox.SetActive(true);

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    //clicking to continue dialogue
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayNextTalk();
        }
    }
    public void DisplayNextTalk()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeTalk(sentence));

    }

    IEnumerator TypeTalk(string sentence)
    {
        talk.text = "";
        foreach  (char letter in sentence.ToCharArray())
        {
            talk.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }


}

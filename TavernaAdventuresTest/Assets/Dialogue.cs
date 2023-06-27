using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI text;
    public string[] lines;
    public float textSpeed;
    public TextMeshProUGUI enter;
    public GameObject player;
    public GameObject dialogueTrigger;
    public bool reactivated;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        text.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("return")) {
            if(text.text == lines[index]) {
                NextLine();
            } else {
                StopAllCoroutines();
                text.text = lines[index];
            }
        }
        if(reactivated){
            UnityEngine.Debug.Log(text.text);
            NextLine();
            UnityEngine.Debug.Log(text.text);
        }  
        reactivated = dialogueTrigger.activeSelf;
        
    }

    void StartDialogue() {
        index = 0;
        StartCoroutine(TypeLine());
    } 

    IEnumerator TypeLine() {
        enter.enabled = false;
        foreach(char c in lines[index].ToCharArray()) {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        enter.enabled = true;
    }

    void NextLine() {
        if(index < 5) {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else if (index < 9 && player.GetComponent<QuestVariables>().firstKey == true) {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else if (index < 13 && player.GetComponent<QuestVariables>().secondKey == true) {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else if (index < 14 && player.GetComponent<QuestVariables>().done == true) {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            gameObject.SetActive(false);
            UnityEngine.Debug.Log(text.text);
        }
    }
}

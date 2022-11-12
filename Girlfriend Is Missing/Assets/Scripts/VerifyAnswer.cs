using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class VerifyAnswer : MonoBehaviour
{
    [SerializeField]
    private Text answer;
    [SerializeField]
    private RectTransform dialogueSystem;
    [SerializeField]
    private Text infos;

    private string tryAgain = "Try Again";

    public void CheckTypedAnswer (){
        if (answer.text == "LOVE" || answer.text == "love" || answer.text == "Love") {
            SceneManager.LoadScene(1);
        }
        else{
            answer.text = "";
            Debug.Log("Lose");
            StartCoroutine(FadeText());
        }
    }

    IEnumerator FadeText()
    {
        infos.text = tryAgain;
        infos.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        infos.gameObject.SetActive(false);
        dialogueSystem.gameObject.SetActive(false);
    }
}

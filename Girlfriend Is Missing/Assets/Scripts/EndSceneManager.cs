using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField]
    private Text textDialogue;
    [SerializeField]
    private Button closeGame;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeTexts());
    }

    IEnumerator FadeTexts()
    {
        yield return new WaitForSeconds(3);
        textDialogue.text = "You found me";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "I knew you could solve it";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "There were thieves here";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "I hid under the bed";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "In the secret passage";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "They must be gone";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        textDialogue.text = "We are saved now";
        textDialogue.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        textDialogue.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        closeGame.gameObject.SetActive(true);
    }
}

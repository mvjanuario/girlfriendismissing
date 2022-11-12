using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionColorChange : MonoBehaviour
{
    private bool trigged = false;
    private Renderer renderer;
    private Color standard;

    [SerializeField]
    private Text infos;
    [SerializeField]
    private string info;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trigged = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trigged = false;
        }
    }

    void Start() {
        renderer = gameObject.GetComponent<Renderer>();
        standard = renderer.material.color;
    }

    void Update()
    {
        VerifyTrigged();
    }

    private void VerifyTrigged() {
        if (trigged)
        {
            renderer.material.color = new Color(1, 0, 0, 1);

            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(FadeText());
            }

        }
        else
        {
            renderer.material.color = standard;
        }
    }

    IEnumerator FadeText() {
        infos.text = info;
        infos.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        infos.gameObject.SetActive(false);
    }
}
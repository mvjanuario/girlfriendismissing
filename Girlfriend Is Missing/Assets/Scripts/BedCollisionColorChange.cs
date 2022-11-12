using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedCollisionColorChange : MonoBehaviour
{
    private bool trigged = false;
    private Renderer renderer;
    private Color standard;

    [SerializeField]
    private RectTransform dialogueSystem;
    [SerializeField]
    private Text infos;

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
            infos.gameObject.SetActive(false);
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
                dialogueSystem.gameObject.SetActive(true);
            }

        }
        else
        {
            renderer.material.color = standard;
            dialogueSystem.gameObject.SetActive(false);
        }
    }
}
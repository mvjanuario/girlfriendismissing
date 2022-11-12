using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionColorChange : MonoBehaviour
{
    private bool trigged = false;
    private Renderer renderer;
    private Color standard;

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
        if (trigged) {
            renderer.material.color = new Color(1, 0, 0, 1);

            if(Input.GetKeyDown(KeyCode.E)) {
                Debug.Log("Teste");
            }

        } else {
            renderer.material.color = standard;
        }
    }

    void Blink() {
    }
}
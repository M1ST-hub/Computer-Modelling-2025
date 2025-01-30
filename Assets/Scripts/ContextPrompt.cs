using TMPro;
using UnityEngine;

public class ContextPrompt : MonoBehaviour
{
    public GameObject prompt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prompt.SetActive(false);
        }
    }

}

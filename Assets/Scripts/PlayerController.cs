using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject settings;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settings.SetActive(true);
        }
    }
}

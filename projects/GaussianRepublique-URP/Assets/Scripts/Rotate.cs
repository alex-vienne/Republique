using UnityEngine;

public class Rotate : MonoBehaviour
{

    private float angle = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        angle = Random.Range(0.1f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up, angle );
    
    }
}

using UnityEngine;

public class movement_slow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xRotation = transform.eulerAngles.x;
        if (Mathf.Approximately(transform.eulerAngles.x, 0f))
        {
            transform.Translate(Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f), Random.Range(-0.01f, 0.01f), Space.World);
            transform.Rotate(0, Random.Range(-10f, 10f), 0);
            return;
        }

        else
        {
            transform.Translate(Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f), Random.Range(-0.01f, 0.01f), Space.World);
            transform.Rotate(0, Random.Range(-10f, 10f), 0);
            return;
        }
    }
}

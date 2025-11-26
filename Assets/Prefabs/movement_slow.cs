using UnityEngine;
using System.Threading.Tasks; // Required for Task

public class movement_slow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        doTask();
    }

    // Update is called once per frame
    async void doTask()
    {
        float xRotation = transform.eulerAngles.x;
        if (Mathf.Approximately(transform.eulerAngles.x, 0f))
        {
            float xOr = Random.Range(-0.0025f, 0.0025f);
            float yOr = Random.Range(-0.0015f, 0.0015f);
            float zOr = Random.Range(-0.0025f, 0.0025f);
            for (int i = 0; i < Random.Range(100, 500); i++)
            {
                transform.Translate(xOr, yOr, zOr, Space.World);
                transform.Rotate(0, Random.Range(-20, 20f), 0);
                await Task.Delay(50);
            }
            doTask();
        }

        else
        {
            float xOr = Random.Range(-0.0015f, 0.0015f);
            float yOr = Random.Range(-0.0025f, 0.0025f);
            float zOr = Random.Range(-0.0025f, 0.0025f);
            for (int i = 0; i < Random.Range(100, 500); i++)
            {
                transform.Translate(xOr, yOr, zOr, Space.World);
                transform.Rotate(0, Random.Range(-20, 20f), 0);
                await Task.Delay(50);
            }
            doTask();
        }
    }
}

using UnityEngine;

public class Tic : MonoBehaviour
{
    public float maxTime;
    private float currentTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        transform.rotation = Quaternion.Euler(0f, 0f, currentTime / maxTime);

        if (currentTime > maxTime)
        {
            Destroy(gameObject);
        }
    }
}

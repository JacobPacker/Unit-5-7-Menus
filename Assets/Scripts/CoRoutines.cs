using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutines : MonoBehaviour
{
    public Renderer engineBodyRenderer;
    public float speed;
    public Color startColor, endColor;
    float startTime;
    private Rigidbody rb;
    int i;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startTime = Time.time;
        FadeToGreen();
        StartCoroutine(ExampleCoroutine()); // start the ExampleCoroutine()
        StartCoroutine(FadeToGreen());
    }

    IEnumerator ExampleCoroutine()
    {
        
        for (i = 0; i < 5; i++)
        {
            Debug.Log("Do something");
            rb.velocity = new Vector3(10.0f, 0.0f, 0.0f);
            yield return new WaitForSeconds(0.5f);

            Debug.Log("Do something else");
            rb.velocity = new Vector3(-10.0f, 0.0f, 0.0f);
            yield return new WaitForSeconds(0.5f);
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
    IEnumerator FadeToGreen()
    {
        float tick = 0f;
        while (engineBodyRenderer.material.color != endColor)
        {
            tick += Time.deltaTime * speed;
            engineBodyRenderer.material.color = Color.Lerp(startColor, endColor, tick);
            yield return null;
        }
        /*for (a = 1f; a >= fadeToGreenAmount; a -= 0.05f)
        {
            Color c = sr.material.color;
            c.r = i;
            c.g = i;
            sr.material.color = c;
            yield return new WaitForSeconds(fadingSpeed);
        }*/
    }
}

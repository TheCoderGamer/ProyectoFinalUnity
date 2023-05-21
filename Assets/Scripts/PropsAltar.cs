using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PropsAltar : MonoBehaviour
{
    public List<SpriteRenderer> runes;
    public float lerpSpeed;

    private Color curColor;
    private Color targetColor;

    RainScript2D rain;


    private void Start()
    {
        rain = GameObject.FindGameObjectWithTag("Rain").GetComponent<RainScript2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        targetColor = new Color(1, 1, 1, 1);
        rain.RainIntensity = 1f;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targetColor = new Color(1, 1, 1, 0);
        rain.RainIntensity = 0.2f;
    }

    private void Update()
    {
        curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

        foreach (var r in runes)
        {
            r.color = curColor;
        }
    }
}

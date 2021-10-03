using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
    private SpriteRenderer _ballSprite;
    public string ballColor;

    [SerializeField]
    private Sprite[] spriteArray;
    
    void Start()
    {
        _ballSprite = GetComponent<SpriteRenderer>();

    }

    public void colorChange()
    {
        colorChoose();

        switch (ballColor)
        {
            case "purple":
                _ballSprite.sprite = spriteArray[0];
                break;

            case "green":
                _ballSprite.sprite = spriteArray[1];
                break;

            case "yellow":
                _ballSprite.sprite = spriteArray[2];
                break;

            case "red":
                _ballSprite.sprite = spriteArray[3];
                break;
        }
    }

    private void colorChoose()
    {
        float randomValue = Random.Range(0, 4);

        if (randomValue >= 0 && randomValue < 1)
        {
            if (ballColor != "purple")
            ballColor = "purple";
            else
                colorChoose();
        }

        if (randomValue >= 1 && randomValue < 2)
        {
            if (ballColor != "green")
                ballColor = "green";
            else
                colorChoose();
        }

        if (randomValue >= 2 && randomValue < 3)
        {
            if (ballColor != "yellow")
                ballColor = "yellow";
            else
                colorChoose();
        }

        if (randomValue >= 3 && randomValue < 4)
        {
            if (ballColor != "red")
                ballColor = "red";
            else
                colorChoose();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (ballColor)
        {
            case "purple":
                if (other.CompareTag("purple") || other.CompareTag("colourBall"))
                {
                    Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.GetComponent<Collider2D>());
                }
                else Destroy(gameObject);
                break;

            case "green":
                if (other.CompareTag("green") || other.CompareTag("colourBall"))
                {
                    Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.GetComponent<Collider2D>());
                }
                else Destroy(gameObject);
                break;

            case "yellow":
                if (other.CompareTag("yellow") || other.CompareTag("colourBall"))
                {
                    Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.GetComponent<Collider2D>());
                }
                else Destroy(gameObject);
                break;

            case "red":
                if (other.CompareTag("red") || other.CompareTag("colourBall"))
                {
                    Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), other.GetComponent<Collider2D>());
                }
                else Destroy(gameObject); ;
                break;
        }

        
    }
}
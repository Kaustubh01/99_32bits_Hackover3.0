using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int newSortingOrder = 1;
    public bool isClickable = false;
    public Spawner spawner;
    public GameManager gameManager;


    private void Awake()
    {
        spawner = FindObjectOfType<Spawner>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseEnter()
    {
        transform.localScale = new Vector3(2f, 2f, 0f);

        isClickable = true;

    }
    private void OnMouseExit()
    {
        transform.localScale = new Vector3(1f, 1f, 0f);
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
        isClickable = false;
    }

    private void OnMouseOver()
    {
        isClickable = true;
        if (Input.GetMouseButtonDown(0) && gameObject.GetComponent<Object>().isClickable)
        {
            gameObject.SetActive(false);
            if (gameObject.tag == "Nature")
            {
                gameManager.score -= 10;
            }
            else if (gameObject.tag == "Harmfull")
            {
                gameManager.score += 1;
            }
        }
    
    }
}

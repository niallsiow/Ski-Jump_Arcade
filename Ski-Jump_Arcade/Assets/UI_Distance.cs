using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Distance : MonoBehaviour
{

    public Text currentScore;

    float startingPosition;
    float currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position.x - startingPosition;
        currentPosition = Mathf.RoundToInt(currentPosition);
        currentScore.text = "Score: " + currentPosition.ToString();
    }
}

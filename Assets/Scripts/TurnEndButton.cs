using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEndButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        GameObject
            .Find("TurnController")
            .GetComponent<TurnController>()
            .NextTurn();
    }
}

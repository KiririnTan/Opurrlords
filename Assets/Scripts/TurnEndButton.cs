using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEndButton : MonoBehaviour
{
    public TurnController turnController;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        if (turnController == null)
        {
            //this code will probably never be called.

            GameObject
            .Find("TurnController")
            .GetComponent<TurnController>()
            .NextTurn();

        }
        else
        {
            turnController.NextTurn();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PieceInShop : MonoBehaviour
{
    public int cost;

    public GameObject costDisplayPrefab;

    void Start()
    {
        PutCostDisplay();
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        var player = FindObjectOfType<Player>();

        if (player.money < this.cost)
        {
            Debug.Log("you dont have enough money");
            return;
        }

        player.money -= this.cost;
        Debug.Log("you bought a piece. u have " + player.money + " now");
        // move it to players bench
        // player.bench = [...bench, gameObject];

        // deletes or deactivates it
    }

    void PutCostDisplay()
    {
        var X_OFFSET = 1;
        var Y_OFFSET = -2;
        var Z_OFFSET = 0;

        var costDisplay = Instantiate(costDisplayPrefab, gameObject.transform);
        costDisplay.transform.localPosition = new Vector3(X_OFFSET, Y_OFFSET, Z_OFFSET);
        costDisplay.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

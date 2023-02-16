using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraInShop : MonoBehaviour
{
    public Cost cost;

    void Start()
    {
        // var material = GetComponent<Material>();
        // material.color = Color.green;
        // materialColor = GetColor(this.cost);
    }

    void Update()
    {

    }

    Color GetAuraColor()
    {
        if (this.cost.value == Cost.ONE) return Color.white;
        if (this.cost.value == Cost.TWO) return Color.green;
        if (this.cost.value == Cost.THREE) return Color.blue;
        if (this.cost.value == Cost.FOUR) return Color.magenta;
        if (this.cost.value == Cost.FIVE) return Color.yellow;

        throw new UnityException("cost is out of range");
    }
}

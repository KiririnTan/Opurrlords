using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//test

public class PieceShop : MonoBehaviour
{
    static readonly int PIECES_X_POS_START = -10;
    static readonly int PIECES_X_POS_BUFFER = 4;
    static readonly int PIECES_Y_POS = 0;
    static readonly int PIECES_Z_POS = 0;
    static readonly int ITEM_COUNT_MAX = 5;

    public GameObject[] pieceSelection;

    private GameObject displayPieces;
    private bool isPressed = false;

    void Start()
    {
        this.displayPieces = GameObject.Find("DisplayPieces");
        this.PutPieces(this.pieceSelection);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !this.isPressed)
        {
            this.ToggleOpen();
            this.isPressed = true;
            return;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.isPressed = false;
            return;
        }
    }

    void PutPieces(GameObject[] pieceSelection)
    {
        for (int i = 0; i < ITEM_COUNT_MAX; i++)
        {
            var pieceNumber = Random.Range(0, pieceSelection.Length);
            var piece = Instantiate(pieceSelection[pieceNumber], this.displayPieces.transform);
            var position = new Vector3(PIECES_X_POS_START + (i * PIECES_X_POS_BUFFER), PIECES_Y_POS, PIECES_Z_POS);
            piece.transform.localPosition = position;
        }
    }

    void ToggleOpen()
    {
        this.displayPieces.SetActive(!this.displayPieces.activeSelf);
        // TODO: put ShopBoard.setActive()
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay_manager : MonoBehaviour
{
    private const short maxGameObjectsRotated = 2;
    private short amountOfPiecesRotated = 0;

    private GameObject pieceOne;
    private GameObject pieceTwo;

    private bool pieceOneSelected = false;
    private bool pieceTwoSelected = false;

    private void Start()
    {
        amountOfPiecesRotated = 0;
    }

    private void Update()
    {
        if (!CanRotate()) 
        {
            pieceOneSelected = false;
            pieceTwoSelected = false;
            amountOfPiecesRotated = 0;

            if (CheckIfTwoPiecesAreSameColor()) 
            {
                Destroy(pieceOne);
                Destroy(pieceTwo);
            }
            else 
            {
                pieceOne.transform.Rotate(new Vector3(0f, 0f, 180f));
                pieceTwo.transform.Rotate(new Vector3(0f, 0f, 180f));
            }
        }
    }

    public void NewPieceRotated(GameObject piece) 
    {
        amountOfPiecesRotated += 1;

        if (pieceOneSelected)
        {
            pieceTwoSelected = true;
            pieceTwo = piece;
        }
        else
        {
            pieceOneSelected = true;
            pieceOne = piece;
        }
    }    

    private bool CheckIfTwoPiecesAreSameColor() 
    {
        MeshFilter meshFilterOne = pieceOne.transform.GetChild(0).GetComponent<MeshFilter>();
        MeshFilter meshFilterTwo = pieceTwo.transform.GetChild(0).GetComponent<MeshFilter>();
        
        return meshFilterOne.sharedMesh.colors == meshFilterTwo.sharedMesh.colors;               
    }

    public bool CanRotate() 
    {
        return amountOfPiecesRotated < maxGameObjectsRotated;
    }   
}

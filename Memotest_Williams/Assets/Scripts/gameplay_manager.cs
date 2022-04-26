using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay_manager : MonoBehaviour
{
    [SerializeField] private GameObject[] pieces;

    private const short maxGameObjectsRotated = 2;
    private short amountOfPiecesRotated = 0;

    private void Update()
    {
        CheckAmountOfPiecesRotated();


    }

    private void CheckAmountOfPiecesRotated() 
    {
        amountOfPiecesRotated = 0;

        for (short i = 0; i < pieces.Length; i++) 
        {
            if (pieces[i].transform.eulerAngles.z == 180f) 
            {
                amountOfPiecesRotated += 1;
            }
        }
    }

    public bool CanRotate() 
    {
        return amountOfPiecesRotated < maxGameObjectsRotated;
    }   
}

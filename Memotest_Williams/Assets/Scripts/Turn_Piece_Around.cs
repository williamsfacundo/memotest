using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Piece_Around : MonoBehaviour
{
    [SerializeField] private gameplay_manager gameplayManager;

    private bool rotate = false;

    private void OnMouseDown()
    {
        Debug.Log("Piece Rotated");

        rotate = true;       
    }

    private void LateUpdate()
    {
        if (rotate && gameplayManager.CanRotate()) 
        {
            transform.Rotate(new Vector3(0f, 0f, 180f));
            rotate = false;

            gameplayManager.NewPieceRotated(gameObject);
        }
    }
}

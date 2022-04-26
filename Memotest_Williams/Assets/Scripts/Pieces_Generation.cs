using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces_Generation : MonoBehaviour
{
    [SerializeField] private GameObject piece_prefab;

    [SerializeField] private Transform generation_center;

    [SerializeField] private short amount_pieces = 10;

    // Start is called before the first frame update
    private void Start()
    {
        InstanciatePrefabs(piece_prefab, generation_center, amount_pieces);                
    }   

    private void InstanciatePrefabs(GameObject prefab, Transform center, short amount) 
    {
                
    }
}

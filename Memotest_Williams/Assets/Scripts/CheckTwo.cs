using UnityEngine;

public class CheckTwo : MonoBehaviour
{
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;


    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshOne = object1.transform.GetChild(0).GetComponent<MeshFilter>();
        MeshFilter meshTwo = object2.transform.GetChild(0).GetComponent<MeshFilter>();

        Debug.Log(meshOne.sharedMesh.colors = meshTwo.sharedMesh.colors);
    }
}

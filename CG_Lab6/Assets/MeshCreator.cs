using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCreator : MonoBehaviour
{
    Mesh customMesh;
    void Start()
    {
        customMesh = new Mesh();

        customMesh.Clear();
        Vector3[] vertices = new Vector3[8]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0),

            new Vector3(0, 1, 2),
            new Vector3(1, 1, 2),

            new Vector3(0, 0, 2),
            new Vector3(1, 0, 2)
        };
        customMesh.vertices = vertices;

        int[] tris = new int[30]
        {
            0, 2, 1,
            2, 3, 1,

            3, 2, 4,
            4, 5, 3,

            7, 1, 5,
            1, 3, 5,

            2, 0, 4,
            6, 4, 0,

            0, 1, 7,
            0, 7, 6
        };
        customMesh.triangles = tris;
        customMesh.RecalculateNormals();

        GetComponent<MeshFilter>().sharedMesh = customMesh;
    }
}

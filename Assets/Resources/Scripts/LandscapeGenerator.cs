using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class LandscapeGenerator : MonoBehaviour
{

    [SerializeField]
    private float cellsize = 1f;

    [SerializeField]
    private int width = 50, height = 50;

    [SerializeField]
    private int submeshSize = 1;

    [SerializeField]
    private float bumpyness = 5f;

    [SerializeField]
    private float bumpheight = 5f;

    

    void Start()
    {

        MeshFilter meshFilter = this.GetComponent<MeshFilter>();
        MeshGenerator mg = new MeshGenerator(submeshSize);

        CreateLandscape(mg);

        meshFilter.mesh = mg.CreateMesh();
    }

    private void CreateLandscape(MeshGenerator mg)
    {
        Vector3[,] points = new Vector3[width, height];

        //1. Generate the points in our plane
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                points[x, y] = new Vector3(cellsize * x,
                                          Mathf.PerlinNoise(
                                            (x + Time.time) * bumpyness * 0.1f, (y + Time.time) * bumpyness * 0.1f) * bumpheight,
                                         cellsize * y);
            }
        }

        int submesh = 0;

        //2. Generate the quads
        for(int x = 0; x < width - 1; x++)
        {
            for(int y = 0; y < height - 1; y++)
            {
                //2.1 Generate the points of each quad
                Vector3 br = points[x,     y];
                Vector3 bl = points[x + 1, y];
                Vector3 tr = points[x,     y + 1];
                Vector3 tl = points[x + 1, y + 1];

                //2.2 Generate the triangles to create the quad
                mg.BuildTriangle(bl,tr,tl, submesh % submeshSize);
                mg.BuildTriangle(bl, br, tr, submesh % submeshSize);
            }

            submesh++;
        }

    }
}

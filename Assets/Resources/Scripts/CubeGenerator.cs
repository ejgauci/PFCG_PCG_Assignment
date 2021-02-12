using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class CubeGenerator : MonoBehaviour
{
    [SerializeField]
    private Vector3 size = Vector3.one;

    [SerializeField]
    private int meshSize = 6;

    private List<Material> materialsList;

    // Update is called once per frame
    void Update()
    {
    }

    private void Start()
    {

        //1. initialise MeshFilter
        MeshFilter meshFilter = this.GetComponent<MeshFilter>();

        //2. initialise MeshBuilder
        MeshGenerator mg = new MeshGenerator(meshSize);


        //4. build our cube

        //top vertices
        Vector3 t0 = new Vector3(size.x, size.y, -size.z); // top left point
        Vector3 t1 = new Vector3(-size.x, size.y, -size.z); // top right point
        Vector3 t2 = new Vector3(-size.x, size.y, size.z); //bottom right point of top square
        Vector3 t3 = new Vector3(size.x, size.y, size.z); // bottom left point of top square

        //bottom vertices
        Vector3 b0 = new Vector3(size.x, -size.y, -size.z); // bottom left point
        Vector3 b1 = new Vector3(-size.x, -size.y, -size.z); // bottom right point
        Vector3 b2 = new Vector3(-size.x, -size.y, size.z); //bottom right point of bottom square
        Vector3 b3 = new Vector3(size.x, -size.y, size.z); // bottom left point of bottom square


        //top square
        mg.BuildTriangle(t0, t1, t2, 0);
        mg.BuildTriangle(t0, t2, t3, 0);

        //bottom square
        mg.BuildTriangle(b2, b1, b0, 1);
        mg.BuildTriangle(b3, b2, b0, 1);


        //back square
        mg.BuildTriangle(b0, t1, t0, 2);
        mg.BuildTriangle(b0, b1, t1, 2);


        //left-side square
        mg.BuildTriangle(b1, t2, t1, 3);
        mg.BuildTriangle(b1, b2, t2, 3);


        //right-side square
        mg.BuildTriangle(b2, t3, t2, 4);
        mg.BuildTriangle(b2, b3, t3, 4);

        //front square
        mg.BuildTriangle(b3, t0, t3, 5);
        mg.BuildTriangle(b3, b0, t0, 5);


        //3. set mesh filter's mesh to the mesh generated from our mesh builder
        meshFilter.mesh = mg.CreateMesh();


        //5. Assign materials to the mesh renderer's materials list
        MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
        AddMaterials();
        meshRenderer.materials = materialsList.ToArray();
    }

    private void AddMaterials()
    {

        Material redMat = new Material(Shader.Find("Specular"));
        redMat.color = Color.red;

        Material blueMat = new Material(Shader.Find("Specular"));
        blueMat.color = Color.blue;

        Material greenMat = new Material(Shader.Find("Specular"));
        greenMat.color = Color.green;

        Material magentaMat = new Material(Shader.Find("Specular"));
        magentaMat.color = Color.magenta;

        Material yellowMat = new Material(Shader.Find("Specular"));
        yellowMat.color = Color.yellow;

        Material whiteMat = new Material(Shader.Find("Specular"));
        whiteMat.color = Color.white;

        materialsList = new List<Material>();
        materialsList.Add(whiteMat);
        materialsList.Add(blueMat);
        materialsList.Add(greenMat);
        materialsList.Add(magentaMat);
        materialsList.Add(yellowMat);
        materialsList.Add(redMat);
    }
}

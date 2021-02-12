using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class PyramidGenerator : MonoBehaviour
{
    [SerializeField]
    private float pyramidSize = 5f;

    private int subMeshSize = 4;



    // Update is called once per frame
    void Start()
    {
        MeshFilter meshFilter = this.GetComponent<MeshFilter>();

        MeshGenerator mg = new MeshGenerator(subMeshSize);

        //Add Points
        Vector3 top = new Vector3(0, pyramidSize, 0);

        Vector3 base0 = Quaternion.AngleAxis(0f, Vector3.up) * Vector3.forward * pyramidSize;

        Vector3 base1 = Quaternion.AngleAxis(240f, Vector3.up) * Vector3.forward * pyramidSize;

        Vector3 base2 = Quaternion.AngleAxis(120f, Vector3.up) * Vector3.forward * pyramidSize;


        //Build the triangles for our pyramid
        mg.BuildTriangle(base0, base1, base2, 0);

        mg.BuildTriangle(base1, base0, top, 1);

        mg.BuildTriangle(base2, top, base0, 2);

        mg.BuildTriangle(top, base2, base1, 3);

        meshFilter.mesh = mg.CreateMesh();

        MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
        meshRenderer.materials = MaterialsList().ToArray();
    }

    private List<Material> MaterialsList()
    {
        List<Material> materialsList = new List<Material>();

        Material redMat = new Material(Shader.Find("Specular"));
        redMat.color = Color.red;

        Material greenMat = new Material(Shader.Find("Specular"));
        greenMat.color = Color.green;

        Material blueMat = new Material(Shader.Find("Specular"));
        blueMat.color = Color.blue;

        Material yellowMat = new Material(Shader.Find("Specular"));
        yellowMat.color = Color.yellow;

        materialsList.Add(redMat);
        materialsList.Add(greenMat);
        materialsList.Add(blueMat);
        materialsList.Add(yellowMat);

        return materialsList;
    }
}

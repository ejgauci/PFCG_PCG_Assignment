using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class MazeMaker : MonoBehaviour
{
    public GameObject mazeParent;


    private void Start()
    {
        
            borderWalls();
            verticalWalls();
            horizonatalWalls();
        
    }

    void borderWalls()
    {
        var borderWall1 = new GameObject().AddComponent<CubeGenerator>();
        borderWall1.transform.position = new Vector3(0, 0, 30);
        borderWall1.transform.Rotate(0, 90, 0);
        borderWall1.transform.localScale = new Vector3(0.5f, 6, 30);
        borderWall1.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        borderWall1.transform.parent = mazeParent.transform;
        borderWall1.name = "BorderWall 1";


        var borderWall2 = new GameObject().AddComponent<CubeGenerator>();
        borderWall2.transform.position = new Vector3(0, 0, -30);
        borderWall2.transform.Rotate(0, 90, 0);
        borderWall2.transform.localScale = new Vector3(0.5f, 6, 30);
        borderWall2.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        borderWall2.transform.parent = mazeParent.transform;
        borderWall2.name = "BorderWall 2";


        var borderWall3 = new GameObject().AddComponent<CubeGenerator>();
        borderWall3.transform.position = new Vector3(-30, 0, 0);
        borderWall3.transform.Rotate(0, 0, 0);
        borderWall3.transform.localScale = new Vector3(0.5f, 6, 30);
        borderWall3.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        borderWall3.transform.parent = mazeParent.transform;
        borderWall3.name = "BorderWall 3";


        var borderWall4 = new GameObject().AddComponent<CubeGenerator>();
        borderWall4.transform.position = new Vector3(30, 0, 0);
        borderWall4.transform.Rotate(0, 0, 0);
        borderWall4.transform.localScale = new Vector3(0.5f, 6, 30);
        borderWall4.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        borderWall4.transform.parent = mazeParent.transform;
        borderWall4.name = "BorderWall 4";

    }



    void verticalWalls()
    {

        //size 5
        var verticalWall1 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall1.transform.position = new Vector3(10, 0, 25);
        verticalWall1.transform.Rotate(0, 0, 0);
        verticalWall1.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall1.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall1.transform.parent = mazeParent.transform;
        verticalWall1.name = "Vertical Wall 1";


        var verticalWall2 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall2.transform.position = new Vector3(-20, 0, 15);
        verticalWall2.transform.Rotate(0, 0, 0);
        verticalWall2.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall2.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall2.transform.parent = mazeParent.transform;
        verticalWall2.name = "Vertical Wall 2";

        var verticalWall3 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall3.transform.position = new Vector3(0, 0, 15);
        verticalWall3.transform.Rotate(0, 0, 0);
        verticalWall3.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall3.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall3.transform.parent = mazeParent.transform;
        verticalWall3.name = "Vertical Wall 3";

        var verticalWall4 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall4.transform.position = new Vector3(20, 0, 15);
        verticalWall4.transform.Rotate(0, 0, 0);
        verticalWall4.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall4.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall4.transform.parent = mazeParent.transform;
        verticalWall4.name = "Vertical Wall 4";


        var verticalWall5 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall5.transform.position = new Vector3(-20, 0, -5);
        verticalWall5.transform.Rotate(0, 0, 0);
        verticalWall5.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall5.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall5.transform.parent = mazeParent.transform;
        verticalWall5.name = "Vertical Wall 5";

        var verticalWall6 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall6.transform.position = new Vector3(20, 0, -15);
        verticalWall6.transform.Rotate(0, 0, 0);
        verticalWall6.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall6.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall6.transform.parent = mazeParent.transform;
        verticalWall6.name = "Vertical Wall 6";

        var verticalWall7 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall7.transform.position = new Vector3(-20, 0, -25);
        verticalWall7.transform.Rotate(0, 0, 0);
        verticalWall7.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall7.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall7.transform.parent = mazeParent.transform;
        verticalWall7.name = "Vertical Wall 7";

        var verticalWall8 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall8.transform.position = new Vector3(0, 0, -25);
        verticalWall8.transform.Rotate(0, 0, 0);
        verticalWall8.transform.localScale = new Vector3(0.5f, 5, 5);
        verticalWall8.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall8.transform.parent = mazeParent.transform;
        verticalWall8.name = "Vertical Wall 8";

        //size10

        var verticalWall9 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall9.transform.position = new Vector3(-10, 0, 0);
        verticalWall9.transform.Rotate(0, 0, 0);
        verticalWall9.transform.localScale = new Vector3(0.5f, 5, 10);
        verticalWall9.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall9.transform.parent = mazeParent.transform;
        verticalWall9.name = "Vertical Wall 9";

        var verticalWall10 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall10.transform.position = new Vector3(0, 0, -10);
        verticalWall10.transform.Rotate(0, 0, 0);
        verticalWall10.transform.localScale = new Vector3(0.5f, 5, 10);
        verticalWall10.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall10.transform.parent = mazeParent.transform;
        verticalWall10.name = "Vertical Wall 10";

        var verticalWall11 = new GameObject().AddComponent<CubeGenerator>();
        verticalWall11.transform.position = new Vector3(10, 0, -10);
        verticalWall11.transform.Rotate(0, 0, 0);
        verticalWall11.transform.localScale = new Vector3(0.5f, 5, 10);
        verticalWall11.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        verticalWall11.transform.parent = mazeParent.transform;
        verticalWall11.name = "Vertical Wall 11";

    }


    
    void horizonatalWalls()
    {
   

        var horizontalWall1 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall1.transform.position = new Vector3(-15, 0, 20);
        horizontalWall1.transform.Rotate(0, 90, 0);
        horizontalWall1.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall1.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall1.transform.parent = mazeParent.transform;
        horizontalWall1.name = "Horizontal Wall 1";

        var horizontalWall2 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall2.transform.position = new Vector3(25, 0, 20);
        horizontalWall2.transform.Rotate(0, 90, 0);
        horizontalWall2.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall2.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall2.transform.parent = mazeParent.transform;
        horizontalWall2.name = "Horizontal Wall 2";

        var horizontalWall3 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall3.transform.position = new Vector3(15, 0, 0);
        horizontalWall3.transform.Rotate(0, 90, 0);
        horizontalWall3.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall3.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall3.transform.parent = mazeParent.transform;
        horizontalWall3.name = "Horizontal Wall 3";

        var horizontalWall4 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall4.transform.position = new Vector3(25, 0, -10);
        horizontalWall4.transform.Rotate(0, 90, 0);
        horizontalWall4.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall4.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall4.transform.parent = mazeParent.transform;
        horizontalWall4.name = "Horizontal Wall 4";

        var horizontalWall5 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall5.transform.position = new Vector3(-15, 0, -20);
        horizontalWall5.transform.Rotate(0, 90, 0);
        horizontalWall5.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall5.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall5.transform.parent = mazeParent.transform;
        horizontalWall5.name = "Horizontal Wall 5";

        var horizontalWall6 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall6.transform.position = new Vector3(5, 0, -20);
        horizontalWall6.transform.Rotate(0, 90, 0);
        horizontalWall6.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall6.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall6.transform.parent = mazeParent.transform;
        horizontalWall6.name = "Horizontal Wall 6";

        var horizontalWall7 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall7.transform.position = new Vector3(-25, 0, 10);
        horizontalWall7.transform.Rotate(0, 90, 0);
        horizontalWall7.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall7.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall7.transform.parent = mazeParent.transform;
        horizontalWall7.name = "Horizontal Wall 7";

        var horizontalWall8 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall8.transform.position = new Vector3(-25, 0, -10);
        horizontalWall8.transform.Rotate(0, 90, 0);
        horizontalWall8.transform.localScale = new Vector3(0.5f, 5, 5);
        horizontalWall8.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall8.transform.parent = mazeParent.transform;
        horizontalWall8.name = "Horizontal Wall 8";


        //size10
        var horizontalWall9 = new GameObject().AddComponent<CubeGenerator>();
        horizontalWall9.transform.position = new Vector3(0, 0, 10);
        horizontalWall9.transform.Rotate(0, 90, 0);
        horizontalWall9.transform.localScale = new Vector3(0.5f, 5, 10);
        horizontalWall9.gameObject.AddComponent<BoxCollider>().size = new Vector3(2, 2, 2);
        horizontalWall9.transform.parent = mazeParent.transform;
        horizontalWall9.name = "Horizontal Wall 9";
    }

}

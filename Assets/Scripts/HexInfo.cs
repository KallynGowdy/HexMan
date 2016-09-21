using UnityEngine;
using System.Collections;

/// <summary>
/// Defines a component that renders an object as a hexagon.
/// </summary>
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(Renderer))]
public class HexInfo : MonoBehaviour
{
    private Vector3[] verticies;
    private Vector2[] uv;
    private int[] triangles;

    void Start()
    {
        SetupMesh();
    }

    private void SetupMesh()
    {
        float floorLevel = 0;
        verticies = new Vector3[]
        {
            new Vector3(-1f, floorLevel, -0.5f),
            new Vector3(-1f, floorLevel,  0.5f),
            new Vector3( 0f, floorLevel,  1f),
            new Vector3( 1f, floorLevel,  0.5f),
            new Vector3( 1f, floorLevel, -0.5f),
            new Vector3( 0f, floorLevel, -1f),
        };

        triangles = new int[]
        {
            1,5,0,
            1,4,5,
            1,2,4,
            2,3,4
        };

        uv = new Vector2[]
        {
            new Vector2(0,0.25f),
            new Vector2(0,0.75f),
            new Vector2(0.5f,1),
            new Vector2(1,0.75f),
            new Vector2(1,0.25f),
            new Vector2(0.5f,0),
        };

        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh
        {
            vertices = verticies,
            triangles = triangles,
            uv = uv
        };
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;
    }
}

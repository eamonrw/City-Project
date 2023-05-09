using UnityEngine;

public class MeshReplacer : MonoBehaviour
{
    public Mesh mesh;
    [ContextMenu("Replace meshes")]
    public void Replace()
    {
        foreach (var m in FindObjectsOfType<MeshFilter>())
        {
            if (m.sharedMesh.vertexCount != mesh.vertexCount) continue;
            if (m.sharedMesh.bounds != mesh.bounds) continue;
            m.sharedMesh = mesh;
        }
    }
}
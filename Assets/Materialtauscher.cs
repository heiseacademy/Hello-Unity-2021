using UnityEngine;

public class Materialtauscher : MonoBehaviour
{
    public Material materialA;
    public Material materialB;
    public MeshRenderer meshRenderer;

    private void OnMouseUpAsButton()
    {
        Debug.Log("Tauschen");
        Material[] mats = meshRenderer.sharedMaterials;
        if (mats[0] == materialA)
            mats[0] = materialB;
        else
            mats[0] = materialA;
        meshRenderer.sharedMaterials = mats;
    }

}

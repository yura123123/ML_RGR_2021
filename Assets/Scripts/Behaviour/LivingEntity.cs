using UnityEngine;

public class LivingEntity : MonoBehaviour {

    public int colourMaterialIndex;
    public Species species;
    public Material material;

    public Coord coord;
    //
    [HideInInspector]
    public int mapIndex;
    [HideInInspector]
    public Coord mapCoord;

    protected bool dead;

    public virtual void Init (Coord coord) {
        this.coord = coord;
        transform.position = Environment.tileCentres[coord.x, coord.y];

        // Set material to the instance material
        var meshRenderer = transform.GetComponentInChildren<MeshRenderer> ();
        for (int i = 0; i < meshRenderer.sharedMaterials.Length; i++)
        {
            /*if (material == null)
            {
                material = meshRenderer.materials[0];
            }*/
            /*if (meshRenderer.sharedMaterials[i] == material)
            {
                material = meshRenderer.materials[i];
                break;
            }*/

            if (meshRenderer.sharedMaterials[i] is Material)
            {
                material = meshRenderer.materials[i];
                break;
            }
        }
    }

    protected virtual void Die (CauseOfDeath cause) {
        if (!dead) {
            dead = true;
            Environment.RegisterDeath (this);
            Destroy (gameObject);
        }
    }
}
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    Material m_Material;
    bool focused;


    void Start()
    {
        focused = false;
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void OnMouseOver()
    {
        // Change the Color of the GameObject when the mouse hovers over it
        if (!focused)
            {
                m_Material.color = Color.grey;
            }
    }

    public void isFocused ()
    {
        m_Material.color = Color.yellow;
        focused = true;

    }
    public void isNotFocused()
    {
        m_Material.color = Color.white;
        focused = false;
    }
}

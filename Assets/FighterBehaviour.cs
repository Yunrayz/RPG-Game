using UnityEngine;
using UnityEngine.UI;

public class FighterBehaviour : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    public Element element;

    private void Start()
    {
        maxHealth = health;
    }
    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}

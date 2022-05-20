using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Spell : MonoBehaviour
{
    public string spellName;
    public int dammage;
    public float cooldown;
    public float timeStamp;
    public FighterBehaviour target;
    public PlayerController caster;
    public Element element;
    public Transform environment;
    // Start is called before the first frame update
    public abstract void Cast(FighterBehaviour newTarget, PlayerController caster);


}

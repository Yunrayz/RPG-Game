using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterfall : Spell
{
    public csParticleMove spellAnimation;


    public Waterfall()
    {
        spellName = "Waterfall";
        dammage = 50;
        cooldown = 2;
    }
    // Start is called before the first frame update
    private void Start()
    {
        element = gameObject.AddComponent(typeof(Element)) as Element;
        element.genre = "water";
        timeStamp = 0;
    }

    public override void Cast(FighterBehaviour newTarget, PlayerController newCaster)
    {
        if (timeStamp <= Time.time)
        {
            Debug.Log("Cast starting");

            target = newTarget;
            caster = newCaster;

            if (target.health > 0)
            {
                csParticleMove clone = Instantiate(spellAnimation, caster.GetComponent<Transform>().position, Quaternion.identity, environment);
                clone.casterPosition = caster.GetComponent<Transform>().position;
                clone.targetPosition = target.GetComponent<Transform>().position;
                target.health -= dammage;
                Debug.Log("Target's health is now " + target.health);
                target.element.addElement(element);

            }
            else
            {
                Debug.Log("Target's already dead !");
            }
            timeStamp = Time.time + cooldown;

            Debug.Log("Cast ending");
        }
        else
        {
            Debug.Log(spellName + " is in cooldown");
        }
    }
}

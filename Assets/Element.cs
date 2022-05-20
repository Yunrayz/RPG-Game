using System;
using UnityEngine;

public class Element : MonoBehaviour
{
    public string genre;
    
    public Element (string newElement)
    {
        genre = newElement;
    }
    public void addElement (Element newElement)
    {
        Debug.Log("Adding element");
        if (genre == "")
        {
            genre = newElement.genre;
        }
        else if (newElement.genre == "fire")
        {
            FireReaction();
        }
        else if (newElement.genre == "ice")
        {
            IceReaction();
        }
        else if (newElement.genre == "water")
        {
            WaterReaction();
        }
        else if (newElement.genre == "ground")
        {
            GroundReaction();
        }
        else if (newElement.genre == "electric")
        {
            ElectricReaction();
        }
        else if (newElement.genre == "wind")
        {
            WindReaction();
        }
    }

    

   

    public void FireReaction()
    {
        if (genre == "ice")
        {
            Debug.Log("Fonte !");
        }
        else if (genre == "water")
        {
            Debug.Log("Evaporation !");
        }
        else if (genre == "wind")
        {
            Debug.Log("Explosion !");
        }
        else if (genre == "electric")
        {
            Debug.Log("Plasma !");
        }
        else if (genre == "ground")
        {
            Debug.Log("Magma !");
        }
    }

    public void IceReaction()
    {
        if (genre == "fire")
        {
            Debug.Log("Fonte !");
        }
        else if (genre == "water")
        {
            Debug.Log("Freeze !");
        }
        else if (genre == "wind")
        {
            Debug.Log("Blizzard !");
        }
        else if (genre == "electric")
        {
            Debug.Log("Supraconduction !");
        }
        else if (genre == "ground")
        {
            Debug.Log("Cristalization !");
        }      
    }

    public void WaterReaction()
    {
        if (genre == "fire")
        {
            Debug.Log("Evaporation !");
        }
        else if (genre == "ice")
        {
            Debug.Log("Freeze !");
        }
        else if (genre == "wind")
        {
            Debug.Log("Rain !");
        }
        else if (genre == "electric")
        {
            Debug.Log("Conduction !");
        }
        else if (genre == "ground")
        {
            Debug.Log("Mud !");
        }
    }

    public void WindReaction()
    {
        if (genre == "fire")
        {
            Debug.Log("Explosion !");
        }
        else if (genre == "ice")
        {
            Debug.Log("Blizzard !");
        }
        else if (genre == "water")
        {
            Debug.Log("Rain !");
        }
        else if (genre == "electric")
        {
            Debug.Log("Storm !");
        }
        else if (genre == "ground")
        {
            Debug.Log("Tornado !");
        }
    }

    public void ElectricReaction()
    {
        if (genre == "fire")
        {
            Debug.Log("Plasma !");
        }
        else if (genre == "ice")
        {
            Debug.Log("Supraconduction !");
        }
        else if (genre == "water")
        {
            Debug.Log("Conduction !");
        }
        else if (genre == "wind")
        {
            Debug.Log("Storm !");
        }
        else if (genre == "ground")
        {
            Debug.Log("Magnetic field !");
        }
    }

    public void GroundReaction()
    {
        if (genre == "fire")
        {
            Debug.Log("Magma !");
        }
        else if (genre == "ice")
        {
            Debug.Log("Cristalization !");
        }
        else if (genre == "water")
        {
            Debug.Log("Mud !");
        }
        else if (genre == "wind")
        {
            Debug.Log("Tornado !");
        }
        else if (genre == "electrical")
        {
            Debug.Log("Magnetic field !");
        }
    }
}

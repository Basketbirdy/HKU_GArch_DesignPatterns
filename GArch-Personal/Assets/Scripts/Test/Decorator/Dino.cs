using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    IDinosaur dino;

    private void Start()
    {
        dino = new Dinosaur();

        Debug.Log("[Dino] " + dino.Roar());

        dino = new LoudDinosaurDecorator(dino);

        Debug.Log("[Dino] " + dino.Roar());

        dino = new AngryDinosaurDecorator(dino);

        Debug.Log("[Dino] " + dino.Roar());

        dino = new AngryDinosaurDecorator(dino);

        Debug.Log("[Dino] " + dino.Roar());

        dino = new LoudDinosaurDecorator(dino);

        Debug.Log("[Dino] " + dino.Roar());
    }


}

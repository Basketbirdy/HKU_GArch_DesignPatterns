using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryDinosaurDecorator : IDinosaur
{
    IDinosaur dino;

    public AngryDinosaurDecorator(IDinosaur dino)
    {
        this.dino = dino;
    }

    public string Roar()
    {
        return dino.Roar() + " >:(";
    }
}

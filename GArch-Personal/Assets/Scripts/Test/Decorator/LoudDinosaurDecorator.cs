using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoudDinosaurDecorator : IDinosaur
{
    IDinosaur dino;

    public LoudDinosaurDecorator(IDinosaur dino)
    {
        this.dino = dino;
    }

    public string Roar()
    {
        return dino.Roar() + " !!!";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class SpeedPotion : Collectible
{
    PlatformerCharacter2D _character; 
    private void Awake()
    {
        _character = FindObjectOfType<PlatformerCharacter2D>();
    }

    public override void HandleCollected()
    {
        _character.DoubleSpeedBruh();
    }
}

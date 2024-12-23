using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Artwork", menuName = "Scriptable Object/NewArtwork", order = 0)]


public class ArtGaleriaSO : ScriptableObject
{
    public Texture[] artworks;
}

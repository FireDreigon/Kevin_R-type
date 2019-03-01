using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPlayer
{
    public enum SetSkins { Mago, Vikingo, Cowboy, MaxSetSkin };
    public enum BaseSkins { Normal, Bobo, Furioso, Mono, MaxSkin };

    public BaseSkins SkinId { get; set; }
    public Sprite BaseSkin { get; set; }

    public SetSkins SombreroId { get; set; }
    public GameObject SombreroSkin;

    public SetSkins VikingoId { get; set; }
    public GameObject VikingoSkin;

    public SetSkins CowboyId { get; set; }
    public GameObject CowboySkin;
}

[System.Serializable]
public class SetSkin
{
    public string SetName { get; set; }
    public GameObject Capa { get; set; }
    public GameObject Sombrero { get; set; }
    public GameObject Arma { get; set; }
}

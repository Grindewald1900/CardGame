using System.Linq;
using Extensions;
using UnityEngine;

namespace Tools.UI.Card
{
    /// <summary>
    ///     Picks a Texture randomly when it Awakes.
    /// </summary>
    public class UiTexturePicker : MonoBehaviour
    {
        // [SerializeField] Sprite[] Sprites;
        Sprite[] Sprites;
        [SerializeField] SpriteRenderer MyRenderer { get; set; }

        void Awake()
        {
            Sprites = Resources.LoadAll<Sprite>("CharacterTextures");
            MyRenderer = GetComponent<SpriteRenderer>();

            if (Sprites.Length > 0)
                MyRenderer.sprite = Sprites.ToList().RandomItem();
        }
    }
}
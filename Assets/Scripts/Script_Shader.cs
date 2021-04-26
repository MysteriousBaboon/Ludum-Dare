using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Script_Shader : MonoBehaviour
{
      public Material material;
      public float value;

  void OnRenderImage (RenderTexture source, RenderTexture destination) {
    Graphics.Blit(source, destination, material);
  }
}

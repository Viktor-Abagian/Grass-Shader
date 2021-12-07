using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class InteractionHolder : MonoBehaviour
{
    Vector3 position;
    void Update()
    {
        position = transform.position;
        Shader.SetGlobalVector("_ObjectPos", position);
    }
}

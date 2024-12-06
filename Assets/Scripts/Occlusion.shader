Shader "Custom/Occlusion"
{
    SubShader
    {
        Tags {"Queue"="Geometry-1"}
        Pass
        {
            ColorMask 0 // Não renderiza cor
            ZWrite On   // Escreve no depth buffer
        }
    }
}

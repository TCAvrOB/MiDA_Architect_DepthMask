Shader "Unlit/DepthMask_sample01"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	}

	SubShader{
		Pass
		{
			// Depth Testの実施 および Depth Bufferの更新
			Zwrite On

			// 色情報は更新しない
			ColorMask 0
		}
	}
}

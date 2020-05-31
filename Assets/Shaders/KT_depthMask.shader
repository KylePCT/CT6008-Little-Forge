Shader "Custom/KT_depthMask"

//Retrieved from http://wiki.unity3d.com/index.php/DepthMask?_ga=2.49168550.1086181043.1590874499-1439766605.1584272748 31/05 16:32

{

	SubShader{
		// Render the mask after regular geometry, but before masked geometry and
		// transparent things.

		Tags {"Queue" = "Geometry+10" }

		// Don't draw in the RGBA channels; just the depth buffer

		ColorMask 0
		ZWrite On

		// Do nothing specific in the pass:

		Pass {}
	}
}
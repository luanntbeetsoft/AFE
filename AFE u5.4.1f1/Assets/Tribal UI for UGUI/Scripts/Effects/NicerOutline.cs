﻿/// Credit Melang
/// Sourced from - http://forum.unity3d.com/members/melang.593409/

using System.Collections.Generic;

namespace UnityEngine.UI
{
//	[AddComponentMenu("UI/Effects/Nicer Outline")]
//#if UNITY_5_2 || UNITY_5_3 || UNITY_5_4 || UNITY_5_5 || UNITY_5_6 || UNITY_5_7 || UNITY_5_8 || UNITY_5_9
//    public class NicerOutline : BaseMeshEffect
//#else
//	public class NicerOutline : BaseVertexEffect
//#endif
//	{
//		[SerializeField]
//		private Color m_EffectColor = new Color (0f, 0f, 0f, 0.5f);
		
//		[SerializeField]
//		private Vector2 m_EffectDistance = new Vector2 (1f, -1f);
		
//		[SerializeField]
//		private bool m_UseGraphicAlpha = true;
//		//
//		// Properties
//		//
//		public Color effectColor
//		{
//			get
//			{
//				return this.m_EffectColor;
//			}
//			set
//			{
//				this.m_EffectColor = value;
//				if (base.graphic != null)
//				{
//					base.graphic.SetVerticesDirty ();
//				}
//			}
//		}
		
//		public Vector2 effectDistance
//		{
//			get
//			{
//				return this.m_EffectDistance;
//			}
//			set
//			{
//				if (value.x > 600f)
//				{
//					value.x = 600f;
//				}
//				if (value.x < -600f)
//				{
//					value.x = -600f;
//				}
//				if (value.y > 600f)
//				{
//					value.y = 600f;
//				}
//				if (value.y < -600f)
//				{
//					value.y = -600f;
//				}
//				if (this.m_EffectDistance == value)
//				{
//					return;
//				}
//				this.m_EffectDistance = value;
//				if (base.graphic != null)
//				{
//					base.graphic.SetVerticesDirty ();
//				}
//			}
//		}
		
//		public bool useGraphicAlpha
//		{
//			get
//			{
//				return this.m_UseGraphicAlpha;
//			}
//			set
//			{
//				this.m_UseGraphicAlpha = value;
//				if (base.graphic != null)
//				{
//					base.graphic.SetVerticesDirty ();
//				}
//			}
//		}
		
//#if UNITY_EDITOR
//		protected override void OnValidate ()
//		{
//			this.effectDistance = this.m_EffectDistance;
//			base.OnValidate ();
//		}
//#endif

//		//
//		// Methods
//		//
//		protected void ApplyShadow (List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
//		{
//			//Debug.Log("verts count: "+verts.Count);
//			int num = verts.Count * 2;
//			if (verts.Capacity < num)
//			{
//				verts.Capacity = num;
//			}
//			for (int i = start; i < end; i++)
//			{
//				UIVertex uIVertex = verts [i];
//				verts.Add (uIVertex);
				
//				Vector3 position = uIVertex.position;
//				//Debug.Log("vertex pos: "+position);
//				position.x += x;
//				position.y += y;
//				uIVertex.position = position;
//				Color32 color2 = color;
//				if (this.m_UseGraphicAlpha)
//				{
//					color2.a = (byte)(color2.a * verts [i].color.a / 255);
//				}
//				uIVertex.color = color2;
//				//uIVertex.color = (Color32)Color.blue;
//				verts [i] = uIVertex;
//			}
//		}

//#if UNITY_5_2 || UNITY_5_3 || UNITY_5_4 || UNITY_5_5 || UNITY_5_6 || UNITY_5_7 || UNITY_5_8 || UNITY_5_9
//        public override void ModifyMesh(VertexHelper vertexHelper)
//        {
//            if (!this.IsActive())
//                return;

//            List<UIVertex> list = new List<UIVertex>();
//            vertexHelper.GetUIVertexStream(list);

//            ModifyVertices(list);  // calls the old ModifyVertices which was used on pre 5.2

//			vertexHelper.Clear();
//            vertexHelper.AddUIVertexTriangleStream(list);
//        }
//#endif

//#if UNITY_5_2 || UNITY_5_3 || UNITY_5_4 || UNITY_5_5 || UNITY_5_6 || UNITY_5_7 || UNITY_5_8 || UNITY_5_9
//        public void ModifyVertices(List<UIVertex> verts)
//#else
//        public override void ModifyVertices(List<UIVertex> verts)
//#endif
//        {
//            if (!this.IsActive ())
//			{
//				return;
//			}
			
//			Text foundtext = GetComponent<Text>();
			
//			float best_fit_adjustment = 1f;
			
//			if (foundtext && foundtext.resizeTextForBestFit)  
//			{
//				best_fit_adjustment = (float)foundtext.cachedTextGenerator.fontSizeUsedForBestFit / (foundtext.resizeTextMaxSize-1); //max size seems to be exclusive 
				
//			}
			
//			float distanceX = this.effectDistance.x * best_fit_adjustment;
//			float distanceY = this.effectDistance.y * best_fit_adjustment;
			
//			int start = 0;
//			int count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, distanceX, distanceY);
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, distanceX, -distanceY);
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, -distanceX, distanceY);
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, -distanceX, -distanceY);
			
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, distanceX, 0);
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, -distanceX, 0);
			
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, 0, distanceY);
//			start = count;
//			count = verts.Count;
//			this.ApplyShadow (verts, this.effectColor, start, verts.Count, 0, -distanceY);
//		}
//	}
}
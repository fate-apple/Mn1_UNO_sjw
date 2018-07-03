//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//#if UNITY_EDITOR
//using UnityEditor;
//#endif
//[RequireComponent(typeof(PolygonCollider2D))]
//public class UI_PolygonRegion : Image
//{
//    private PolygonCollider2D _polygon = null;
//    public bool IsCircleRegion = false;
    
//    private PolygonCollider2D polygon
//    {
//        get
//        {
//            if (_polygon == null)
//                _polygon = GetComponent<PolygonCollider2D>();
//            return _polygon;
//        }
//    }
//    protected UI_PolygonRegion()
//    {
//        useLegacyMeshGeneration = true;
//    }
//    protected override void OnPopulateMesh(VertexHelper vh)
//    {
//        vh.Clear();
//    }
//    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
//    {
//        return polygon.OverlapPoint(eventCamera.ScreenToWorldPoint(screenPoint));
//    }

//#if UNITY_EDITOR
//    protected override void Reset()
//    {
//        base.Reset();
//        transform.localPosition = Vector3.zero;               //reset position relative to the parent transform
//        if (IsCircleRegion == true)
//        {
//            polygon.points = new Vector2[361];
//            polygon.points[0] = Vector2.zero;
//            for(int i = 0; i < 360; i++)
//            {
//                float rad = Mathf.Deg2Rad * i;
//                polygon.points[i] = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
//            }
//            return;
//        }
//        float w = (rectTransform.sizeDelta.x * 0.5f) + 0.1f;
//        float h = (rectTransform.sizeDelta.y * 0.5f) + 0.1f;
//        polygon.points = new Vector2[]
//        {
//            new Vector2(-w,-h),
//            new Vector2(w,-h),
//            new Vector2(w,h),
//            new Vector2(-w,h)
//          };
//    }
//#endif
//}
//#if UNITY_EDITOR
//[CustomEditor(typeof(UI_PolygonRegion), true)]
//public class UIPolygonInspector : Editor
//{
//    public override void OnInspectorGUI()
//    {
//    }
//}
//#endif
using System;
using System.Diagnostics;
using UnityEngine;

public static class NGUIMath
{
	[DebuggerHidden, DebuggerStepThrough]
	public static float Lerp(float from, float to, float factor)
	{
		return from * (1f - factor) + to * factor;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static int ClampIndex(int val, int max)
	{
		return (val >= 0) ? ((val >= max) ? (max - 1) : val) : 0;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static int RepeatIndex(int val, int max)
	{
		if (max < 1)
		{
			return 0;
		}
		while (val < 0)
		{
			val += max;
		}
		while (val >= max)
		{
			val -= max;
		}
		return val;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static float WrapAngle(float angle)
	{
		while (angle > 180f)
		{
			angle -= 360f;
		}
		while (angle < -180f)
		{
			angle += 360f;
		}
		return angle;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static float Wrap01(float val)
	{
		return val - (float)Mathf.FloorToInt(val);
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static int HexToDecimal(char ch)
	{
		switch (ch)
		{
		case '0':
			return 0;
		case '1':
			return 1;
		case '2':
			return 2;
		case '3':
			return 3;
		case '4':
			return 4;
		case '5':
			return 5;
		case '6':
			return 6;
		case '7':
			return 7;
		case '8':
			return 8;
		case '9':
			return 9;
		case ':':
		case ';':
		case '<':
		case '=':
		case '>':
		case '?':
		case '@':
			IL_67:
			switch (ch)
			{
			case 'a':
				return 10;
			case 'b':
				return 11;
			case 'c':
				return 12;
			case 'd':
				return 13;
			case 'e':
				return 14;
			case 'f':
				return 15;
			default:
				return 15;
			}
			break;
		case 'A':
			return 10;
		case 'B':
			return 11;
		case 'C':
			return 12;
		case 'D':
			return 13;
		case 'E':
			return 14;
		case 'F':
			return 15;
		}
		goto IL_67;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static char DecimalToHexChar(int num)
	{
		if (num > 15)
		{
			return 'F';
		}
		if (num < 10)
		{
			return (char)(48 + num);
		}
		return (char)(65 + num - 10);
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static string DecimalToHex(int num)
	{
		num &= 16777215;
		return num.ToString("X6");
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static int ColorToInt(Color c)
	{
		int num = 0;
		num |= Mathf.RoundToInt(c.r * 255f) << 24;
		num |= Mathf.RoundToInt(c.g * 255f) << 16;
		num |= Mathf.RoundToInt(c.b * 255f) << 8;
		return num | Mathf.RoundToInt(c.a * 255f);
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static Color IntToColor(int val)
	{
		float num = 0.003921569f;
		Color black = Color.black;
		black.r = num * (float)(val >> 24 & 255);
		black.g = num * (float)(val >> 16 & 255);
		black.b = num * (float)(val >> 8 & 255);
		black.a = num * (float)(val & 255);
		return black;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static string IntToBinary(int val, int bits)
	{
		string text = string.Empty;
		int i = bits;
		while (i > 0)
		{
			if (i == 8 || i == 16 || i == 24)
			{
				text += " ";
			}
			text += (((val & 1 << --i) == 0) ? '0' : '1');
		}
		return text;
	}

	[DebuggerHidden, DebuggerStepThrough]
	public static Color HexToColor(uint val)
	{
		return NGUIMath.IntToColor((int)val);
	}

	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		Rect result = rect;
		if ((float)width != 0f && (float)height != 0f)
		{
			result.xMin = rect.xMin / (float)width;
			result.xMax = rect.xMax / (float)width;
			result.yMin = 1f - rect.yMax / (float)height;
			result.yMax = 1f - rect.yMin / (float)height;
		}
		return result;
	}

	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		Rect result = rect;
		if (round)
		{
			result.xMin = (float)Mathf.RoundToInt(rect.xMin * (float)width);
			result.xMax = (float)Mathf.RoundToInt(rect.xMax * (float)width);
			result.yMin = (float)Mathf.RoundToInt((1f - rect.yMax) * (float)height);
			result.yMax = (float)Mathf.RoundToInt((1f - rect.yMin) * (float)height);
		}
		else
		{
			result.xMin = rect.xMin * (float)width;
			result.xMax = rect.xMax * (float)width;
			result.yMin = (1f - rect.yMax) * (float)height;
			result.yMax = (1f - rect.yMin) * (float)height;
		}
		return result;
	}

	public static Rect MakePixelPerfect(Rect rect)
	{
		rect.xMin = (float)Mathf.RoundToInt(rect.xMin);
		rect.yMin = (float)Mathf.RoundToInt(rect.yMin);
		rect.xMax = (float)Mathf.RoundToInt(rect.xMax);
		rect.yMax = (float)Mathf.RoundToInt(rect.yMax);
		return rect;
	}

	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		rect = NGUIMath.ConvertToPixels(rect, width, height, true);
		rect.xMin = (float)Mathf.RoundToInt(rect.xMin);
		rect.yMin = (float)Mathf.RoundToInt(rect.yMin);
		rect.xMax = (float)Mathf.RoundToInt(rect.xMax);
		rect.yMax = (float)Mathf.RoundToInt(rect.yMax);
		return NGUIMath.ConvertToTexCoords(rect, width, height);
	}

	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		Vector2 zero = Vector2.zero;
		float num = maxRect.x - minRect.x;
		float num2 = maxRect.y - minRect.y;
		float num3 = maxArea.x - minArea.x;
		float num4 = maxArea.y - minArea.y;
		float num5 = 0f;
		if (num > num3)
		{
			float num6 = num - num3;
			minArea.x -= num6;
			maxArea.x += num6;
		}
		if (num2 > num4)
		{
			float num7 = num2 - num4;
			minArea.y -= num7;
			maxArea.y += num7;
		}
		else
		{
			num5 = num4 - num2;
		}
		if (minRect.x < minArea.x)
		{
			zero.x += minArea.x - minRect.x;
		}
		if (maxRect.x > maxArea.x)
		{
			zero.x -= maxRect.x - maxArea.x;
		}
		if (minRect.y < minArea.y)
		{
			zero.y += minArea.y - minRect.y;
		}
		if (maxRect.y > maxArea.y)
		{
			zero.y -= maxRect.y - maxArea.y;
		}
		if (maxRect.y < maxArea.y && num5 > 0f)
		{
			zero.y = maxArea.y - maxRect.y;
		}
		return zero;
	}

	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		if (!(trans != null))
		{
			return new Bounds(Vector3.zero, Vector3.zero);
		}
		UIWidget[] componentsInChildren = trans.GetComponentsInChildren<UIWidget>();
		if (componentsInChildren.Length == 0)
		{
			return new Bounds(trans.position, Vector3.zero);
		}
		Vector3 vector = new Vector3(3.40282347E+38f, 3.40282347E+38f, 3.40282347E+38f);
		Vector3 vector2 = new Vector3(-3.40282347E+38f, -3.40282347E+38f, -3.40282347E+38f);
		int i = 0;
		int num = componentsInChildren.Length;
		while (i < num)
		{
			UIWidget uIWidget = componentsInChildren[i];
			if (uIWidget.enabled)
			{
				Vector3[] worldCorners = uIWidget.worldCorners;
				for (int j = 0; j < 4; j++)
				{
					vector2 = Vector3.Max(worldCorners[j], vector2);
					vector = Vector3.Min(worldCorners[j], vector);
				}
			}
			i++;
		}
		Bounds result = new Bounds(vector, Vector3.zero);
		result.Encapsulate(vector2);
		return result;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return NGUIMath.CalculateRelativeWidgetBounds(trans, trans, false);
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		return NGUIMath.CalculateRelativeWidgetBounds(trans, trans, considerInactive);
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		return NGUIMath.CalculateRelativeWidgetBounds(relativeTo, content, false);
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive)
	{
		if (content != null)
		{
			UIWidget[] componentsInChildren = content.GetComponentsInChildren<UIWidget>(considerInactive);
			if (componentsInChildren.Length > 0)
			{
				Vector3 vector = new Vector3(3.40282347E+38f, 3.40282347E+38f, 3.40282347E+38f);
				Vector3 vector2 = new Vector3(-3.40282347E+38f, -3.40282347E+38f, -3.40282347E+38f);
				Matrix4x4 worldToLocalMatrix = relativeTo.worldToLocalMatrix;
				bool flag = false;
				int i = 0;
				int num = componentsInChildren.Length;
				while (i < num)
				{
					UIWidget uIWidget = componentsInChildren[i];
					if (considerInactive || uIWidget.enabled)
					{
						Vector3[] worldCorners = uIWidget.worldCorners;
						for (int j = 0; j < 4; j++)
						{
							Vector3 lhs = worldToLocalMatrix.MultiplyPoint3x4(worldCorners[j]);
							vector2 = Vector3.Max(lhs, vector2);
							vector = Vector3.Min(lhs, vector);
						}
						flag = true;
					}
					i++;
				}
				if (flag)
				{
					Bounds result = new Bounds(vector, Vector3.zero);
					result.Encapsulate(vector2);
					return result;
				}
			}
		}
		return new Bounds(Vector3.zero, Vector3.zero);
	}

	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		if (deltaTime > 1f)
		{
			deltaTime = 1f;
		}
		float f = 1f - strength * 0.001f;
		int num = Mathf.RoundToInt(deltaTime * 1000f);
		float num2 = Mathf.Pow(f, (float)num);
		Vector3 a = velocity * ((num2 - 1f) / Mathf.Log(f));
		velocity *= num2;
		return a * 0.06f;
	}

	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		if (deltaTime > 1f)
		{
			deltaTime = 1f;
		}
		float f = 1f - strength * 0.001f;
		int num = Mathf.RoundToInt(deltaTime * 1000f);
		float num2 = Mathf.Pow(f, (float)num);
		Vector2 a = velocity * ((num2 - 1f) / Mathf.Log(f));
		velocity *= num2;
		return a * 0.06f;
	}

	public static float SpringLerp(float strength, float deltaTime)
	{
		if (deltaTime > 1f)
		{
			deltaTime = 1f;
		}
		int num = Mathf.RoundToInt(deltaTime * 1000f);
		deltaTime = 0.001f * strength;
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			num2 = Mathf.Lerp(num2, 1f, deltaTime);
		}
		return num2;
	}

	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		if (deltaTime > 1f)
		{
			deltaTime = 1f;
		}
		int num = Mathf.RoundToInt(deltaTime * 1000f);
		deltaTime = 0.001f * strength;
		for (int i = 0; i < num; i++)
		{
			from = Mathf.Lerp(from, to, deltaTime);
		}
		return from;
	}

	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return Vector2.Lerp(from, to, NGUIMath.SpringLerp(strength, deltaTime));
	}

	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return Vector3.Lerp(from, to, NGUIMath.SpringLerp(strength, deltaTime));
	}

	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return Quaternion.Slerp(from, to, NGUIMath.SpringLerp(strength, deltaTime));
	}

	public static float RotateTowards(float from, float to, float maxAngle)
	{
		float num = NGUIMath.WrapAngle(to - from);
		if (Mathf.Abs(num) > maxAngle)
		{
			num = maxAngle * Mathf.Sign(num);
		}
		return from + num;
	}

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		float sqrMagnitude = (b - a).sqrMagnitude;
		if (sqrMagnitude == 0f)
		{
			return (point - a).magnitude;
		}
		float num = Vector2.Dot(point - a, b - a) / sqrMagnitude;
		if (num < 0f)
		{
			return (point - a).magnitude;
		}
		if (num > 1f)
		{
			return (point - b).magnitude;
		}
		Vector2 b2 = a + num * (b - a);
		return (point - b2).magnitude;
	}

	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		bool flag = false;
		int val = 4;
		for (int i = 0; i < 5; i++)
		{
			Vector3 vector = screenPoints[NGUIMath.RepeatIndex(i, 4)];
			Vector3 vector2 = screenPoints[NGUIMath.RepeatIndex(val, 4)];
			if (vector.y > mousePos.y != vector2.y > mousePos.y && mousePos.x < (vector2.x - vector.x) * (mousePos.y - vector.y) / (vector2.y - vector.y) + vector.x)
			{
				flag = !flag;
			}
			val = i;
		}
		if (!flag)
		{
			float num = -1f;
			for (int j = 0; j < 4; j++)
			{
				Vector3 v = screenPoints[j];
				Vector3 v2 = screenPoints[NGUIMath.RepeatIndex(j + 1, 4)];
				float num2 = NGUIMath.DistancePointToLineSegment(mousePos, v, v2);
				if (num2 < num || num < 0f)
				{
					num = num2;
				}
			}
			return num;
		}
		return 0f;
	}

	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		Vector2[] array = new Vector2[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = cam.WorldToScreenPoint(worldPoints[i]);
		}
		return NGUIMath.DistanceToRectangle(array, mousePos);
	}

	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		Vector2 zero = Vector2.zero;
		if (pv == UIWidget.Pivot.Top || pv == UIWidget.Pivot.Center || pv == UIWidget.Pivot.Bottom)
		{
			zero.x = 0.5f;
		}
		else if (pv == UIWidget.Pivot.TopRight || pv == UIWidget.Pivot.Right || pv == UIWidget.Pivot.BottomRight)
		{
			zero.x = 1f;
		}
		else
		{
			zero.x = 0f;
		}
		if (pv == UIWidget.Pivot.Left || pv == UIWidget.Pivot.Center || pv == UIWidget.Pivot.Right)
		{
			zero.y = 0.5f;
		}
		else if (pv == UIWidget.Pivot.TopLeft || pv == UIWidget.Pivot.Top || pv == UIWidget.Pivot.TopRight)
		{
			zero.y = 1f;
		}
		else
		{
			zero.y = 0f;
		}
		return zero;
	}

	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		if (offset.x == 0f)
		{
			if (offset.y == 0f)
			{
				return UIWidget.Pivot.BottomLeft;
			}
			if (offset.y == 1f)
			{
				return UIWidget.Pivot.TopLeft;
			}
			return UIWidget.Pivot.Left;
		}
		else if (offset.x == 1f)
		{
			if (offset.y == 0f)
			{
				return UIWidget.Pivot.BottomRight;
			}
			if (offset.y == 1f)
			{
				return UIWidget.Pivot.TopRight;
			}
			return UIWidget.Pivot.Right;
		}
		else
		{
			if (offset.y == 0f)
			{
				return UIWidget.Pivot.Bottom;
			}
			if (offset.y == 1f)
			{
				return UIWidget.Pivot.Top;
			}
			return UIWidget.Pivot.Center;
		}
	}

	public static void MoveWidget(UIRect w, float x, float y)
	{
		NGUIMath.MoveRect(w, x, y);
	}

	public static void MoveRect(UIRect rect, float x, float y)
	{
		int num = Mathf.FloorToInt(x + 0.5f);
		int num2 = Mathf.FloorToInt(y + 0.5f);
		Transform cachedTransform = rect.cachedTransform;
		cachedTransform.localPosition += new Vector3((float)num, (float)num2);
		int num3 = 0;
		if (rect.leftAnchor.target)
		{
			num3++;
			rect.leftAnchor.absolute += num;
		}
		if (rect.rightAnchor.target)
		{
			num3++;
			rect.rightAnchor.absolute += num;
		}
		if (rect.bottomAnchor.target)
		{
			num3++;
			rect.bottomAnchor.absolute += num2;
		}
		if (rect.topAnchor.target)
		{
			num3++;
			rect.topAnchor.absolute += num2;
		}
		if (num3 != 0)
		{
			rect.UpdateAnchors();
		}
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
		NGUIMath.ResizeWidget(w, pivot, x, y, 2, 2, 100000, 100000);
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		if (pivot == UIWidget.Pivot.Center)
		{
			int num = Mathf.RoundToInt(x - (float)w.width);
			int num2 = Mathf.RoundToInt(y - (float)w.height);
			num -= (num & 1);
			num2 -= (num2 & 1);
			if ((num | num2) != 0)
			{
				num >>= 1;
				num2 >>= 1;
				NGUIMath.AdjustWidget(w, (float)(-(float)num), (float)(-(float)num2), (float)num, (float)num2, minWidth, minHeight);
			}
			return;
		}
		Vector3 point = new Vector3(x, y);
		point = Quaternion.Inverse(w.cachedTransform.localRotation) * point;
		switch (pivot)
		{
		case UIWidget.Pivot.TopLeft:
			NGUIMath.AdjustWidget(w, point.x, 0f, 0f, point.y, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.Top:
			NGUIMath.AdjustWidget(w, 0f, 0f, 0f, point.y, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.TopRight:
			NGUIMath.AdjustWidget(w, 0f, 0f, point.x, point.y, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.Left:
			NGUIMath.AdjustWidget(w, point.x, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.Right:
			NGUIMath.AdjustWidget(w, 0f, 0f, point.x, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.BottomLeft:
			NGUIMath.AdjustWidget(w, point.x, point.y, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.Bottom:
			NGUIMath.AdjustWidget(w, 0f, point.y, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.BottomRight:
			NGUIMath.AdjustWidget(w, 0f, point.y, point.x, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
		NGUIMath.AdjustWidget(w, left, bottom, right, top, 2, 2, 100000, 100000);
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
		NGUIMath.AdjustWidget(w, left, bottom, right, top, minWidth, minHeight, 100000, 100000);
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		Vector2 pivotOffset = w.pivotOffset;
		Transform transform = w.cachedTransform;
		Quaternion localRotation = transform.localRotation;
		int num = Mathf.FloorToInt(left + 0.5f);
		int num2 = Mathf.FloorToInt(bottom + 0.5f);
		int num3 = Mathf.FloorToInt(right + 0.5f);
		int num4 = Mathf.FloorToInt(top + 0.5f);
		if (pivotOffset.x == 0.5f && (num == 0 || num3 == 0))
		{
			num = num >> 1 << 1;
			num3 = num3 >> 1 << 1;
		}
		if (pivotOffset.y == 0.5f && (num2 == 0 || num4 == 0))
		{
			num2 = num2 >> 1 << 1;
			num4 = num4 >> 1 << 1;
		}
		Vector3 vector = localRotation * new Vector3((float)num, (float)num4);
		Vector3 vector2 = localRotation * new Vector3((float)num3, (float)num4);
		Vector3 vector3 = localRotation * new Vector3((float)num, (float)num2);
		Vector3 vector4 = localRotation * new Vector3((float)num3, (float)num2);
		Vector3 vector5 = localRotation * new Vector3((float)num, 0f);
		Vector3 vector6 = localRotation * new Vector3((float)num3, 0f);
		Vector3 vector7 = localRotation * new Vector3(0f, (float)num4);
		Vector3 vector8 = localRotation * new Vector3(0f, (float)num2);
		Vector3 zero = Vector3.zero;
		if (pivotOffset.x == 0f && pivotOffset.y == 1f)
		{
			zero.x = vector.x;
			zero.y = vector.y;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 0f)
		{
			zero.x = vector4.x;
			zero.y = vector4.y;
		}
		else if (pivotOffset.x == 0f && pivotOffset.y == 0f)
		{
			zero.x = vector3.x;
			zero.y = vector3.y;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 1f)
		{
			zero.x = vector2.x;
			zero.y = vector2.y;
		}
		else if (pivotOffset.x == 0f && pivotOffset.y == 0.5f)
		{
			zero.x = vector5.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector5.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 0.5f)
		{
			zero.x = vector6.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector6.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 1f)
		{
			zero.x = vector7.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector7.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 0f)
		{
			zero.x = vector8.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector8.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 0.5f)
		{
			zero.x = (vector5.x + vector6.x + vector7.x + vector8.x) * 0.5f;
			zero.y = (vector7.y + vector8.y + vector5.y + vector6.y) * 0.5f;
		}
		minWidth = Mathf.Max(minWidth, w.minWidth);
		minHeight = Mathf.Max(minHeight, w.minHeight);
		int num5 = w.width + num3 - num;
		int num6 = w.height + num4 - num2;
		Vector3 zero2 = Vector3.zero;
		int num7 = num5;
		if (num5 < minWidth)
		{
			num7 = minWidth;
		}
		else if (num5 > maxWidth)
		{
			num7 = maxWidth;
		}
		if (num5 != num7)
		{
			if (num != 0)
			{
				zero2.x -= Mathf.Lerp((float)(num7 - num5), 0f, pivotOffset.x);
			}
			else
			{
				zero2.x += Mathf.Lerp(0f, (float)(num7 - num5), pivotOffset.x);
			}
			num5 = num7;
		}
		int num8 = num6;
		if (num6 < minHeight)
		{
			num8 = minHeight;
		}
		else if (num6 > maxHeight)
		{
			num8 = maxHeight;
		}
		if (num6 != num8)
		{
			if (num2 != 0)
			{
				zero2.y -= Mathf.Lerp((float)(num8 - num6), 0f, pivotOffset.y);
			}
			else
			{
				zero2.y += Mathf.Lerp(0f, (float)(num8 - num6), pivotOffset.y);
			}
			num6 = num8;
		}
		if (pivotOffset.x == 0.5f)
		{
			num5 = num5 >> 1 << 1;
		}
		if (pivotOffset.y == 0.5f)
		{
			num6 = num6 >> 1 << 1;
		}
		Vector3 localPosition = transform.localPosition + zero + localRotation * zero2;
		transform.localPosition = localPosition;
		w.SetDimensions(num5, num6);
		if (w.isAnchored)
		{
			transform = transform.parent;
			float num9 = localPosition.x - pivotOffset.x * (float)num5;
			float num10 = localPosition.y - pivotOffset.y * (float)num6;
			if (w.leftAnchor.target)
			{
				w.leftAnchor.SetHorizontal(transform, num9);
			}
			if (w.rightAnchor.target)
			{
				w.rightAnchor.SetHorizontal(transform, num9 + (float)num5);
			}
			if (w.bottomAnchor.target)
			{
				w.bottomAnchor.SetVertical(transform, num10);
			}
			if (w.topAnchor.target)
			{
				w.topAnchor.SetVertical(transform, num10 + (float)num6);
			}
		}
	}

	public static int AdjustByDPI(float height)
	{
		float num = Screen.dpi;
		RuntimePlatform platform = Application.platform;
		if (num == 0f)
		{
			num = ((platform != RuntimePlatform.Android && platform != RuntimePlatform.IPhonePlayer) ? 96f : 160f);
		}
		int num2 = Mathf.RoundToInt(height * (96f / num));
		if ((num2 & 1) == 1)
		{
			num2++;
		}
		return num2;
	}
}

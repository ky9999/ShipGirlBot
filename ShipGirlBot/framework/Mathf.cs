﻿    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Mathf
    {
        public const float PI = 3.141593f;
        public const float Infinity = float.PositiveInfinity;
        public const float NegativeInfinity = float.NegativeInfinity;
        public const float Deg2Rad = 0.01745329f;
        public const float Rad2Deg = 57.29578f;
        public const float Epsilon = float.Epsilon;
        public static float Sin(float f)
        {
            return (float) Math.Sin((double) f);
        }

        public static float Cos(float f)
        {
            return (float) Math.Cos((double) f);
        }

        public static float Tan(float f)
        {
            return (float) Math.Tan((double) f);
        }

        public static float Asin(float f)
        {
            return (float) Math.Asin((double) f);
        }

        public static float Acos(float f)
        {
            return (float) Math.Acos((double) f);
        }

        public static float Atan(float f)
        {
            return (float) Math.Atan((double) f);
        }

        public static float Atan2(float y, float x)
        {
            return (float) Math.Atan2((double) y, (double) x);
        }

        public static float Sqrt(float f)
        {
            return (float) Math.Sqrt((double) f);
        }

        public static float Abs(float f)
        {
            return Math.Abs(f);
        }

        public static int Abs(int value)
        {
            return Math.Abs(value);
        }

        public static float Min(float a, float b)
        {
            return ((a >= b) ? b : a);
        }

        public static float Min(params float[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0f;
            }
            float num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] < num2)
                {
                    num2 = values[i];
                }
            }
            return num2;
        }

        public static int Min(int a, int b)
        {
            return ((a >= b) ? b : a);
        }

        public static int Min(params int[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0;
            }
            int num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] < num2)
                {
                    num2 = values[i];
                }
            }
            return num2;
        }

        public static float Max(float a, float b)
        {
            return ((a <= b) ? b : a);
        }

        public static float Max(params float[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0f;
            }
            float num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] > num2)
                {
                    num2 = values[i];
                }
            }
            return num2;
        }

        public static int Max(int a, int b)
        {
            return ((a <= b) ? b : a);
        }

        public static int Max(params int[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0;
            }
            int num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] > num2)
                {
                    num2 = values[i];
                }
            }
            return num2;
        }

        public static float Pow(float f, float p)
        {
            return (float) Math.Pow((double) f, (double) p);
        }

        public static float Exp(float power)
        {
            return (float) Math.Exp((double) power);
        }

        public static float Log(float f, float p)
        {
            return (float) Math.Log((double) f, (double) p);
        }

        public static float Log(float f)
        {
            return (float) Math.Log((double) f);
        }

        public static float Log10(float f)
        {
            return (float) Math.Log10((double) f);
        }

        public static float Ceil(float f)
        {
            return (float) Math.Ceiling((double) f);
        }

        public static float Floor(float f)
        {
            return (float) Math.Floor((double) f);
        }

        public static float Round(float f)
        {
            return (float) Math.Round((double) f);
        }

        public static int CeilToInt(float f)
        {
            return (int) Math.Ceiling((double) f);
        }

        public static int FloorToInt(float f)
        {
            return (int) Math.Floor((double) f);
        }

        public static int RoundToInt(float f)
        {
            return (int) Math.Round((double) f);
        }

        public static float Sign(float f)
        {
            return ((f < 0f) ? -1f : 1f);
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
            {
                value = min;
                return value;
            }
            if (value > max)
            {
                value = max;
            }
            return value;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
                return value;
            }
            if (value > max)
            {
                value = max;
            }
            return value;
        }

        public static float Clamp01(float value)
        {
            if (value < 0f)
            {
                return 0f;
            }
            if (value > 1f)
            {
                return 1f;
            }
            return value;
        }

        public static float Lerp(float from, float to, float t)
        {
            return (from + ((to - from) * Clamp01(t)));
        }

        public static float LerpAngle(float a, float b, float t)
        {
            float num = Repeat(b - a, 360f);
            if (num > 180f)
            {
                num -= 360f;
            }
            return (a + (num * Clamp01(t)));
        }

        public static float MoveTowards(float current, float target, float maxDelta)
        {
            if (Abs((float) (target - current)) <= maxDelta)
            {
                return target;
            }
            return (current + (Sign(target - current) * maxDelta));
        }

        public static float MoveTowardsAngle(float current, float target, float maxDelta)
        {
            target = current + DeltaAngle(current, target);
            return MoveTowards(current, target, maxDelta);
        }

        public static float SmoothStep(float from, float to, float t)
        {
            t = Clamp01(t);
            t = (((-2f * t) * t) * t) + ((3f * t) * t);
            return ((to * t) + (from * (1f - t)));
        }

        public static float Gamma(float value, float absmax, float gamma)
        {
            bool flag = false;
            if (value < 0f)
            {
                flag = true;
            }
            float num = Abs(value);
            if (num > absmax)
            {
                return (!flag ? num : -num);
            }
            float num2 = Pow(num / absmax, gamma) * absmax;
            return (!flag ? num2 : -num2);
        }

        public static bool Approximately(float a, float b)
        {
            return (Abs((float) (b - a)) < Max((float) (1E-06f * Max(Abs(a), Abs(b))), (float) 1.121039E-44f));
        }


        public static float Repeat(float t, float length)
        {
            return (t - (Floor(t / length) * length));
        }

        public static float PingPong(float t, float length)
        {
            t = Repeat(t, length * 2f);
            return (length - Abs((float) (t - length)));
        }

        public static float InverseLerp(float from, float to, float value)
        {
            if (from < to)
            {
                if (value < from)
                {
                    return 0f;
                }
                if (value > to)
                {
                    return 1f;
                }
                value -= from;
                value /= to - from;
                return value;
            }
            if (from <= to)
            {
                return 0f;
            }
            if (value < to)
            {
                return 1f;
            }
            if (value > from)
            {
                return 0f;
            }
            return (1f - ((value - to) / (from - to)));
        }

        public static float DeltaAngle(float current, float target)
        {
            float num = Repeat(target - current, 360f);
            if (num > 180f)
            {
                num -= 360f;
            }
            return num;
        }
        internal static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
        {
            float num = p2.x - p1.x;
            float num2 = p2.y - p1.y;
            float num3 = p4.x - p3.x;
            float num4 = p4.y - p3.y;
            float num5 = (num * num4) - (num2 * num3);
            if (num5 == 0f)
            {
                return false;
            }
            float num6 = p3.x - p1.x;
            float num7 = p3.y - p1.y;
            float num8 = ((num6 * num4) - (num7 * num3)) / num5;
            result = new Vector2(p1.x + (num8 * num), p1.y + (num8 * num2));
            return true;
        }

        internal static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
        {
            float num = p2.x - p1.x;
            float num2 = p2.y - p1.y;
            float num3 = p4.x - p3.x;
            float num4 = p4.y - p3.y;
            float num5 = (num * num4) - (num2 * num3);
            if (num5 == 0f)
            {
                return false;
            }
            float num6 = p3.x - p1.x;
            float num7 = p3.y - p1.y;
            float num8 = ((num6 * num4) - (num7 * num3)) / num5;
            if ((num8 < 0f) || (num8 > 1f))
            {
                return false;
            }
            float num9 = ((num6 * num2) - (num7 * num)) / num5;
            if ((num9 < 0f) || (num9 > 1f))
            {
                return false;
            }
            result = new Vector2(p1.x + (num8 * num), p1.y + (num8 * num2));
            return true;
        }
    }



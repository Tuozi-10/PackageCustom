using UnityEngine;

namespace com.jcavaillac.utils
{
    public static class Helpers
    {
        public static void ResetTransform(this Transform t)
        {
            t.localPosition = new Vector3(0, 0, 0);
            t.localEulerAngles = new Vector3(0, 0, 0);
            t.localScale = new Vector3(1, 1, 1);
        }
    }
}

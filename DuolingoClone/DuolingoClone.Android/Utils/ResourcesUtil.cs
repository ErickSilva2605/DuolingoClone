using Android.Content;

namespace DuolingoClone.Droid.Utils
{
    public class ResourcesUtil
    {
        public static int GetIconIdByFileName(string fileName, Context context)
        {
            return context.Resources.GetIdentifier(fileName, "drawable", context.PackageName);
        }
    }
}
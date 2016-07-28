using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using CognitiveCrmMobile.Utility;
using Android.Graphics;
using System.IO;

namespace CognitiveCrmMobile.Adapters
{
    static class GetImage
    {

        public static Drawable GetImageFromURL(string url, Activity context)
        {

            Drawable headshotDrawable = null;
            try
            {
                byte[] bitmapData;
                using (var stream = new MemoryStream())
                {
                    Bitmap image = ImageHelper.GetImageBitmapFromExternal(url);
                    if (image != null)
                    {
                        image.Compress(Bitmap.CompressFormat.Png, 0, stream);
                        bitmapData = stream.ToArray();
                        headshotDrawable = Drawable.CreateFromStream(stream, null);
                        return headshotDrawable;
                    }
                    
                }

                if (headshotDrawable == null)
                {
                    headshotDrawable = Drawable.CreateFromStream(context.Assets.Open(url), null);
                }

            }
            catch (Exception ex)
            {
                headshotDrawable = Drawable.CreateFromStream(context.Assets.Open("images/photo.png"), null);
            }
            return headshotDrawable;
        }
    }
}
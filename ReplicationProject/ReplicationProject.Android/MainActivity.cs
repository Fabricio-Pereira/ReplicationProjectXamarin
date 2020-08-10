using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Naxam.Controls.Platform.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin.Forms;
using Plugin.Iconize;

namespace ReplicationProject.Droid
{
    [Activity(Label = "ReplicationProject", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            var stateList = new Android.Content.Res.ColorStateList(
                    new int[][] {
                        new int[] { Android.Resource.Attribute.StateChecked },
                        new int[] { Android.Resource.Attribute.StateEnabled } },
                    new int[] {
                        Xamarin.Forms.Color.FromHex("#007f61").ToAndroid(), //Selected
                        Xamarin.Forms.Color.FromHex("#ababab").ToAndroid() //Normal
                    });

            BottomTabbedRenderer.FontSize = 10;
            BottomTabbedRenderer.IconSize = 20;
            BottomTabbedRenderer.ItemTextColor = stateList;
            BottomTabbedRenderer.ItemIconTintList = stateList;
            BottomTabbedRenderer.ItemSpacing = 8;
            BottomTabbedRenderer.ItemPadding = new Xamarin.Forms.Thickness(8);
            BottomTabbedRenderer.ShouldUpdateSelectedIcon = true;
            BottomTabbedRenderer.MenuItemIconSetter = (menuItem, iconSource, selected) =>
            {
                if (iconSource != null)
                {
                    var iconized = Iconize.FindIconForKey(iconSource.File);
                    if (iconized == null)
                    {
                        BottomTabbedRenderer.DefaultMenuItemIconSetter.Invoke(menuItem, iconSource, selected);

                        return;
                    }

                    var drawable = new IconDrawable(this, iconized).Color(selected ? Android.Graphics.Color.Red : Android.Graphics.Color.White).SizeDp(30);

                    menuItem.SetIcon(drawable);
                }
            };

            Plugin.Iconize.Iconize
                  .With(new Plugin.Iconize.Fonts.FontAwesomeSolidModule());

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
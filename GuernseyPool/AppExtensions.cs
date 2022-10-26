using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Shapes;

namespace GuernseyPool
{
    public static class AppExtensions
    {

        public static TStackLayout OrientationOfDisplay<TStackLayout>(this TStackLayout layout) where TStackLayout : StackLayout
        {
            layout.Orientation = DisplayToStackOrientation();

            return layout;
        }

        public static TStackLayout OrientationOfDisplay<TStackLayout>(this TStackLayout layout, DisplayInfo info) where TStackLayout : StackLayout
        {
            layout.Orientation = DisplayToStackOrientation(info);

            return layout;
        }

        private static StackOrientation DisplayToStackOrientation()
        {
            return DisplayToStackOrientation(DeviceDisplay.Current.MainDisplayInfo);
        }

        private static StackOrientation DisplayToStackOrientation(DisplayInfo info)
        {
            return info.Orientation == DisplayOrientation.Portrait ? StackOrientation.Vertical : StackOrientation.Horizontal;
        }

        public static TLayout Spacing<TLayout>(this TLayout layout, double spacing) where TLayout : StackBase
        {
            layout.Spacing = spacing;

            return layout;
        }

        public static TElement BackgroundColor<TElement>(this TElement element, Color backgroundColor) where TElement : VisualElement
        {
            element.BackgroundColor = backgroundColor;

            return element;
        }

        public static TShape CornerRadius<TShape>(this TShape shape, CornerRadius cornerRadius) where TShape : Shape, IShape
        {
            switch (shape)
            {
                case RoundRectangle:
                    shape.SetValue(RoundRectangle.CornerRadiusProperty, cornerRadius);
                    break;

                default:
                    throw new NotSupportedException($"{typeof(TShape)} is not supported");
            };

            return shape;
        }

        public static TBorder RoundCorners<TBorder>(this TBorder border, CornerRadius cornerRadius) where TBorder : Border
        {
            border.StrokeShape = new RoundRectangle() { CornerRadius = cornerRadius };

            return border;
        }

        public static TObject AddToList<TObject>(this TObject item, IList<TObject> list)
        {
            list.Add(item);

            return item;
        }

        public static TObject Link<TObject>(this TObject item, out TObject linkTo)
        {
            linkTo = item;

            return item;
        }

        public static TButton OnClicked<TButton>(this TButton button, EventHandler onClick) where TButton : Button
        {
            button.Clicked += onClick;

            return button;
        }

    }
}

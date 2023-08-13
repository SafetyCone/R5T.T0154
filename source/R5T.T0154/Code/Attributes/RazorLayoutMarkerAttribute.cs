using System;

using R5T.T0143;


namespace R5T.T0154
{
    /// <summary>
    /// Attribute indicating a type is a Razor layout.
    /// It's usually pretty clear that something is a Razor layout, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor layouts.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class,
        AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RazorLayoutMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor layout type.
        /// This is useful for marking types that end up canonical Razor layout code file locations, but are not actually Razor layouts.
        /// </summary>
        public bool IsRazorLayout { get; }


        public RazorLayoutMarkerAttribute(
            bool isRazorLayout = true)
        {
            this.IsRazorLayout = isRazorLayout;
        }
    }
}

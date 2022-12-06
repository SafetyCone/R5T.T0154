using System;

using R5T.T0143;


namespace R5T.T0154
{
    /// <summary>
    /// Attribute indicating a type is a Razor component.
    /// It's usually pretty clear that something is a Razor component, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor components.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class,
        AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RazorComponentMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor component type.
        /// This is useful for marking types that end up canonical Razor component code file locations, but are not actually Razor components.
        /// </summary>
        public bool IsRazorComponent { get; }


        public RazorComponentMarkerAttribute(
            bool isRazorComponent = true)
        {
            this.IsRazorComponent = isRazorComponent;
        }
    }
}

using System;

using R5T.T0143;


namespace R5T.T0154
{
    /// <summary>
    /// Attribute indicating a type is a draft Razor component.
    /// Draft Razor component types are quickly created functionality that should be reviewed and relocated, and thus full become Razor component types.
    /// It's usually pretty clear that something is a Razor component, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of draft Razor components as a kind of TODO list.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class,
        AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftRazorComponentMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a draft Razor component type.
        /// This is useful for marking types that end up canonical draft Razor component code file locations, but are not actually draft Razor components.
        /// </summary>
        public bool IsDraftRazorComponent { get; }


        public DraftRazorComponentMarkerAttribute(
            bool isDraftRazorComponent = true)
        {
            this.IsDraftRazorComponent = isDraftRazorComponent;
        }
    }
}

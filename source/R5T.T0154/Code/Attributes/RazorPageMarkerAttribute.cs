using System;

using R5T.T0143;


namespace R5T.T0154
{
    /// <summary>
    /// Attribute indicating a type is a Razor page.
    /// It's usually pretty clear that something is a Razor page, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor pages.
    /// <para>
    /// Note! The page marker is <strong>only</strong> for pages that are URL-reachable (usually only Razor components with a page-directive).
    /// </para>
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class,
        AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RazorPageMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor page type.
        /// This is useful for marking types that end up canonical Razor page code file locations, but are not actually Razor pages.
        /// </summary>
        public bool IsRazorPage { get; }


        public RazorPageMarkerAttribute(
            bool isRazorPage = true)
        {
            this.IsRazorPage = isRazorPage;
        }
    }
}

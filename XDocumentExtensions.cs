using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Extensions
{
    public static class XDocumentExtensions
    {
        public static IEnumerable<XElement> FilterByNameCaseInsensitive(this IEnumerable<XElement> elements, XName name)
        {
            return elements
                        .Where(e => e.Name.Namespace == name.Namespace
                                    &&
                                    e.Name.LocalName.Equals(name.LocalName, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<XAttribute> FilterByNameCaseInsensitive(this IEnumerable<XAttribute> attributes, XName name)
        {
            return attributes
                        .Where(e => e.Name.Namespace == name.Namespace
                                    &&
                                    e.Name.LocalName.Equals(name.LocalName, StringComparison.OrdinalIgnoreCase));
        }

        #region System.Xml.Linq.XContainer Methods
        public static IEnumerable<XElement> ElementsCaseInsensitive(this XContainer source, XName name)
        {
            return source.Elements().FilterByNameCaseInsensitive(name);
        }

        public static XElement ElementCaseInsensitive(this XContainer source, XName name)
        {
            return source.Elements().FilterByNameCaseInsensitive(name).SingleOrDefault();
        }

        public static IEnumerable<XElement> DescendantsCaseInsensitive(this XContainer source, XName name)
        {
            return source.Descendants().FilterByNameCaseInsensitive(name);
        }
        #endregion

        #region System.Xml.Linq.XNode Methods
        public static IEnumerable<XElement> AncestorsCaseInsensitive(this XNode source, XName name)
        {
            return source.Ancestors().FilterByNameCaseInsensitive(name);
        }

        public static IEnumerable<XElement> ElementsAfterSelfCaseInsensitive(this XNode source, XName name)
        {
            return source.ElementsAfterSelf().FilterByNameCaseInsensitive(name);
        }

        public static IEnumerable<XElement> ElementsBeforeSelfCaseInsensitive(this XNode source, XName name)
        {
            return source.ElementsBeforeSelf().FilterByNameCaseInsensitive(name);
        }
        #endregion

        #region System.Xml.Linq.XElement Methods
        public static IEnumerable<XElement> AncestorsAndSelfCaseInsensitive(this XElement source, XName name)
        {
            return source.AncestorsAndSelf().FilterByNameCaseInsensitive(name);
        }

        public static IEnumerable<XElement> DescendantsAndSelfCaseInsensitive(this XElement source, XName name)
        {
            return source.DescendantsAndSelf().FilterByNameCaseInsensitive(name);
        }

        public static IEnumerable<XAttribute> AttributesCaseInsensitive(this XElement source, XName name)
        {
            return source.Attributes().FilterByNameCaseInsensitive(name);
        }

        public static XAttribute AttributeCaseInsensitive(this XElement source, XName name)
        {
            return source.Attributes().FilterByNameCaseInsensitive(name).SingleOrDefault();
        }
        #endregion
    }
}
